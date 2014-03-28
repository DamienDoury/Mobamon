using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mobamon.Pokemon;
using Mobamon.Pokemon.Classes;
using Mobamon.Database;
using Mobamon.Database.Enums;
using Mobamon.Database.Classes;
using Mobamon.Moves;
using Mobamon.Pokemon.Helpers;
using Mobamon.GameManager;

namespace Mobamon.Pokemon.Player
{
	public class PokemonController : MonoBehaviour
	{
		#region Public fields		
        public int pokedex_id;
		public NavMeshAgent nav;
		public Transform laserSource;
		public string laserSourcePath = "";
		public GameObject hoverEntity;
		public SelectedMove selectedMove;
		/*public float maxHP = 300f;
		public float currentHP;
		public int team;*/
		//public float radius = 4f;
		public Camera myCam = null;
        public List<string> moveSet = new List<string>(4);
        public EntityManager entityManager { get; private set; }
		#endregion
		
		#region Private fields

        private bool isMine;
		private Animator anim;
		private GameObject marker;		
		private bool canMove = true;
		private bool canRotate = true;		
		public float turnSmoothing = 20f;
		private RaycastHit hit;		
		public Dictionary<MoveCategory, float> attackAnimHalfDuration = new Dictionary<MoveCategory, float>();		
		/*private float regenRate = 0.05f; // in % of max health/sec.
		
		private bool blinkAfterDamage = false;
		private float blinkDuration = 0f;
		private float blinkMaxDuration = 0.5f;
		private int numberOfBlinks = 1;
		private Color originalColor = new Color(0.8f, 0.8f, 0.8f, 1f);*/
		
		private Vector3 savedDestination;
		#endregion
		
		#region Public methods
		
		public void Start()
		{
            entityManager = GetComponent<EntityManager>();

            if (int.TryParse(name.Split('-') [0], out pokedex_id))
            {
                Debug.Log("The GameObject's name doesn't contain the Pokedex ID");
            }

			anim = GetComponent<Animator>();
			nav = GetComponent<NavMeshAgent>();
			
			marker = null;
			
			nav.autoRepath = true;
			nav.updateRotation = false; // We manage the rotation ourselves.
			nav.autoBraking = false; // This is less fancy, but more "accurate" for the player.
			
			laserSource = transform.Find("Armature/" + laserSourcePath);
			
			hoverEntity = null;
			
			moveSet.Add("Flamethrower");
			moveSet.Add("Frost Breath");
			moveSet.Add("Mud Sport");
			moveSet.Add("Poison Sting");
			
			selectedMove = null;
			
			/*currentHP = maxHP;
			savedDestination = new Vector3();*/

            this.gameObject.transform.parent = SceneHelper.GetContainer(Container.Pokemons).transform;

            Celshading.instance.ApplyShadingMode();
            ShareFogVision(); // This shouldn't be within this script.
		}
		
		public void Update()
		{
            //RandomizeMoveSet();
			
			if (isMine)
			{
				Controls();
			}
			
			// If the attack animation is done.
			if(selectedMove != null && selectedMove.isDone && anim.IsInTransition(0))
			{
				EndAttackState();
			}
			
			if(canRotate)
				Rotating();
			
			if(nav != null && nav.remainingDistance > 0f)
				Movement();
			
            if (nav != null)
			    anim.SetFloat("Speed", nav.velocity.magnitude);
		}

        public void SetMine()
        {
            isMine = true;

            // Player controller list network management.
            GameObject[] pokemonList = GameObject.FindGameObjectsWithTag("CameraTarget");
            foreach(GameObject pokemon in pokemonList)
                if(pokemon != gameObject)
                    pokemon.tag = "Untagged";
            
            // Camera list network management.
            GameObject[] cameraList = GameObject.FindGameObjectsWithTag("MainCamera");
            foreach(GameObject cam in cameraList)
                Destroy(cam);
            GameObject camera = (GameObject)Instantiate(Resources.Load("Camera/PlayerCamera"), new Vector3(transform.position.x, 5f, transform.position.z), Quaternion.identity);
            camera.tag = "MainCamera";
            myCam = camera.GetComponentInChildren<Camera>();
            
            // We add a Fog of War revealer.
            FOWRevealer fow = gameObject.AddComponent<FOWRevealer>();
            fow.range = new Vector2(0.5f, 20f);
            fow.lineOfSightCheck = FOWSystem.LOSChecks.EveryUpdate;
        }
		
