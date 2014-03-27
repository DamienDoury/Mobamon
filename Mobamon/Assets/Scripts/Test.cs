using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
	void Awake ()
    {
        if(Application.isEditor)
            Application.LoadLevel("StartScene"); // This is meant to launch the first scene in the editor without having to switch it.

        Destroy(this);
	}
}
