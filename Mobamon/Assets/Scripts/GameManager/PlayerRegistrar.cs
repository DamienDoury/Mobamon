﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Mobamon.GameManager
{
    public class PlayerRegistrar
    {
        private static PlayerRegistrar instance;
        public static PlayerRegistrar Instance 
        { 
            get 
            { 
                return (instance == null ? instance = new PlayerRegistrar() : instance); 
            }
        }

        /// <summary>
        /// The key represents the NetworkViewID and the value is the GameObject reference on this instance of the game.
        /// </summary>
        private Dictionary<NetworkViewID, GameObject> list = new Dictionary<NetworkViewID, GameObject>();
        public Dictionary<NetworkViewID, GameObject> List
        { 
            get 
            {
                return list;
            } 
        }
    }
}