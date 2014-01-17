using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PokemonController : MonoBehaviour
{
	private Animator anim;
	private NavMeshAgent nav;
	private HashIDs hash;
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
	public HashIDs hash;
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
		hash = GameObject.FindGameObjectWithTag(Tags.GameController).GetComponent<HashIDs>();
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
	}
	
	void Update ()
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
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			if(Physics.Raycast(ray, out hit) && hit.transform.parent.name == "Pokemon")
				hoverEntity = hit.transform.gameObject;
			else
				hoverEntity = null;
		}

		if(Input.GetMouseButtonDown(0))
		{
			if(selectedMove == null)
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if(Physics.Raycast(ray, out hit) && (hit.transform.parent.name == "Terrain" || hit.transform.parent.name == "Pokemon"))
				{
					// The character has to move at least half of its width. 
					// NOTE: We divide by five because the model scale is 1/5.
					//if((hit.point - nav.transform.position).magnitude > nav.radius / 5) 
					{
						//NavMeshHit sampleHit;
						//if(NavMesh.SamplePosition(hit.point, out sampleHit, 1f, 1 << NavMesh.GetNavMeshLayerFromName("Default"))) // I was trying to prevent the character from touching the walls, using its NavMeshRadius.
						{
							nav.destination = hit.point;

							if(marker != null)
								Destroy(marker);

							marker = (GameObject)Instantiate(Resources.Load("Miscellaneous/Marker"), hit.point - new Vector3(0, hit.point.y, 0) + Vector3.up/10, new Quaternion());
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
						SetAttackState(new Target(null, hit.point));
					}
					else if(hoverEntity != null) // If the target type is not an area, then it's a single target spell. Therefore he needs a target.
					{
						if(targetType == TargetType.Enemy && !hoverEntity.Equals(gameObject))
						{
							SetAttackState(new Target(hoverEntity, hit.point));
							hoverEntity = null;
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
		else if(Input.GetMouseButtonDown(1))
		{
			selectedMove = null;
		}

		if(canRotate)
			Rotating();
		
		if(nav.remainingDistance > 0f)
			Movement();

		anim.SetFloat(hash.speed, nav.velocity.magnitude);
	}

	void FixedUpdate()
	{
		// If the attack animation is done.
		if(selectedMove != null && selectedMove.isDone && anim.IsInTransition(0))
		{
			EndAttackState();
		}
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
			// This avoids the fast characters from sliding if the floor.
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
	}

	void Rotating()
	{
		Vector3 target = new Vector3();
		if(selectedMove != null && selectedMove.target != null && !selectedMove.isDone)
		{
			if(selectedMove.target.obj != null && selectedMove.info.isFollowing)
				target = selectedMove.target.obj.transform.position - gameObject.transform.position;
			else
				target = selectedMove.target.pos - gameObject.transform.position;

			target.Normalize();
			if(Vector3.Angle(gameObject.transform.forward, target) < 10 && canRotate)
				LaunchAttackAnim();
		}
		else if(nav.remainingDistance > 0.3f)
		{
			target = nav.steeringTarget - gameObject.transform.position;
		}
		else
		{
			return;
		}

		target.Normalize();
		Quaternion forwardRotation = Quaternion.LookRotation(gameObject.transform.forward, Vector3.up);
		Quaternion targetRotation = Quaternion.LookRotation(target, Vector3.up);
		Quaternion newRotation = Quaternion.Lerp(forwardRotation, targetRotation, turnSmoothing * Time.deltaTime);

		gameObject.transform.rotation = newRotation;
	}
	
	void SetAttackState(Target p_target)
	{
		selectedMove.SetTarget(p_target);

		canMove = nav.updatePosition = false;
		//LaunchAttackAnim();
	}

	void LaunchAttackAnim()
	{
		canRotate = nav.updateRotation = false;
		
		if(selectedMove.info.attackCategory == AttackCategory.Physical)
			anim.SetBool(hash.physicalAttack, true);
		else
			anim.SetBool(hash.specialAttack, true);
	}

	void LaunchAttack(float holdDuration)
	{
		if(selectedMove != null && selectedMove.target != null)
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

	public void Unfreeze()
	{
		selectedMove.isDone = true;
		anim.speed = 1.0f;
	}

	public void EndAttackState()
	{
		canMove = nav.updatePosition = true;
		canRotate = nav.updateRotation = true;

		anim.SetBool(hash.physicalAttack, false);
		anim.SetBool(hash.specialAttack, false);
		
		selectedMove = null;
	}

	void SelectMove(int index)
	{
		selectedMove = new SelectedMove(moveSet[index]);

		if(selectedMove.info.targetType == TargetType.Self)
		{
			SetAttackState(new Target(gameObject, transform.position));
		}
	}
}
