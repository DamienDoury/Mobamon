using UnityEngine;
using System.Collections;

public class PokemonMovement : MonoBehaviour {

	private Animator anim;
	private HashIDs hash;
	private float baseWalkSpeed;

	public float turnSmoothing = 15f;   // A smoothing value for turning the player.
	public float speedDampTime = 0.1f;  // The damping for the speed parameter
	public float walkSpeed = 4f;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
		hash = GameObject.FindGameObjectWithTag(Tags.GameController).GetComponent<HashIDs>();
		baseWalkSpeed = walkSpeed;

		anim.SetLayerWeight(0, 1f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		MovementManagement(h, v);
	}

	void Update()
	{
		if(anim.GetBool(hash.specialAttack))
		{
			anim.SetBool(hash.specialAttack, false);
		}

		if(Input.GetMouseButtonDown(0))
		{
			anim.SetBool(hash.specialAttack, true);
		}

		if(anim.GetCurrentAnimatorStateInfo(0).IsName("SpecialAttack"))
		{
			//isStopped = true;
			walkSpeed = 0f;
		}
		else
		{
			//isStopped = false;
			walkSpeed = baseWalkSpeed;
		}
	}
	
	void MovementManagement(float horizontal, float vertical) {

		float actualSpeed = anim.GetFloat(hash.speed);
		float maxSpeed = walkSpeed;
		float newSpeed = Vector3.Magnitude(new Vector3(horizontal * maxSpeed, 0f, vertical * maxSpeed));
		//float resultSpeed = isStopped ? 0f : Mathf.Lerp(actualSpeed, newSpeed, Time.deltaTime);
		float resultSpeed = Mathf.Lerp(actualSpeed, newSpeed, Time.deltaTime);
		
		Vector3 movement = transform.forward * resultSpeed * Time.deltaTime;
		Vector3 newPosition = transform.position + movement;
		
		rigidbody.MovePosition(newPosition);
		anim.SetFloat(hash.speed, newSpeed, speedDampTime, Time.deltaTime);
		
		if (horizontal != 0f || vertical != 0f) {			
			Rotating(horizontal, vertical);
		}
	}
	
	void Rotating (float horizontal, float vertical)
	{
		// Create a new vector of the horizontal and vertical inputs.
		Vector3 targetDirection = new Vector3(horizontal, 0f, vertical);
		
		// Create a rotation based on this new vector assuming that up is the global y axis.
		Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
		
		// Create a rotation that is an increment closer to the target rotation from the player's rotation.
		Quaternion newRotation = Quaternion.Lerp(rigidbody.rotation, targetRotation, turnSmoothing * Time.deltaTime);
		
		// Change the players rotation to this new rotation.
		rigidbody.MoveRotation(newRotation);
	}
}
