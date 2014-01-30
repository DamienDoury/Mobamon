using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{	
	private Transform cameraTarget;
	private float cameraAngle;

	public float cameraHeight = 10f;
	public float coeff = 20f;
	public float maxShifting = 25f;
	
	void Awake()
	{
		getCameraTarget();
	}
	
	void Update()
	{
		if(cameraTarget == null)
		{
			getCameraTarget();
			return;
		}

		float zoomFactor = 200f;
		if(Input.GetAxis("Mouse ScrollWheel") < 0) // Back
		{
			cameraHeight += Time.deltaTime * zoomFactor;
		}
		else if(Input.GetAxis("Mouse ScrollWheel") > 0) // Forward
		{
			cameraHeight -= Time.deltaTime * zoomFactor;
		}

		cameraHeight = Mathf.Max(Mathf.Min(cameraHeight, 25f), 3f);
		cameraAngle = -(coeff / cameraHeight - 10f);

		Vector3 targetPos = transform.position + new Vector3(0, -cameraHeight, cameraAngle);

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -maxShifting, maxShifting), cameraHeight, Mathf.Clamp(transform.position.z, -maxShifting, maxShifting * 0.75f));
		transform.LookAt(targetPos);

		bool cameraLocked = false;
		
		if(cameraTarget)
		{
			if(Input.GetKey(KeyCode.Space))
			{
				cameraLocked = true;
				transform.position = new Vector3(cameraTarget.position.x, transform.position.y, cameraTarget.position.z - cameraAngle);
			}
		}
		
		if(!cameraLocked)
		{
			Vector3 movementVector = new Vector3(0, 0, 0);
			float speedFactor = 50f;

			if(Input.mousePosition.x <= 0 || Input.GetKey(KeyCode.LeftArrow))
				movementVector += Vector3.left;
			
			if(Input.mousePosition.x >= Screen.width - 1 || Input.GetKey(KeyCode.RightArrow))
				movementVector += Vector3.right;
			
			if(Input.mousePosition.y <= 0 || Input.GetKey(KeyCode.DownArrow))
				movementVector += Vector3.back;
			
			if(Input.mousePosition.y >= Screen.height - 1 || Input.GetKey(KeyCode.UpArrow))
				movementVector += Vector3.forward;
			
			movementVector.Normalize();
			transform.position += movementVector * speedFactor * Time.deltaTime;
		}
	}

	void getCameraTarget()
	{
		GameObject obj = GameObject.FindGameObjectWithTag("CameraTarget");
		//GameObject obj = GameObject.Find("Pokemon").GetComponentInChildren(typeof(PokemonController)).gameObject;
		if(obj != null)
		{
			cameraTarget = obj.transform;
			MoveCameraStatic();
			//CenterCamera();
		}
	}

	void CenterCamera()
	{
		/*transform.position = cameraTarget.transform.position + Vector3.up * 5 - Vector3.back * 5;
		transform.LookAt(cameraTarget.position);*/
	}

	void MoveCameraStatic()
	{
		cameraHeight = Mathf.Max(Mathf.Min(cameraHeight, 25), 3);
		
		cameraAngle = -(coeff / cameraHeight - 10);
		
		Vector3 newPos = cameraTarget.position;
		newPos.y = cameraHeight;
		newPos.z = newPos.z - cameraAngle;
		
		transform.position = newPos;
		transform.LookAt(cameraTarget.position);
	}
}