using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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