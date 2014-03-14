using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mobamon.UI
{
	public class ManageFullscreen : MonoBehaviour
	{
        private int defaultWindowedWidth = 1280;
        private int defaultWindowedHeight = 720;

        private int windowedWidth = -1;
        private int windowedHeight = -1;

		void Start()
		{

		}

		void Update()
		{
			if(Input.GetKeyDown(KeyCode.F11))
			{
                SetFullscreen(!Screen.fullScreen);
            }
		}

        void OnApplicationFocus(bool focusStatus)
        {
            if(!focusStatus)
            {
                SetFullscreen(false);
            }
        }

        void SetFullscreen(bool on)
        {
            if(on && !Screen.fullScreen)
            {
                windowedWidth = Screen.width;
                windowedHeight = Screen.height;

                List<Resolution> resList = Screen.resolutions.ToList();

                Screen.SetResolution(resList.Last().width , resList.Last().height, true);
            }
            else if(!on && Screen.fullScreen)
            {
                if(windowedWidth == -1)
                {
                    windowedWidth = defaultWindowedWidth;
                    windowedHeight = defaultWindowedHeight;
                }
                
                Screen.SetResolution(windowedWidth, windowedHeight, false);
            }
        }
	}
}