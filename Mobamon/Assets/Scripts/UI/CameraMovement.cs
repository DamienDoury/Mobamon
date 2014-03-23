using UnityEngine;
using System.Collections;

namespace Mobamon.UI
{
	public class CameraMovement : MonoBehaviour
	{	
        public float minZoomHeight = 3f;
        public float maxZoomHeight = 50f;

		private Transform cameraTarget;
        private Transform pivot;
        private Transform offset;
        private Transform focus;
        private Transform bumper;
		private float cameraAngle;

		private float cameraHeight = 10f;
		private float coeff = 8f;
		private float maxShifting = 100f;
		private float zoomSpeed = 800f;

        private Quaternion currentPOV;
        private Quaternion desiredPOV;

        /// <summary>
        /// This is not an actual delay in seconds.
        /// </summary>
        private float rotationDelay = 0.1f;

        private bool isCameraLocked = false;

		private Vector3 targetPos;
		
        private void Start()
		{
			getCameraTarget();

            Transform[] childList = gameObject.GetComponentsInChildren<Transform>();
            foreach(Transform child in childList)
            {
                if(child.name == "CameraPOV")
                    pivot = child;
                else if(child.name == "CameraOffset")
                    offset = child;
                else if(child.name == "CameraFocus")
                    focus = child;
                else if(child.name == "CameraBumper")
                    bumper = child;

            }

            desiredPOV = Quaternion.LookRotation(Vector3.forward + Vector3.right, Vector3.up);
            currentPOV = desiredPOV;
            pivot.localRotation = currentPOV;
		}
		
        private void Update()
		{
			if(cameraTarget == null)
			{
				getCameraTarget();
				return;
			}

            GetCameraCommands();
            POVManagement();

			// 1) We compute the zoom.
			float zoomDirection = 0f;
			if(Input.GetAxis("Mouse ScrollWheel") != 0f)
			{
				zoomDirection += Input.GetAxis("Mouse ScrollWheel");
			}
			else
			{
				if(Input.GetKey(KeyCode.KeypadMinus))
					zoomDirection -= 0.04f;
				else if(Input.GetKey(KeyCode.KeypadPlus))
					zoomDirection += 0.04f;
			}
			
			cameraHeight = Mathf.Clamp(cameraHeight - zoomDirection * zoomSpeed * Time.deltaTime, minZoomHeight, maxZoomHeight);
			cameraAngle = -(coeff / cameraHeight - 10f);

			// 2) We find the camera's target.
            if(Input.GetKey(KeyCode.Space) || isCameraLocked)
			{
				targetPos = new Vector3(cameraTarget.position.x, 0, cameraTarget.position.z);
			}
			else
			{
				Vector3 movementVector = new Vector3(0, 0, 0);
				float speedFactor = 50f;
				
				if(Input.mousePosition.x <= 0 || Input.GetKey(KeyCode.LeftArrow))
                    movementVector += -pivot.right;
				
				if(Input.mousePosition.x >= Screen.width - 1 || Input.GetKey(KeyCode.RightArrow))
                    movementVector += pivot.right;
				
				if(Input.mousePosition.y <= 0 || Input.GetKey(KeyCode.DownArrow))
                    movementVector += -pivot.forward;
				
				if(Input.mousePosition.y >= Screen.height - 1 || Input.GetKey(KeyCode.UpArrow))
                    movementVector += pivot.forward;
				
				movementVector.Normalize();
				targetPos += movementVector * speedFactor * Time.deltaTime;

				// We forbid the camera's target to move out of the map.
				targetPos = new Vector3(Mathf.Clamp(targetPos.x, 0, maxShifting), 0, Mathf.Clamp(targetPos.z, 0, maxShifting * 0.5f));
			}

			// 3) We finally set the camera's position and we make it look at its target.
			gameObject.transform.position = new Vector3(targetPos.x, 0f, targetPos.z);
            focus.localPosition = new Vector3(0f, cameraHeight, -cameraAngle);
            bumper.LookAt(targetPos);
   		}

        private void GetCameraCommands()
        {
            // Here we catch the camera's command keys.
            if(Input.GetKeyDown(KeyCode.Keypad1))
            {
                desiredPOV = Quaternion.LookRotation(Vector3.forward + Vector3.right, Vector3.up);
            }
            else if(Input.GetKeyDown(KeyCode.Keypad3))
            {
                desiredPOV = Quaternion.LookRotation(Vector3.forward, Vector3.up);
            }
            else if(Input.GetKeyDown(KeyCode.Keypad9))
            {
                desiredPOV = Quaternion.LookRotation(Vector3.back + Vector3.left, Vector3.up);
            }
            else if(Input.GetKeyDown(KeyCode.Keypad5))
            {
                isCameraLocked = !isCameraLocked;
            }

        }

        /// <summary>
        /// This methods compute the rotation of the camera.
        /// Is called once per frame.
        /// </summary>
        private void POVManagement()
        {
            // Here we compute the rotation
            if(Quaternion.Angle(currentPOV, desiredPOV) > 0.5f)
            {
                currentPOV = Quaternion.Lerp(currentPOV, desiredPOV, Time.deltaTime / rotationDelay);
                pivot.localRotation = currentPOV;
            }
        }

        private void getCameraTarget()
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