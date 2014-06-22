using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using Mobamon.GameManager;
using Mobamon.Pokemon;
using Mobamon.Pokemon.Player;
using Mobamon.Database;
using Mobamon.Database.Enums;

namespace Mobamon.GameManager
{
    /*
     * This class manages the death of the entities.
     * It distributes money, experience and make entities respawn if required.
     * 
     * Only one single instance of this must exist on a scene.
     * This is running on the server only.
     */

    public class TheReaper : MonoBehaviour
    {
        public static TheReaper instance { get; private set; }
        private Dictionary<NetworkViewID, float> respawnQueue = new Dictionary<NetworkViewID, float>();

    	protected void Start ()
        {
            instance = this;
    	}

    	protected void Update ()
        {
            if(Network.isServer)
            {
                foreach (var truc in respawnQueue.ToDictionary(k => k.Key, v => v.Value))
                {
                    NetworkViewID viewID = truc.Key;
                    float remainingTime = truc.Value - Time.deltaTime;
                    respawnQueue[viewID] = remainingTime;

                    if(remainingTime <= 0f)
                    {
                        networkView.RPC("Respawn", RPCMode.AllBuffered, viewID);
                        respawnQueue.Remove(viewID);
                    }
                }
            }
    	}

        /// <summary>
        /// The Reaper is told that an entity just died.
        /// It then kill the entity, gives gold/experience and prepares the entity respawn.
        /// We should also get the list of the entities that killed this one.
        /// </summary>
        /// <param name="em">EntityManager.</param>
        public void NoticeDeath(EntityManager em)
        {
            if(Network.isServer)
            {
                GameObject container = em.transform.parent.gameObject;
                MatchManager matchManager = GetComponent<MatchManager>();

                if (matchManager != null)
                {
                    matchManager.AddKill(em.team);
                }

                networkView.RPC("Kill", RPCMode.AllBuffered, em.networkView.viewID);

                if(container == SceneHelper.GetContainer(Container.Pokemons))
                {
                    respawnQueue.Add(em.networkView.viewID, 3f);
                }
                else if(container == SceneHelper.GetContainer(Container.Wild))
                {
                    //respawnQueue.Add(viewID, 1.5f);
                }
            }
        }

        [RPC]
        private void Kill(NetworkViewID viewID)
        {
            GameObject obj = NetworkView.Find(viewID).gameObject;
            GameObject container = obj.transform.parent.gameObject;

            if(container == SceneHelper.GetContainer(Container.Pokemons)
               || container == SceneHelper.GetContainer(Container.Wild))
            {
                obj.SetActive(false);
            }
            else
            {
                //obj.SetActive(false);
                Destroy(obj); // A robot or a wild monster should be dead for good and not respawn; a new instance should be made instead.
            }
        }          

        [RPC]
        private void Respawn(NetworkViewID viewID)
        {
            GameObject obj = PlayerRegistrar.Instance.List[viewID].GameObject;
            GameObject container = obj.transform.parent.gameObject;
            EntityManager em = obj.GetComponent<EntityManager>();

            if(container == SceneHelper.GetContainer(Container.Pokemons))
            {
                // Once the entity is ready, we make it appear.
                obj.SetActive(true);

                PokemonController controller = obj.GetComponent<PokemonController>();

                if(em == null)
                    Destroy(SceneHelper.GetContainer(Container.Wild));

                // Visual setters
                obj.transform.position = em.team % 2 == 0 ? GameInfo.redTeamSpawn : GameInfo.blueTeamSpawn;
                obj.transform.rotation = Quaternion.identity;
                controller.nav.ResetPath();
                controller.ResetMovingRestrictions();
                
                // Logical setters
                controller.selectedMove = null;
				em.Respawn();
            }
            else if(container == SceneHelper.GetContainer(Container.Wild))
            {
                obj.SetActive(true);
                em.currentHP = em.maxHP;
            }
        }
    }
}