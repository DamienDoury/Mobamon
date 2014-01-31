using UnityEngine;
using System.Collections;

namespace Mobamon.UI
{
	public class ManageFullscreen : MonoBehaviour
	{
		void Start()
		{
			if(!Screen.fullScreen)
				Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
		}

		void Update()
		{
			if(Input.GetKeyDown(KeyCode.F11))
			{
				if(!Screen.fullScreen)
					Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
				else
					Screen.fullScreen = !Screen.fullScreen;
			}

			if(Input.GetKeyDown(KeyCode.Escape))
			{
				Screen.fullScreen = false;
			}
		}
	}
}