		public void Controls()
		{
			if (isMine)
			{
				// Uses : selectedMove, hit and hoverEntity
				
				if(!(selectedMove != null && selectedMove.IsLaunched()))
				{
					if((Input.GetKeyDown("q") || Input.GetKeyDown("a")) && moveSet[0] != null)
					{
						SelectMove(0);
					}
					else if((Input.GetKeyDown("w") || Input.GetKeyDown("z")) && moveSet[1] != null)
					{
						SelectMove(1);
					}
					else if(Input.GetKeyDown("e") && moveSet[2] != null)
					{
						SelectMove(2);
					}
					else if(Input.GetKeyDown("r") && moveSet[3] != null)
					{
						SelectMove(3);
					}
				}
				
				if(selectedMove != null && !selectedMove.IsLaunched())
				{
					Ray ray = myCam.ScreenPointToRay(Input.mousePosition);
					
					if(Physics.Raycast(ray, out hit) && hit.transform.root == SceneHelper.GetContainer(Container.Entities))
					{
						hoverEntity = hit.transform.gameObject;

						SphereCollider targetCollider = (SphereCollider)hoverEntity.collider;

						if(selectedMove.info.TargetKind == MoveTargetKind.Single 
						   && Vector3.Magnitude(hoverEntity.transform.position - transform.position) > selectedMove.info.Range / 100f + nav.radius + targetCollider.radius)
							hoverEntity = null;
						
					}
					else
						hoverEntity = null;
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
							if(singleHit.collider.transform.parent.name == "Terrain")
							{
								if(theChosenHit.Equals(new RaycastHit()) || singleHit.distance < theChosenHit.distance)
								{
									theChosenHit = singleHit;
								}
							}
						}
						
						if(!theChosenHit.Equals(new RaycastHit()))
						{
							// The character has to move at least half of its width. 
							//if((theChosenHit.point - transform.position).magnitude >= nav.radius) 
							{
								theChosenHit.point.Set(theChosenHit.point.x, 0, theChosenHit.point.z);
								networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.LeftClick, theChosenHit.point, NetworkViewID.unassigned, -1);
							}
						}
					}
					else
					{
						// If a move is selected, but not launched :
						if(!selectedMove.IsLaunched())
						{
							bool attackLaunched = false;

							MoveTargetKind targetKind = selectedMove.info.TargetKind;
							
							int moveIndex = -1;
							for(int i = 0; i < moveSet.Count; i++)
								if(selectedMove.name == moveSet[i])
									moveIndex = i;
							
							if(targetKind == MoveTargetKind.Area)
							{
								networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.LeftClick, hit.point, NetworkViewID.unassigned, moveIndex);
								attackLaunched = true;
							}
							else if(targetKind == MoveTargetKind.Single && hoverEntity != null) // If the target type is not an area, then it's a single target spell. Therefore he needs a target.
							{
								PokemonRelation relation = entityManager.GetRelation(hoverEntity);

								if((relation & selectedMove.info.AllowedTargets) != 0)
								{
									SphereCollider targetCollider = (SphereCollider)hoverEntity.collider;
									
									if(Vector3.Magnitude(hoverEntity.transform.position - transform.position) <= selectedMove.info.Range / 100f + nav.radius + targetCollider.radius)
									{
										networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.LeftClick, hit.point, hoverEntity.networkView.viewID, moveIndex);
										attackLaunched = true;
									}
								}
							}

							if(!attackLaunched)
							{
								selectedMove = null; // If the player failed to click a right target for his attack, then we unselect it.
							}
							
