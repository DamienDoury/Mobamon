using UnityEngine;
using System.Collections;

namespace Mobamon.UI
{
	public class CameraMovement : MonoBehaviour
	{	
		private Transform cameraTarget;
		private float cameraAngle;

		private float cameraHeight = 10f;
		private float coeff = 8f;
		private float maxShifting = 100f;
		private float zoomSpeed = 800f;

		private Vector3 targetPos;
		
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

			// 1) We compute the zoom.
			float zoomDirection = 0f;
			if(Input.GetAxis("Mouse ScrollWheel") < 0f) // Backward scrolling
				zoomDirection = Input.GetAxis("Mouse ScrollWheel");
			else if(Input.GetAxis("Mouse ScrollWheel") > 0f) // Forward scrolling
				zoomDirection = Input.GetAxis("Mouse ScrollWheel");
			
			cameraHeight = Mathf.Clamp(cameraHeight - zoomDirection * zoomSpeed * Time.deltaTime, 3f, 25f);
			cameraAngle = -(coeff / cameraHeight - 10f);

			// 2) We find the camera's target.
			if(Input.GetKey(KeyCode.Space))
			{
				targetPos = new Vector3(cameraTarget.position.x, 0, cameraTarget.position.z);
			}
			else
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
				targetPos += movementVector * speedFactor * Time.deltaTime;

				// We forbid the camera's target to move out of the map.
				targetPos = new Vector3(Mathf.Clamp(targetPos.x, 0, maxShifting), 0, Mathf.Clamp(targetPos.z, 0, maxShifting * 0.5f));
			}

			// 3) We finally set the camera's position and we make it look at its target.
			transform.position = new Vector3(targetPos.x, cameraHeight, targetPos.z - cameraAngle);
			transform.LookAt(targetPos);
		}

		void getCameraTarget()
		{
			GameObject obj = GameObject.FindGameObjectWithTag("CameraTarget");
			if(obj != null)
			{
				cameraTarget = obj.transform;
				targetPos = new Vector3(cameraTarget.position.x, 0, cameraTarget.position.z);
			}
		}
	}
}