using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.Pokemon.Classes;
using Mobamon.Database.Enums;
using Mobamon.Database.Classes;
using Mobamon.Moves;

namespace Mobamon.Pokemon.Player
{
	public class PokemonController : MonoBehaviour
	{
		#region Public fields
		
		public Transform laserSource;
		public string laserSourcePath = "";
		public GameObject hoverEntity;
		public SelectedMove selectedMove;
		public float maxHP = 300f;
		public float currentHP;
		
		#endregion
		
		#region Private fields
		
		private Camera myCam = null;
		private Animator anim;
		private NavMeshAgent nav;		
		private GameObject marker;		
		private bool canMove = true;
		private bool canRotate = true;		
		public float turnSmoothing = 20f;
		private RaycastHit hit;		
		private List<string> moveSet = new List<string>(4);
		public Dictionary<MoveCategory, float> attackAnimHalfDuration = new Dictionary<MoveCategory, float>();		
		private float regenRate = 0.05f; // in % of max health/sec.
		
		#endregion
		
		#region Public methods
		
		public void Start()
		{
			anim = GetComponent<Animator>();
			nav = GetComponent<NavMeshAgent>();
			
			marker = null;
			
			nav.autoRepath = true;
			nav.updateRotation = false; // We manage the rotation ourselves.
			nav.autoBraking = false; // This is less fancy, but more "accurate" for the player.
			
			laserSource = transform.Find("Armature/" + laserSourcePath);
			
			hoverEntity = null;
			
			moveSet.Add("Waterfall");
			moveSet.Add("Flamethrower");
			moveSet.Add("Growl");
			moveSet.Add("Thunder Shock");
			
			selectedMove = null;
			
			currentHP = maxHP * 0.5f;
			
			if (networkView.isMine)
			{
				// Player controller list network management.
				GameObject[] pokemonList = GameObject.FindGameObjectsWithTag("CameraTarget");
				foreach(GameObject pokemon in pokemonList)
					if(pokemon != gameObject)
						pokemon.tag = "Untagged";
				/*Component[] controllerList = GameObject.Find("Pokemon").GetComponentsInChildren(typeof(PokemonController));
				foreach(Component comp in controllerList)
					if(comp.gameObject != gameObject)
						Destroy(comp);*/
				
				// Camera list network management.
				GameObject[] cameraList = GameObject.FindGameObjectsWithTag ("Camera");
				foreach(GameObject cam in cameraList)
					Destroy (cam);
				GameObject camera = (GameObject)Instantiate(Resources.Load("Camera/playerCamera"), new Vector3(5, 5, -20), Quaternion.identity);
				camera.tag = "Camera";
				myCam = (Camera)camera.GetComponent(typeof(Camera));
			}
		}
		
		public void Update()
		{
			RegenHP();
			
			if (networkView.isMine)
			{
				Controls ();
			}
			
			// If the attack animation is done.
			if(selectedMove != null && selectedMove.isDone && anim.IsInTransition(0))
			{
				EndAttackState();
			}
			
			if(canRotate)
				Rotating();
			
			if(nav.remainingDistance > 0f)
				Movement();
			
			anim.SetFloat("Speed", nav.velocity.magnitude);
		}
		
