using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PokemonController : MonoBehaviour
{
	private Camera myCam = null;
	private Animator anim;
	private NavMeshAgent nav;
	public Transform laserSource;
	
	private GameObject marker;
	
	private bool canMove = true;
	private bool canRotate = true;
	public string laserSourcePath = "";
	
	public float turnSmoothing = 20f;

	public GameObject hoverEntity;
	private RaycastHit hit;
	
	private List<string> moveSet = new List<string>(4);
	public SelectedMove selectedMove;
	public Dictionary<AttackCategory, float> attackAnimHalfDuration = new Dictionary<AttackCategory, float>();

	/*public Animator anim;
	public NavMeshAgent nav;
	public Transform laserSource;
	
	public GameObject marker;
	
	public bool canMove = true;
	public bool canRotate = true;
	public string laserSourcePath = "";
	
	public float turnSmoothing = 20f;
	
	public Texture2D hand;
	public Vector2 handPos;
	public Texture2D single;
	public Vector2 singlePos;
	public Texture2D singleAlly;
	public Vector2 singleAllyPos;
	public Texture2D singleEnemy;
	public Vector2 singleEnemyPos;
	public GameObject hoverEntity;
	public RaycastHit hit;
	
	public List<string> moveSet = new List<string>(4);
	public SelectedMove selectedMove;
	public Dictionary<AttackCategory, float> attackAnimHalfDuration = new Dictionary<AttackCategory, float>();*/
	
	// Use this for initialization
	void Start ()
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
		moveSet.Add(null);

		selectedMove = null;

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
	
	void Update ()
	{
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

	void Controls()
	{
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
			
			if(Physics.Raycast(ray, out hit) && hit.transform.parent.name == "Pokemon")
				hoverEntity = hit.transform.gameObject;
			else
				hoverEntity = null;
			
			hit.transform.position.Set(hit.transform.position.x, 0, hit.transform.position.z);
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

							SetDestination(theChosenHit.point);
						}
					}
				}
			}
			else
			{
				// If a move is selected, but not launched :
				if(!selectedMove.IsLaunched())
				{
					TargetType targetType = selectedMove.info.targetType;
					
					if(targetType == TargetType.Area)
					{
						SetAttackState(-1, hit.point);
					}
					else if(hoverEntity != null) // If the target type is not an area, then it's a single target spell. Therefore he needs a target.
					{
						if(targetType == TargetType.Enemy && !hoverEntity.Equals(gameObject))
						{
							SetAttackState(hoverEntity.GetInstanceID(), hit.point);
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
				CancelTargetting();
			}
		}
	}

	[RPC]
	void SetDestination(Vector3 pos)
	{
		if(networkView.isMine)
		{
			networkView.RPC("SetDestination", RPCMode.Others, pos);

			if(marker != null)
				Destroy(marker);
			
			marker = (GameObject)Instantiate(Resources.Load("Miscellaneous/Marker"), pos + Vector3.up / 10, new Quaternion());
		}

		nav.destination = pos;
	}

	[RPC]
	void CancelTargetting()
	{
		if(networkView.isMine)
			networkView.RPC("CancelTargetting", RPCMode.Others, null);

		EndAttackState();
		selectedMove = null;
	}
	
	void Movement()
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

	void Rotating()
	{
		if(!canRotate)
			return;

		Vector3 target = new Vector3();
		if(selectedMove != null && selectedMove.target != null && !selectedMove.isDone)
		{
			if(selectedMove.target.obj != null && selectedMove.info.isFollowing)
				target = selectedMove.target.obj.transform.position;
			else
				target = selectedMove.target.pos;

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

	[RPC]
	void SetAttackState(int instanceID, Vector3 pos)
	{
		if(networkView.isMine)
			networkView.RPC("SetAttackState", RPCMode.Others, instanceID, pos);

		GameObject targetPokemon = null;

		if(instanceID != -1 && PokemonList.instance.ContainsKey(instanceID))
			targetPokemon = PokemonList.instance[instanceID];

		selectedMove.SetTarget(new Target(targetPokemon, pos));
		canMove = nav.updatePosition = false;
	}
	
	void LaunchAttackAnim()
	{
		/*if(networkView.isMine)
			networkView.RPC("LaunchAttackAnim", RPCMode.Others, null);*/

		canRotate = nav.updateRotation = false;
		
		if(selectedMove.info.attackCategory == AttackCategory.Physical)
			anim.SetBool("PhysicalAttack", true);
		else
			anim.SetBool("SpecialAttack", true);
	}

	void LaunchAttack(float holdDuration)
	{
		if(selectedMove != null && selectedMove.target != null) //networkView.isMine && 
		{
			GameObject move = (GameObject)Instantiate(Resources.Load("Moves/" + selectedMove.name));
			move.transform.parent = GameObject.Find("Moves").transform;
			
			Attack script = (Attack)move.AddComponent(typeof(Attack));
			Target source = new Target(gameObject, transform.position);
			float freezeDuration = script.SetAttackParams(selectedMove.name, source, selectedMove.target);
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


	void Unfreeze()
	{
		selectedMove.isDone = true;
		anim.speed = 1.0f;
	}

	void EndAttackState()
	{
		canMove = nav.updatePosition = true;
		canRotate = nav.updateRotation = true;

		anim.SetBool("PhysicalAttack", false);
		anim.SetBool("SpecialAttack", false);
		
		selectedMove = null;
	}

	[RPC]
	void SelectMove(int index)
	{
		if(networkView.isMine)
			networkView.RPC("SelectMove", RPCMode.Others, index);

		selectedMove = new SelectedMove(moveSet[index]);

		if(selectedMove.info.targetType == TargetType.Self)
		{
			SetAttackState(gameObject.GetInstanceID(), transform.position);
		}
	}
}
