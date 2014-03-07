using UnityEngine;
using System.Collections;
using System;

public class ScreenshotManager : MonoBehaviour
{
	private string screenshotsFolder = "Screenshots";
	
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.F12) && !Application.isWebPlayer)
		{
			if(!System.IO.Directory.Exists(screenshotsFolder))
			   System.IO.Directory.CreateDirectory(screenshotsFolder);

			DateTime now = DateTime.Now;
			Application.CaptureScreenshot("../" + screenshotsFolder + "/" + now.ToString("yyyy-MM-dd HH-mm-ss-ff") + ".png");
		}
	}
}
