using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mobamon.Pokemon;
using Mobamon.Pokemon.Player;
using System;
using Mobamon.GameManager;
using Mobamon.Database;
using Mobamon.Database.Enums;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Mobamon.Networking
{
	public class NetworkManager : MonoBehaviour
	{
        public static int ChosenPokemonId = -1;
		public static bool IsServer = false;

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

        private Dictionary<string, GameObject> playerPokemons = new Dictionary<string, GameObject>();

		void Start()
		{
			pkmn = SceneHelper.GetContainer(Container.Pokemons);

			if(IsServer || Application.platform == RuntimePlatform.LinuxPlayer) // If this is Lucas' server, then we launch the server. Otherwise, we launch a client (that may become a server later).
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
						
						cont.GetComponent<NetworkView>().RPC("WarpEntity", RPCMode.OthersBuffered, cont.GetComponent<NetworkView>().viewID, cont.transform.position, cont.nav.speed, cont.transform.rotation, cont.nav.destination);
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
			if (error != NetworkConnectionError.NoError)
			{
				if (!Network.isServer) 
                {
                    notConnected = true;
					if (error == NetworkConnectionError.TooManyConnectedPlayers)
						connectionErrorMessage = "Too many players connected on our server. Please try again later.";
					else if (error == NetworkConnectionError.ConnectionFailed && Application.isWebPlayer)
						connectionErrorMessage = "Apparently, our server is down. Please come back later.";
					else if (error == NetworkConnectionError.ConnectionFailed)
                        connectionErrorMessage = "Connection failed. Please check your internet connection. Our server might also be down.";
                    
                    OnGUI ();
				} 
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
                    string ip = null;
                    int port = -1;
                    string errorMessage = null;
                    
                    if (this.ReadConfiguration(out ip, out port, out errorMessage))
                    {
                        Network.InitializeServer(6, port, true);//!Network.HavePublicAddress());
                    }
                    else
                    {
                        Debug.LogError(errorMessage);
                        connectionErrorMessage = errorMessage;
                    }
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
                string ip = null;
                int port = -1;
                string errorMessage = null;
               
                if (this.ReadConfiguration(out ip, out port, out errorMessage))
                {
                    Network.Connect(ip, port);
                }
                else
                {
                    Debug.LogError(errorMessage);
                    connectionErrorMessage = errorMessage;
                }

				OnGUI();
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
                NetworkViewID viewID = playerPokemons[player.guid].GetComponent<NetworkView>().viewID;

				Debug.Log("Clean up after player " + player);
				Network.RemoveRPCs(player);
                Network.RemoveRPCs(viewID);
                Network.Destroy(viewID);
				//Network.DestroyPlayerObjects(player);

                playerPokemons.Remove(player.guid);
                GetComponent<NetworkView>().RPC("RemovePlayerData", RPCMode.AllBuffered, viewID);
			}
		}

        void RemovePlayerData(NetworkViewID viewID)
        {
            PlayerRegistrar.Instance.List.Remove(viewID);
        }
		
		void OnConnectedToServer()
		{
			Debug.Log("Server Joined");
            if (!Network.isServer)
            {
                // When the server has accepted the connection, sends the selected pokemon
                GetComponent<NetworkView>().RPC("ChoosePokemon", RPCMode.Server, Network.player.guid, (ChosenPokemonId == -1 ? 58 : ChosenPokemonId));
            }
		}

        [RPC]
        private void ChoosePokemon(string playerGuid, int pokemonId)
        {
            int teamId = (Network.connections.Length - 1) % 2 + 1;

            // Spawns the pokemon
            string pokemonResourceName = Pokedex.pokemons[pokemonId].ResourceName;
            
            Vector3 spawnPos = teamId % 2 == 1 ? GameInfo.blueTeamSpawn : GameInfo.redTeamSpawn;
            GameObject instantiatedPokemon = (GameObject)Network.Instantiate(Resources.Load ("Pokemons/" + pokemonResourceName), spawnPos, Quaternion.identity, 0);
            playerPokemons.Add(playerGuid, instantiatedPokemon);

            // Sets the team id and the ownership
            GetComponent<NetworkView>().RPC("SetPokemonControllerValues", RPCMode.AllBuffered, playerGuid, instantiatedPokemon.GetComponent<NetworkView>().viewID, teamId);
        }

        [RPC]
        private void SetPokemonControllerValues(string playerGuid, NetworkViewID viewId, int teamId)
        {
            // When a client sends its chosen pokemon id, asks every one to spawn the chosen pokemon
            bool isMine = Network.player.guid == playerGuid;
            NetworkView networkView = NetworkView.Find(viewId);

            if (networkView != null)
            {
                GameObject gameObject = networkView.gameObject;               

                if (gameObject != null)
                {
                    EntityManager em = gameObject.AddComponent<EntityManager>();
                    if(em != null)
                    {
                        em.team = teamId;
                    }

                    PokemonController controller = (PokemonController)gameObject.GetComponent("PokemonController");

                    if (controller != null)
                    {
                        if (isMine)
                        {
                            gameObject.tag = "CameraTarget";
                            controller.SetMine();
                        }
                    }

                    PlayerRegistrar.Instance.List.Add(viewId, new PlayerEntry() { GameObject = gameObject, Team = teamId });
                }
            }
        }

        private bool ReadConfiguration(out string ip, out int port, out string errorMessage)
        {
            ip = null;
            port = -1;
            errorMessage = null;

            try
            {

                if (File.Exists ("Configuration.txt"))
                {
                    Regex regex = new Regex (@"(?<ip>\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}):(?<port>\d{1,5})");
                    string ipAddress = File.ReadAllText ("Configuration.txt");
                    Match match = regex.Match(ipAddress);
                    
                    if (match.Success)
                    {
                        ip = match.Groups["ip"].Value;
                        port = int.Parse(match.Groups["port"].Value);
                        return true;
                    }
                    else
                    {
                        Debug.LogError("The IP address configured in the Configuration.txt is not valid");
                        errorMessage = "The IP address configured in the Configuration.txt is not valid";
                    }
                }
                else
                {
                    Debug.LogError("No 'Configuration.txt' file found");
                    errorMessage = "No 'Configuration.txt' file found";
                }

                return false;
            }
            catch(Exception ex)
            {
                Debug.LogException(ex);
                errorMessage = "An exception occurred";
                return false;
            }
        }
    }
}