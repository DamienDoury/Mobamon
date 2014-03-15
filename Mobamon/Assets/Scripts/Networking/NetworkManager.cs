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

		private int PROD_PORT = 25001;
		private int DEV_PORT = 25000;
		private string SERVER_IP = "82.127.144.96";

		private string serverIp = "127.0.0.1"; //82.127.144.96
		private int serverPort = 25000;

		private bool noConnection = false;
		private bool notConnected = false;
		private string connectionErrorMessage = "";

		private GameObject pkmn;
		private float positionUpdateFrequency = 0.1f;
		private float nextPositionUpdate = 0f;

		void Start()
		{
			pkmn = GameObject.Find("Pokemon");

			if(Application.platform == RuntimePlatform.LinuxPlayer) // If this is Lucas' server, then we launch the server. Otherwise, we launch a client (that may become a server later).
				StartServer();
			else
				JoinServer();
		}

		void Update()
		{
			SynchroniseEntitiesPosition();
		}

		private void SynchroniseEntitiesPosition()
		{
			if(Network.isServer)
			{
				if(nextPositionUpdate <= 0f)
				{
					nextPositionUpdate += positionUpdateFrequency;
					
					Component[] componentList = pkmn.GetComponentsInChildren(typeof(PokemonController));
					foreach(Component comp in componentList)
					{
						PokemonController cont = (PokemonController)comp; 
						if(cont.transform.parent.gameObject != pkmn)
							continue;
						
						cont.networkView.RPC("WarpEntity", RPCMode.Others, cont.networkView.viewID, cont.transform.position, cont.nav.speed, cont.transform.rotation, cont.nav.destination);
					}
				}
				else
				{
					nextPositionUpdate -= Time.deltaTime;
				}
			}
		}

		void OnFailedToConnect(NetworkConnectionError error)
		{
			if(Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
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
					else if(error == NetworkConnectionError.ConnectionFailed && Application.isWebPlayer)
						connectionErrorMessage = "Apparently, our server is down. Please come back later.";
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
			if(!Network.isServer)
			{
				// Automatically sets the right port if running on Lucas' server.
				if(Application.platform == RuntimePlatform.LinuxPlayer)
				{
					if(Application.dataPath.Contains("srv/mobamon/bin"))
						Network.InitializeServer(12, PROD_PORT, true);
					else
						Network.InitializeServer(12, DEV_PORT, true);
				}
				else
				{
					Network.InitializeServer(12, serverPort, true);//!Network.HavePublicAddress());
				}

				GameObject.Instantiate(Resources.Load("Camera/ServerCamera"));
			}
		}

		void JoinServer()
		{
			if(Application.isWebPlayer && Application.absoluteURL.Contains("encyclopedex.com"))
			{
				if(Application.absoluteURL.Contains("/mobamon/"))
					Network.Connect(SERVER_IP, PROD_PORT);
				else
					Network.Connect(SERVER_IP, DEV_PORT);
			}
			else
			{
				Network.Connect(serverIp, serverPort);
			}
		}

		void OnServerInitialized()
		{
			Debug.Log("Server Initializied");
		}

		void OnGUI()
		{
			if(noConnection)
			{
				int boxWidth = 250;
				int boxHeight = 100;
				GUI.Label(new Rect((Screen.width - boxWidth) / 2, (Screen.height - boxHeight) / 2, boxWidth, boxHeight), "No internet connection.");
			}
			else
			{
				if(Network.isServer)
				{
					GUI.Label(new Rect(100, 100, 250, 100), "You are the server. \nYour IP is " + Network.player.externalIP + " \n" + Network.connections.Length + " players connected.");
				}

				if(notConnected)
				{
					int boxWidth = 250;
					int boxHeight = 100;

					GUI.Label(new Rect((Screen.width - boxWidth) / 2, (Screen.height - boxHeight) / 2, boxWidth, boxHeight), connectionErrorMessage);
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
		
		void OnConnectedToServer()
		{
			Debug.Log("Server Joined");
		}

		void OnPlayerConnected(NetworkPlayer player)
		{
			if(Network.isServer)
			{
				networkView.RPC("SpawnPlayer", player, (Network.connections.Length - 1) % 2 + 1, Network.connections.Length);
			}
		}

		// The following method is called from the client.
		[RPC]
		private void SpawnPlayer(int teamID, int pokemonID) // "teamID" is either 1 or 2.
		{
			string pokemonName;

			GameObject player;
			switch(pokemonID % 6)
			{
				case 0:
                    pokemonName = "090 - Shellder";
					break;

				case 1:
                    pokemonName = "232 - Donphan";
					break;

				case 2:
                    pokemonName = "185 - Sudowoodo";
					break;

				case 3:
                    pokemonName = "438 - Bonsly";
                    break;

				case 4:
                    pokemonName = "133 - Eevee";
					break;
				
				default:
					pokemonName = "621 - Druddigon";
					break;
			}

			Vector3 spawnPos = teamID % 2 == 1 ? GameInfo.blueTeamSpawn : GameInfo.redTeamSpawn;
			player = (GameObject)Network.Instantiate(Resources.Load ("Pokemons/" + pokemonName), spawnPos, Quaternion.identity, 0);
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