using UnityEngine;
using System.Collections;
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

    	protected void Start ()
        {
            instance = this;
    	}

    	protected void Update ()
        {

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
                    MakeRespawn(em, 3f);
                }
                else if(container == SceneHelper.GetContainer(Container.Wild))
                {
                    MakeRespawn(em, 1.5f);
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
                Destroy(obj);
            }
        }

        private void MakeRespawn(EntityManager em, float delay) //IEnumerator
        {
            if(Network.isServer)
            {
                //delay;

                GameObject container = em.transform.parent.gameObject;
                
                if(container == SceneHelper.GetContainer(Container.Pokemons)
                   || container == SceneHelper.GetContainer(Container.Wild))
                {
                    networkView.RPC("Respawn", RPCMode.AllBuffered, em.networkView.viewID);
                }
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
                PokemonController controller = obj.GetComponent<PokemonController>();

                if(em == null)
                    Destroy(SceneHelper.GetContainer(Container.Wild));

                // Visual setters
                obj.transform.position = em.team % 2 == 0 ? GameInfo.redTeamSpawn : GameInfo.blueTeamSpawn;
                obj.transform.rotation = Quaternion.identity;
                controller.nav.ResetPath();
                controller.ResetMovingRestrictions();
                
                // Logical setters
                em.currentHP = em.maxHP;
                /*controller.selectedMove = null;
                em.ResetBlinking();*/

                // Once the entity is ready, we make it appear.
                obj.SetActive(true);
            }
            else if(container == SceneHelper.GetContainer(Container.Wild))
            {
                em.currentHP = em.maxHP;
                obj.SetActive(true);
            }
        }
    }
}