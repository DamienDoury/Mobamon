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

		private string serverIp = "127.0.0.1"; //82.127.144.96
		private int serverPort = 25000;

		private bool notConnected = false;
		private string connectionErrorMessage = "";

		void Start()
		{
			if(Application.platform == RuntimePlatform.LinuxPlayer) // If this is Lucas' server, then we launch the server. Otherwise, we launch a client.
				StartServer();
			else
				Network.Connect(serverIp, serverPort);
		}

		void OnFailedToConnect(NetworkConnectionError error)
		{
			if(Application.platform == RuntimePlatform.WindowsPlayer)
			{
				StartServer();
			}
			else
			{
				notConnected = true;

				if(error != NetworkConnectionError.NoError && !Network.isServer)
				{
					if(error == NetworkConnectionError.TooManyConnectedPlayers)
						connectionErrorMessage = "Too many players connected on our server. Please try again later.";
					else if(error == NetworkConnectionError.ConnectionFailed)
						connectionErrorMessage = "Connection failed. Please check your internet connection. Our server might also be down.";
				}
				else
				{
					connectionErrorMessage = "Unknown connection error...";
				}

				OnGUI();
			}
		}

		void StartServer()
		{
			Network.InitializeServer(12, serverPort, true);//!Network.HavePublicAddress());
			GameObject.Instantiate(Resources.Load ("Camera/ServerCamera"));
		}

		void OnServerInitialized()
		{
			Debug.Log("Server Initializied");
		}

		void OnGUI()
		{
			if(Network.isServer)
			{
				GUI.Label(new Rect(100, 100, 250, 100), "You are the server. \nYour IP is " + serverIp + ". \n" + Network.connections.Length + " players connected.");
			}

			if(notConnected)
			{
				int boxWidth = 250;
				int boxHeight = 100;

				GUI.Label(new Rect((Screen.width - boxWidth) / 2, (Screen.height - boxHeight) / 2, boxWidth, boxHeight), connectionErrorMessage);
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
		
		void OnConnectedToServer()
		{
			Debug.Log("Server Joined");
		}

		void OnPlayerConnected(NetworkPlayer player)
		{
			if(Network.isServer)
			{
				networkView.RPC("SpawnPlayer", player, Network.connections.Length % 2 + 1, Network.connections.Length);
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