using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour
{
	NetworkConnectionError connectionError = new NetworkConnectionError();
	private const string typeName = "MobamonDev";
	private const string gameName = "RoomName";
	private HostData[] hostList;

	private string serverIp = "127.0.0.1";

	void Start()
	{
		connectionError = Network.Connect(serverIp, 25000);

		//StartServer();
	}

	/*void InstantiateNPCs()
	{
		Component[] NPCList = GameObject.Find("Pokemon").GetComponentsInChildren(typeof(Collider));

		foreach(Component NPC in NPCList)
		{
			PokemonList.instance.Add(NPC.GetInstanceID(), NPC.gameObject);
		}
	}*/

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
		//MasterServer.RegisterHost(typeName, roomName);
		//InstantiateNPCs();
	}

	void OnServerInitialized()
	{
		Debug.Log("Server Initializied");
		//SpawnPlayer();
	}

	void OnGUI()
	{
		string message = "You are the server. \nYour IP is " + serverIp + ".";

		if(Network.isServer)
			GUI.Label(new Rect(100, 100, 250, 100), message);

		/*if(!Network.isClient && !Network.isServer)
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
		}*/
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
		//MasterServer.RequestHostList(typeName);
	}
	
	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		/*if(msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList();*/
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

	// The following method is called from the client.
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

		//StoreEntities();
		networkView.RPC("StoreNewEntity", RPCMode.OthersBuffered, player.networkView.viewID);
	}

	private void StoreEntities()
	{
		Transform pokemonObj = GameObject.Find("Pokemon").transform;
		NetworkView[] entityList = (NetworkView[])GameObject.FindObjectsOfType(typeof(NetworkView));

		foreach(NetworkView entity in entityList)
		{
			if(entity.gameObject.name != "NetworkController")
				entity.gameObject.transform.parent = pokemonObj;
		}
	}

	[RPC]
	private void StoreNewEntity(NetworkViewID viewID)
	{
		NetworkView newEntityView = NetworkView.Find(viewID);

		if(newEntityView != null)
		{
			newEntityView.gameObject.transform.parent = GameObject.Find("Pokemon").transform;
		}
	}
}