		public void Controls()
		{
			if (networkView.isMine)
			{
				// Uses : selectedMove, hit and hoverEntity
				
				if(!(selectedMove != null && selectedMove.IsLaunched()))
				{
					if((Input.GetKeyDown("q") || Input.GetKeyDown("a")) && moveSet[0] != null)
					{
						networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.Q, Input.mousePosition, NetworkViewID.unassigned);
					}
					else if((Input.GetKeyDown("w") || Input.GetKeyDown("z")) && moveSet[1] != null)
					{
						networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.W, Input.mousePosition, NetworkViewID.unassigned);
					}
					else if(Input.GetKeyDown("e") && moveSet[2] != null)
					{
						networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.E, Input.mousePosition, NetworkViewID.unassigned);
					}
					else if(Input.GetKeyDown("r") && moveSet[3] != null)
					{
						networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.R, Input.mousePosition, NetworkViewID.unassigned);
					}
				}
				
				if(selectedMove != null && !selectedMove.IsLaunched())
				{
					Ray ray = myCam.ScreenPointToRay(Input.mousePosition);
					
					if(Physics.Raycast(ray, out hit) && hit.transform.parent.name == "Pokemon")
						hoverEntity = hit.transform.gameObject;
					else
						hoverEntity = null;
					
					//hit.transform.position.Set(hit.transform.position.x, 0, hit.transform.position.z);
				}
				
				if(Input.GetMouseButtonDown(0))
				{
					if(selectedMove == null)
					{
						Ray ray = myCam.ScreenPointToRay(Input.mousePosition);
						RaycastHit[] hits;
						hits = Physics.RaycastAll(ray, 100.0f);
						
						RaycastHit theChosenHit = new RaycastHit();
						foreach(RaycastHit singleHit in hits)
						{
							//if(singleHit.collider.transform.name == "Ground")
							if(singleHit.collider.transform.parent.name == "Terrain")
							{
								if(theChosenHit.Equals(new RaycastHit()) || singleHit.distance < theChosenHit.distance)
								{
									theChosenHit = singleHit;
								}
							}
						}
						
						if(!theChosenHit.Equals(new RaycastHit()))
							//if(Physics.Raycast(ray, out hit) && (hit.transform.parent.name == "Terrain" || hit.transform.parent.name == "Pokemon"))
						{
							// The character has to move at least half of its width. 
							// NOTE: We divide by five because the model scale is 1/5.
							//if((hit.point - nav.transform.position).magnitude > nav.radius / 5) 
							{
								//NavMeshHit sampleHit;
								//if(NavMesh.SamplePosition(hit.point, out sampleHit, 1f, 1 << NavMesh.GetNavMeshLayerFromName("Default"))) // I was trying to prevent the character from touching the walls, using its NavMeshRadius.
								{
									theChosenHit.point.Set(theChosenHit.point.x, 0, theChosenHit.point.z);
									
									networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.LeftClick, theChosenHit.point, NetworkViewID.unassigned);
								}
							}
						}
					}
					else
					{
						// If a move is selected, but not launched :
						if(!selectedMove.IsLaunched())
						{
							MoveTargetKind targetKind = selectedMove.info.TargetKind;
							PokemonRelation relation = PokemonRelation.Enemy; //this.GetRelation(selectedMove.target.Controller);
							
							if(targetKind == MoveTargetKind.Area)
							{
								networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.LeftClick, hit.point, NetworkViewID.unassigned);
							}
							else if(hoverEntity != null) // If the target type is not an area, then it's a single target spell. Therefore he needs a target.
							{
								if(relation == PokemonRelation.Enemy && !hoverEntity.Equals(gameObject))
								{
									networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.LeftClick, hit.point, hoverEntity.networkView.viewID);
									//hoverEntity = null;
								}
							}
							else
							{
								// If the player failed to click a right target for his attack, then we unselect it.
								selectedMove = null;
							}
							
							hoverEntity = null;
						}
					}
				}
				else if(Input.GetMouseButtonDown(1))
				{
					if(selectedMove != null && !selectedMove.IsLaunched())
					{
						networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.RightClick, Input.mousePosition, NetworkViewID.unassigned);
					}
				}
			}
		}
		
		public void SetDamage(float dmg)
		{
			float newLife = Mathf.Max(0, currentHP - dmg);
			this.gameObject.networkView.RPC ("SetLife", RPCMode.AllBuffered, newLife);
		}
		
		public PokemonRelation GetRelation(PokemonController controller)
		{
			if (this == controller)
			{
				return PokemonRelation.Self;
			}
			else
			{
				return PokemonRelation.Enemy;
			}
		}
		
		#endregion
		
		#region Private methods
		
		[RPC]
		private void ValidateControl(int input, Vector3 pos, NetworkViewID viewID)
		{
			if(Network.isServer)
			{
				// Uses : selectedMove, hit and hoverEntity
				
				if(!(selectedMove != null && selectedMove.IsLaunched()))
				{
					if(input == (int)InputType.Q && moveSet[0] != null)
					{
						SelectMove(0);
					}
					else if(input == (int)InputType.W && moveSet[1] != null)
					{
						SelectMove(1);
					}
					else if(input == (int)InputType.E && moveSet[2] != null)
					{
						SelectMove(2);
					}
					else if(input == (int)InputType.R && moveSet[3] != null)
					{
						SelectMove(3);
					}
				}
				
				if(input == (int)InputType.LeftClick)
				{
					if(selectedMove == null)
					{
						SetDestination(pos);
					}
					else
					{
						// If a move is selected, but not launched :
						if(!selectedMove.IsLaunched())
						{
							MoveTargetKind targetKind = selectedMove.info.TargetKind;
							PokemonRelation relation = PokemonRelation.Enemy;  //this.GetRelation(selectedMove.target.Controller);
							
							if(targetKind == MoveTargetKind.Area)
							{
								SetAttackState(NetworkViewID.unassigned, pos);
							}
							else if(viewID != NetworkViewID.unassigned) // If the target type is not an area, then it's a single target spell. Therefore he needs a target.
							{
								if(relation == PokemonRelation.Enemy) // As we don't check if the player is targetting himself with an offensive spell, the player might cheat and kill himself.
								{
									SetAttackState(viewID, pos);
								}
							}
							else
							{
								// If the player failed to click a right target for his attack, then we unselect it.
								selectedMove = null;
							}
						}
					}
				}
				else if(input == (int)InputType.RightClick)
				{
					if(selectedMove != null && !selectedMove.IsLaunched())
					{
						CancelTargetting();
					}
				}
			}
		}
		
		[RPC]
		private void SetDestination(Vector3 pos)
		{
			if(Network.isServer)
			{
				networkView.RPC("SetDestination", RPCMode.Others, pos);
			}
			
			if(networkView.isMine)
			{
				if(marker != null)
					Destroy(marker);
				
				marker = (GameObject)Instantiate(Resources.Load("Miscellaneous/Marker"), pos + Vector3.up / 10, new Quaternion());
			}
			
			nav.destination = pos;
		}
		
		[RPC]
		private void SetAttackState(NetworkViewID viewID, Vector3 pos)
		{
			if(Network.isServer)
				networkView.RPC("SetAttackState", RPCMode.Others, viewID, pos);
			
			GameObject targetPokemon = null;
			
			if(!viewID.Equals(NetworkViewID.unassigned)) // && PokemonList.instance.ContainsKey(instanceID))
			{
				targetPokemon = NetworkView.Find(viewID).gameObject;
				//targetPokemon = PokemonList.instance[instanceID];
			}
			
			
			selectedMove.SetTarget(new MoveTarget(targetPokemon, pos));
			canMove = nav.updatePosition = false;
			
			// Then, the LaunchAttackAnim is called from the Rotating() method.
		}
		
		[RPC]
		private void SelectMove(int index)
		{
			if(Network.isServer)
				networkView.RPC("SelectMove", RPCMode.Others, index);
			
			selectedMove = new SelectedMove(moveSet[index]);

			bool isSelfOnly = (PokemonRelation.Self & selectedMove.info.AllowedTargets) == PokemonRelation.Self
								&& (PokemonRelation.Ally & selectedMove.info.AllowedTargets) == 0
								&& (PokemonRelation.Enemy & selectedMove.info.AllowedTargets) == 0;

			if(isSelfOnly)
			{
				SetAttackState(gameObject.networkView.viewID, transform.position);
			}
		}
		
		[RPC]
		private void CancelTargetting()
		{
			if(UnityEngine.Network.isServer)
				networkView.RPC("CancelTargetting", RPCMode.Others, null);
			
			EndAttackState();
			selectedMove = null;
		}
		
		private void Movement()
		{
			if(nav.remainingDistance < 0.3f)
			{
				nav.destination = gameObject.transform.position; // This makes a smooth braking.
				//nav.updatePosition = false;
			}
			else
			{
				// We prevent the character from moving if its angle is too much different from the direction he should face.
				// This avoids the fast characters from sliding on the floor.
				if(Vector3.Angle(gameObject.transform.forward, nav.steeringTarget - gameObject.transform.position) > 60 || !canMove)
				{
					nav.updatePosition = false;
				}
				else
				{
					//if(canMove)
					nav.updatePosition = true;
				}
			}
			
			gameObject.transform.position.Set(gameObject.transform.position.x, 0, gameObject.transform.position.z);
		}
		
		private void Rotating()
		{
			if(!canRotate)
				return;
			
			Vector3 target = new Vector3();
			if(selectedMove != null && selectedMove.target != null && !selectedMove.isDone)
			{
				if(selectedMove.target.GameObject != null && selectedMove.info.IsFollowingTarget)
					target = selectedMove.target.CurrentPosition;
				else
					target = selectedMove.target.StartPosition;
				
				target -= gameObject.transform.position;
				target.Set(target.x, 0, target.z);
				target.Normalize();
				
				float angle = Vector3.Angle(gameObject.transform.forward, target);
				if(angle < 1.0f)
				{
					LaunchAttackAnim();
				}
			}
			else if(nav.remainingDistance > 0.3f)
			{
				target = nav.steeringTarget;
				target -= gameObject.transform.position;
				target.Set(target.x, 0, target.z);
				target.Normalize();
			}
			else
			{
				return;
			}
			
			Quaternion forwardRotation = Quaternion.LookRotation(gameObject.transform.forward, Vector3.up);
			Quaternion targetRotation = Quaternion.LookRotation(target, Vector3.up);
			
			Quaternion newRotation = new Quaternion();
			float angleBis = Vector3.Angle(gameObject.transform.forward, target);
			if(angleBis < 2.0f)
				newRotation = targetRotation;
			else
				newRotation = Quaternion.Lerp(forwardRotation, targetRotation, turnSmoothing * Time.deltaTime);
			
			gameObject.transform.rotation = newRotation;
		}
		
		private void LaunchAttackAnim()
		{
			/*if(networkView.isMine)
				networkView.RPC("LaunchAttackAnim", RPCMode.Others, null);*/
			
			canRotate = nav.updateRotation = false;
			
			if(selectedMove.info.Category == MoveCategory.Physical)
				anim.SetBool("PhysicalAttack", true);
			else
				anim.SetBool("SpecialAttack", true);
			
			// Then, LaunchAttack is called by the attack animation event.
		}
		
		private void LaunchAttack(float holdDuration)
		{
			if(selectedMove != null && selectedMove.target != null) //networkView.isMine && 
			{
				GameObject move = (GameObject)Instantiate(Resources.Load("Moves/" + selectedMove.name));
				move.transform.parent = GameObject.Find("Moves").transform;
				
				Move script = (Move)move.AddComponent(typeof(Move));
				MoveTarget source = new MoveTarget(gameObject, transform.position);
				float freezeDuration = script.SetMoveParameters(selectedMove.name, source, selectedMove.target);
				Invoke("Unfreeze", freezeDuration); // Even the non-immobilizing moves need to "unfreeze" the animation.
				
				if(freezeDuration > 0)
				{	
					float maxAttackAnimSpeed = 0.2f;
					/*if(attackAnimHalfDuration.ContainsKey(selectedMove.info.attackCategory))
					{
						float ratio = attackAnimHalfDuration[selectedMove.info.attackCategory] / freezeDuration / 2;
						anim.speed = Mathf.Min(ratio, maxAttackAnimSpeed);
					}
					else*/
					{
						anim.speed = maxAttackAnimSpeed;
					}
				}
			}
		}
		
		private void Unfreeze()
		{
			selectedMove.isDone = true;
			anim.speed = 1.0f;
		}
		
		private void EndAttackState()
		{
			canMove = nav.updatePosition = true;
			canRotate = nav.updateRotation = true;
			
			anim.SetBool("PhysicalAttack", false);
			anim.SetBool("SpecialAttack", false);
			
			selectedMove = null;
		}
		
		private void RegenHP()
		{
			currentHP = Mathf.Min(maxHP, currentHP + maxHP * regenRate * Time.deltaTime);
		}
		
		[RPC]
		private void SetLife(float life)
		{
			currentHP = life;
		}
		
		#endregion
	}
}