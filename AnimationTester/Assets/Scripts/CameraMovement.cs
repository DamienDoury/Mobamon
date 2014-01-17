using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{	
	private Transform cameraTarget;
	private float cameraAngle;
	private Texture myTexture;

	public float cameraHeight = 10f;
	public float coeff = 20f;
	
	void Awake()
	{
		getCameraTarget();
		myTexture = (Texture)Resources.Load("GUI/gui_moves");
	}
	
	void Update()
	{
		if(cameraTarget == null)
		{
			getCameraTarget();
			return;
		}

		if(Input.GetAxis("Mouse ScrollWheel") < 0) // Back
		{
			cameraHeight++;
		}
		else if(Input.GetAxis("Mouse ScrollWheel") > 0) // Forward
		{
			cameraHeight--;
		}

		cameraHeight = Mathf.Max(Mathf.Min(cameraHeight, 25), 3);
		cameraAngle = -(coeff / cameraHeight - 10);

		Vector3 targetPos = transform.position + new Vector3(0, -cameraHeight, cameraAngle);

		transform.position = new Vector3(transform.position.x, cameraHeight, transform.position.z);
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

		//if(Screen.fullScreen)
		{
			if(!cameraLocked)
			{
				float speedFactor = 0.8f;
				if(Input.mousePosition.x <= 0)
					transform.position += Vector3.left * speedFactor;

				if(Input.mousePosition.x >= Screen.width - 1)
					transform.position += Vector3.right * speedFactor;

				if(Input.mousePosition.y <= 0)
					transform.position += Vector3.back * speedFactor;

				if(Input.mousePosition.y >= Screen.height - 1)
					transform.position += Vector3.forward * speedFactor;
			}
		}
	}

	void getCameraTarget()
	{
		GameObject obj = GameObject.FindGameObjectWithTag("CameraTarget");
		if(obj)
		{
			cameraTarget = obj.transform;
			MoveCameraStatic();
		}
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


	void OnGUI()
	{
		if(!myTexture)
		{
			Debug.LogError("Assign a Texture in the inspector.");
			return;
		}

		Rect myRect = new Rect(Screen.width / 2 - myTexture.width / 2, Screen.height - myTexture.height, myTexture.width, myTexture.height);
		GUI.DrawTexture(myRect, myTexture);
	}
}