using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.Database.Enums;

namespace Mobamon.Database
{
    public class SceneHelper : MonoBehaviour
    {
        private static Dictionary<Container, GameObject> _container = new Dictionary<Container, GameObject>();
        
        private void Start()
        {
            GetContainers();
        }

        private void Update()
        {
            if(_container.Count < 5)
                GetContainers();
        }

        private void GetContainers()
        {
            if(!_container.ContainsKey(Container.Entities))
            {
                GameObject temp = GameObject.Find("Entities");
                if(temp != null) 
                    _container.Add(Container.Entities, temp);
            }

            if(!_container.ContainsKey(Container.Pokemons))
            {
                GameObject temp = GameObject.Find("Pokemons");
                if(temp != null) 
                    _container.Add(Container.Pokemons, temp);
            }

            if(!_container.ContainsKey(Container.Towers))
            {
                GameObject temp = GameObject.Find("Towers");
                if(temp != null) 
                    _container.Add(Container.Towers, temp);
            }

            if(!_container.ContainsKey(Container.Wild))
            {
                GameObject temp = GameObject.Find("Wild");
                if(temp != null) 
                    _container.Add(Container.Wild, temp);
            }

            if(!_container.ContainsKey(Container.Robots))
            {
                GameObject temp = GameObject.Find("Robots");
                if(temp != null) 
                    _container.Add(Container.Robots, temp);
            }          
        }

        public static GameObject GetContainer(Container container)
        {
            return (_container.ContainsKey(container) ? _container[container] : null);
        }
    }
}