							hoverEntity = null;
						}
					}
				}
				else if(Input.GetMouseButtonDown(1))
				{
					//SetLife(currentHP - 2f);
					
					if(selectedMove != null && !selectedMove.IsLaunched())
					{
						selectedMove = null;
					}
				}
			}
		}

		/*[RPC]
		public void SetDamage(float dmg)
		{
			float newLife = Mathf.Max(0, currentHP - dmg);
			this.gameObject.networkView.RPC("SetLife", RPCMode.All, newLife);
		}*/
		
		/*public PokemonRelation GetRelation(GameObject pokemon)
		{
			PokemonController controller = (PokemonController)pokemon.GetComponent(typeof(PokemonController));

			if(controller == null)
			{
				if(pokemon.transform.parent.name == "Pokemons")
					return PokemonRelation.Enemy; // We can target the NPCs.
				else
					return PokemonRelation.ERROR;
			}
			else if(this == controller)
			{
				return PokemonRelation.Self;
			}
			else
			{
				if(controller.team == team)
				{
					return PokemonRelation.Ally;
				}
				else
				{
					return PokemonRelation.Enemy; // Neutral monsters will also be considered as enemies.
				}
			}
		}*/
		
        public void ResetMovingRestrictions()
        {
            canMove = true;
            canRotate = true;
        }
		#endregion
		
		#region Private methods
        private void ShareFogVision()
        {
            GameObject playerPokemon = GameObject.FindWithTag("CameraTarget");
            
            if(playerPokemon == null)
            {
                Debug.LogError("Error: Pokemon not registered.");
            }
            else
            {
                int myTeam = playerPokemon.GetComponent<EntityManager>().team;
                
                foreach(EntityManager em in SceneHelper.GetContainer(Container.Entities).GetComponentsInChildren<EntityManager>())
                {
                    GameObject entity = em.gameObject;

                    if(em.team == myTeam)
                    {
                        if(entity.GetComponent<FOWRevealer>() == null)
                        {
                            FOWRevealer fow = entity.AddComponent<FOWRevealer>();
                            fow.range = new Vector2(0.5f, 20f);
                            fow.lineOfSightCheck = FOWSystem.LOSChecks.EveryUpdate;
                        }
                    }
                    else
                    {
                        if(entity.GetComponent<FOWRenderers>() == null)
                        {
                            entity.AddComponent<FOWRenderers>();
                        }
                    }
                }
            }
        }

		[RPC]
		private void ValidateControl(int input, Vector3 pos, NetworkViewID viewID, int moveIndex)
		{
			if (Network.isServer)
            {
                int team1Count = TeamHelper.GetPlayersCountInTeam(1);
                int team2Count = TeamHelper.GetPlayersCountInTeam(2);

                if (team1Count >= MatchManager.NumberOfPlayersRequiredInTeam && team2Count >= MatchManager.NumberOfPlayersRequiredInTeam)
                {

                    if (input == (int)InputType.LeftClick)
                    {
                        if (selectedMove == null && moveIndex == -1)
                        {
                            // The character has to move at least half of its width. 
                            //if((theChosenHit.point - transform.position).magnitude >= nav.radius) 
                            {
                                SetDestination(pos);
                            }
                        } else
                        {
                            // If a move is selected, but not launched :
                            //if(!selectedMove.IsLaunched())
                            if (selectedMove == null && moveIndex != -1)
                            {
                                SelectMove(moveIndex);

                                GameObject targetPokemon = new GameObject();
                                PokemonRelation relation = PokemonRelation.ERROR;

                                if (viewID != NetworkViewID.unassigned)
                                {
                                    targetPokemon = NetworkView.Find(viewID).gameObject;
                                    relation = entityManager.GetRelation(targetPokemon);
                                }
    							
                                MoveTargetKind targetKind = selectedMove.info.TargetKind;
                                bool attackLaunched = false;

                                if (targetKind == MoveTargetKind.Area)
                                {
                                    SetAttackState(NetworkViewID.unassigned, pos);
                                    attackLaunched = true;
                                } else if (targetKind == MoveTargetKind.Single && relation != PokemonRelation.ERROR) // If the target type is not an area, then it's a single target spell. Therefore he needs a target.
                                {
                                    bool isSelfOnly = ((int)PokemonRelation.Self ^ (int)selectedMove.info.AllowedTargets) == 0;

                                    if (isSelfOnly)
                                    {
                                        SetAttackState(viewID, pos);
                                        attackLaunched = true;
                                    } else
                                    {
                                        if (((int)selectedMove.info.AllowedTargets & (int)relation) != 0)
                                        {
                                            SphereCollider targetCollider = (SphereCollider)targetPokemon.collider;

                                            if (Vector3.Magnitude(targetPokemon.transform.position - transform.position) <= selectedMove.info.Range / 100f + nav.radius + targetCollider.radius)
                                            {
                                                SetAttackState(viewID, pos);
                                                attackLaunched = true;
                                            }
                                        }
                                    }
                                }

                                if (!attackLaunched)
                                {
                                    // If the player failed to click a right target for his attack, then we unselect it.
                                    selectedMove = null;
                                }
                            }
                        }
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
			
			if(isMine)
			{
				if(marker != null)
					Destroy(marker);
				
				marker = (GameObject)Instantiate(Resources.Load("Miscellaneous/Marker"), pos + Vector3.up / 10, new Quaternion());
			}
			
			nav.SetDestination(pos);
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
			/*if(Network.isServer)
				networkView.RPC("SelectMove", RPCMode.Others, index);*/
			
			selectedMove = new SelectedMove(moveSet[index]);
			
			bool isSelfOnly = ((int)PokemonRelation.Self ^ (int)selectedMove.info.AllowedTargets) == 0;
			
			if(isSelfOnly)
			{
				networkView.RPC("ValidateControl", RPCMode.Server, (int)InputType.LeftClick, transform.position + transform.forward, gameObject.networkView.viewID, index);
			}
		}
		
		private void Movement()
		{
			if(nav.remainingDistance < 0.3f)
			{
				nav.SetDestination(gameObject.transform.position); // This makes a smooth braking.
				//nav.updatePosition = false;
			}
			else
			{
				// We prevent the character from moving if its angle is too much different from the direction he should face.
				// This avoids the fast characters from sliding on the floor.
				/*if(Vector3.Angle(gameObject.transform.forward, nav.steeringTarget - gameObject.transform.position) > 60 || !canMove)
				{
					nav.updatePosition = false;
				}
				else
				{
					if(canMove)
						nav.updatePosition = true;
				}*/
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
			else if(nav != null && nav.remainingDistance > 0.3f)
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
			savedDestination = nav.destination;
			nav.SetDestination(transform.position);
			
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

				MoveTarget source = new MoveTarget(gameObject, transform.position);

				DamageManager damageManagerScript = (DamageManager)move.AddComponent(typeof(DamageManager));
				damageManagerScript.SetParameters(selectedMove.name, source, selectedMove.target);

				Move moveScript = (Move)move.AddComponent(typeof(Move));
				float freezeDuration = moveScript.SetMoveParameters(selectedMove.name, source, selectedMove.target);
				//float freezeDuration = selectedMove.info.Duration;

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
			if(selectedMove != null)
			{
				canMove = nav.updatePosition = true;
				canRotate = nav.updateRotation = true;
				nav.SetDestination(savedDestination);
			}
			
			anim.SetBool("PhysicalAttack", false);
			anim.SetBool("SpecialAttack", false);
			
			selectedMove = null;
		}
		
		/*private void RegenHP()
		{
			currentHP = Mathf.Min(maxHP, currentHP + maxHP * regenRate * Time.deltaTime);
		}
		
		[RPC]
		private void SetLife(float life)
		{
			currentHP = Mathf.Clamp(life, 0, maxHP);
			
			if(currentHP <= 0)
			{
				networkView.RPC("Die", RPCMode.All);
			}
			else
			{
				StartBlinking();
			}
		}
		
		[RPC]
		private void Die()
		{
			Invoke("Respawn", 3f);
			gameObject.SetActive(false);
		}
		
		private void Respawn()
		{
			// Visual setters
			transform.position = team % 2 == 0 ? GameInfo.blueTeamSpawn : GameInfo.redTeamSpawn;
			transform.rotation = Quaternion.identity;
			nav.ResetPath();
			
			// Logical setters
            entityManager.currentHP = entityManager.maxHP;
			selectedMove = null;
			canMove = true;
			canRotate = true;
			
			gameObject.SetActive(true);
			ResetBlinking();
		}
		
		private void StartBlinking()
		{
			blinkAfterDamage = true;
			blinkDuration = 0f;
		}
		
		private void BlinkAfterDamage()
		{ 
			if(!blinkAfterDamage)
				return;
			
			if(blinkDuration <= 0f)
				blinkDuration = blinkMaxDuration * numberOfBlinks * 2 - blinkMaxDuration; // Add " - blinkMaxDuration" to start from the red color.
			
			blinkDuration -= Time.deltaTime;
			
			Renderer rend = (Renderer)GetComponentInChildren(typeof(Renderer));
			Material[] matList = rend.materials;
			foreach(Material mat in matList)
			{
				float lerp = Mathf.PingPong(blinkDuration, blinkMaxDuration) / blinkMaxDuration;
				mat.color = Color.Lerp(originalColor, Color.red, lerp);*/
				//mat.Lerp(mat, dmgMat, lerp);
				//mat = dmgMat;
				// Alternate solution: Material.Lerp() with a plain red template material.
			/*}
			
			for(int i = 0; i < matList.Length; i++)
				matList[i].SetTexture("_MainTex", dmgMat.GetTexture("_MainTex"));

			for(int i = 0; i < matList.Length; i++)
				matList[i].CopyPropertiesFromMaterial(dmgMat);*/
			
			/*if(blinkDuration <= 0f)
			{
				ResetBlinking();
			}
		}*/
		
		/*private void ResetBlinking()
		{
			blinkAfterDamage = false;
			
			Renderer rend = (Renderer)gameObject.GetComponentInChildren(typeof(Renderer));
			Material[] matList = rend.materials;
			foreach(Material mat in matList)
				mat.color = originalColor;
		}*/
		
		[RPC]
		private void WarpEntity(NetworkViewID viewID, Vector3 pos, float speed, Quaternion rotation, Vector3 destination)
		{
			Vector3 dist = transform.position - pos;
			
			if(dist.magnitude > 0.5f && nav != null)
			{
				nav.Warp(pos);
				nav.SetDestination(destination);
				nav.speed = speed;
				transform.rotation = rotation;
			}
		}

		/*private void OnParticleCollision(GameObject particle)
		{
			if(Network.isServer)
			{
				if(particle.name.Equals("MainParticle"))
				{
					Transform move = particle.transform;

					while(move.parent.name != "Moves")
						move = move.parent;

					DamageManager man = move.GetComponent<DamageManager>();
					man.HasCollided(gameObject);
				}
			}
		}*/

        private void RandomizeMoveSet()
        {
            if(Input.GetKeyDown(KeyCode.Tab))
            {
                List<string> newMoveSet = new List<string>();
                List<string> availableMoves = Attackdex.move.Keys.ToList();

                for(int i = 0; i < moveSet.Count; i++)
                {
                    availableMoves.Remove(moveSet[i]);

                    int rand = Random.Range(0, availableMoves.Count);
                    newMoveSet.Add(availableMoves[rand]);

                    availableMoves.RemoveAt(rand);
                }

                networkView.RPC("SaveMoveSet", RPCMode.AllBuffered, newMoveSet[0], newMoveSet[1], newMoveSet[2], newMoveSet[3]);
            }
        }

        [RPC]
        private void SaveMoveSet(string move0, string move1, string move2, string move3)
        {
            if(moveSet != null && moveSet.Count > 3)
            {
                moveSet[0] = move0;
                moveSet[1] = move1;
                moveSet[2] = move2;
                moveSet[3] = move3;
            }
        }
		
		#endregion
	}
}