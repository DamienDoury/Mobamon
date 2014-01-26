using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour
{
	private const string typeName = "MobamonDev";
	private const string gameName = "RoomName";
	private HostData[] hostList;

	void Start()
	{
		Component[] NPCList = GameObject.Find("Pokemon").GetComponentsInChildren(typeof(Collider));

		foreach(Component NPC in NPCList)
		{
			GameObject obj = NPC.gameObject;
			PokemonList.instance.Add(obj.GetInstanceID(), obj); // This won't store the new coming players.
		}
	}

	void StartServer()
	{
		string roomName = "";
		//string roomName = "Someone";
		//string roomName = System.Environment.MachineName;
		string machineName = SystemInfo.deviceName;
		if(machineName != "")
		{
			if(roomName == "")
				roomName = "Unnamed room";
			else
				roomName += "'s room";
		}
		else
		{
			roomName = "Unknown room";
		}

		Network.InitializeServer(4, 25000, true);//!Network.HavePublicAddress());
		MasterServer.RegisterHost(typeName, roomName);
	}

	void OnServerInitialized()
	{
		Debug.Log("Server Initializied");
		SpawnPlayer();
	}

	void OnGUI()
	{
		if(!Network.isClient && !Network.isServer)
		{
			if(GUI.Button(new Rect(100, 100, 250, 100), "Start Server"))
				StartServer();

			if (GUI.Button(new Rect(100, 250, 250, 100), "Refresh Hosts"))
				RefreshHostList();
			
			if (hostList != null)
			{
				for (int i = 0; i < hostList.Length; i++)
				{
					if (GUI.Button(new Rect(400, 100 + (110 * i), 300, 100), hostList[i].gameName + "\n" + hostList[i].connectedPlayers + " player" + (hostList[i].connectedPlayers > 1 ? "s" : "") + "\n" + hostList[i].ip[0]))
						JoinServer(hostList[i]);
				}
			}
		}
	}

	void OnPlayerDisconnected(NetworkPlayer player)
	{
		if(Network.isServer)
		{
			Debug.Log("Clean up after player " + player);
			Network.RemoveRPCs(player);
			Network.DestroyPlayerObjects(player);
		}
	}
	
	private void RefreshHostList()
	{
		MasterServer.RequestHostList(typeName);
	}
	
	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if(msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList();
	}

	private void JoinServer(HostData hostData)
	{
		Network.Connect(hostData);
	}
	
	void OnConnectedToServer()
	{
		Debug.Log("Server Joined");
		SpawnPlayer();
	}

	private void SpawnPlayer()
	{
		string pokemonName;

		GameObject player;
		switch(Network.connections.Length % 3)
		{
			case 0:
				pokemonName = "Dimoret";
				break;

			case 1:
				pokemonName = "Caninos";
				break;

			default:
				pokemonName = "Drakkarmin";
				break;
		}

		player = (GameObject)Network.Instantiate(Resources.Load ("Pokemon/" + pokemonName), new Vector3(5f, 0f, -10f), Quaternion.identity, 0);
		player.transform.parent = GameObject.Find("Pokemon").transform;
		player.tag = "CameraTarget";

		PokemonList.instance.Add(player.GetInstanceID(), player);
	}
}
