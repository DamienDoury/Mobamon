using UnityEngine;
using System.Collections;
using Mobamon.Pokemon.Player;

namespace Mobamon.Networking
{
	public class NetworkManager : MonoBehaviour
	{
		private const string typeName = "MobamonDev";
		private const string gameName = "RoomName";
		private HostData[] hostList;

		private string serverIp = "82.127.144.96"; //82.127.144.96
		private int serverPort = 25001;

		void Start()
		{
			Network.Connect(serverIp, serverPort);
		}

		void OnFailedToConnect(NetworkConnectionError error)
		{
			if(error != NetworkConnectionError.NoError && !Network.isServer)
			{
				StartServer();
			}
		}

		void StartServer()
		{
			Network.InitializeServer(4, serverPort, true);//!Network.HavePublicAddress());
			GameObject.Instantiate(Resources.Load ("Camera/ServerCamera"));
		}

		void OnServerInitialized()
		{
			Debug.Log("Server Initializied");
		}

		void OnGUI()
		{
			string message = "You are the server. \nYour IP is " + serverIp + ". \n" + Network.connections.Length + " players connected.";

			if(Network.isServer)
				GUI.Label(new Rect(100, 100, 250, 100), message);
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
		
		void OnConnectedToServer()
		{
			Debug.Log("Server Joined");
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
			PokemonController controller = (PokemonController)player.gameObject.GetComponent("PokemonController");
			controller.team = teamID;

			networkView.RPC("StoreNewEntity", RPCMode.OthersBuffered, player.networkView.viewID, teamID);
		}

		[RPC]
		private void StoreNewEntity(NetworkViewID viewID, int teamID)
		{
			NetworkView newEntityView = NetworkView.Find(viewID);

			if(newEntityView != null)
			{
				newEntityView.gameObject.transform.parent = GameObject.Find("Pokemon").transform;
				PokemonController controller = (PokemonController)newEntityView.gameObject.gameObject.GetComponent("PokemonController");
				controller.team = teamID;
			}
		}
	}
}