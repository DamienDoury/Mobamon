using UnityEngine;
using System.Collections;

namespace Mobamon.Networking
{
	public class NetworkManager : MonoBehaviour
	{
		private const string typeName = "MobamonDev";
		private const string gameName = "RoomName";
		private HostData[] hostList;

		private string serverIp = "127.0.0.1"; //82.127.144.96
		private int serverPort = 25000;

		void Start()
		{
			Network.Connect(serverIp, serverPort);
		}

		void OnFailedToConnect(NetworkConnectionError error) {
			if (error != NetworkConnectionError.NoError && !Network.isServer) {
				StartServer();
			}
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

			Network.InitializeServer(4, serverPort, true);//!Network.HavePublicAddress());
			//MasterServer.RegisterHost(typeName, roomName);
			//InstantiateNPCs();

			GameObject.Instantiate (Resources.Load ("Camera/ServerCamera"));
		}

		void OnServerInitialized()
		{
			Debug.Log("Server Initializied");
			//SpawnPlayer();
		}

		void OnGUI()
		{
			string message = "You are the server. \nYour IP is " + serverIp + ". \n" + Network.connections.Length + " players connected.";

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
			//SpawnPlayer();
		}

		void OnPlayerConnected(NetworkPlayer player)
		{
			if(Network.isServer)
			{
				networkView.RPC("SpawnPlayer", player, Network.connections.Length % 2, Network.connections.Length);
			}
		}

		// The following method is called from the client.
		[RPC]
		private void SpawnPlayer(int teamID, int pokemonID)
		{
			string pokemonName;

			GameObject player;
			switch(pokemonID % 3)
			{
				case 0:
					pokemonName = "Caninos";
					break;

				case 1:
					pokemonName = "Dimoret";
					break;

				default:
					pokemonName = "Drakkarmin";
					break;
			}

			Vector3 spawnPos = teamID % 2 == 1 ? GameInfo.blueTeamSpawn : GameInfo.redTeamSpawn;
			player = (GameObject)Network.Instantiate(Resources.Load ("Pokemon/" + pokemonName), spawnPos, Quaternion.identity, 0);
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
}