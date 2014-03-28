using UnityEngine;
using System.Collections;
using Mobamon.Pokemon;
using Mobamon.Database;
using Mobamon.Database.Enums;

public class FOWManager : MonoBehaviour
{
    private float lastCall = 0f;
    private float period = 0.2f;

	// Use this for initialization
	void Start()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        lastCall -= Time.deltaTime;

        if(lastCall <= 0f)
        {
            lastCall = period;
            ShareFogVision();
        }
	}

    private void ShareFogVision()
    {
        GameObject obj = GameObject.FindWithTag("CameraTarget");
        
        if(obj == null)
        {
            Debug.LogError("Error: Pokemon not registered.");
        }
        else
        {
            int myTeam = obj.GetComponent<EntityManager>().team;
            
            foreach(EntityManager em in SceneHelper.GetContainer(Container.Entities).GetComponentsInChildren<EntityManager>())
            {
                if(em.team == myTeam)
                {
                    if(obj.GetComponent<FOWRevealer>() == null)
                    {
                        FOWRevealer fow = obj.AddComponent<FOWRevealer>();
                        fow.range = new Vector2(0.5f, 20f);
                        fow.lineOfSightCheck = FOWSystem.LOSChecks.EveryUpdate;
                    }
                }
                else
                {
                    if(obj.GetComponent<FOWRenderers>() == null)
                    {
                        obj.AddComponent<FOWRenderers>();
                    }
                }
            }
        }
    }
}
