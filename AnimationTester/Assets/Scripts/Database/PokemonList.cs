using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.Database.Classes;
using Mobamon.Pokemon.Player;

namespace Mobamon.Database
{
	public static class PokemonList
	{
		public static Dictionary<NetworkViewID, GameObject> instance = new Dictionary<NetworkViewID, GameObject>();

		[RPC]
		public static void AddPokemonInstance(NetworkViewID viewID, GameObject obj)
		{
			if(obj.GetComponent(typeof(PokemonController)) != null)
				obj.transform.parent = GameObject.Find("Pokemon").transform;

			instance.Add(viewID, obj);
		}

		[RPC]
		public static void RemovePokemonInstance(NetworkViewID viewID)
		{
			instance.Remove(viewID);
		}
	}
} 