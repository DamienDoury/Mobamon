using System;
using UnityEngine;
using Mobamon.Pokemon.Helpers;
using Mobamon.UI.Languages;
using System.Collections.Generic;
using Mobamon.GameManager.Enums;

namespace Mobamon.GameManager
{
    public class MatchManager : MonoBehaviour
    {
        // Constants
        public static readonly float MaxTime = 600.0f;
        public static readonly int NumberOfPlayersRequiredInTeam = 1;

        // Server
        private float _timeElapsed = 0.0f;
        private NetworkView _networkView;

        // Both
		public bool BypassWaiting = true; // Skips the wait for other players to join in.
        public MatchState _state = MatchState.WaitingForPlayers;
        private MatchResultState _resultState = MatchResultState.Draw;
        private Dictionary<int, int> _registeredKills = new Dictionary<int, int>();


        protected void Start()
        {
            _networkView = GetComponent<NetworkView>();

            _registeredKills.Add(1, 0);
            _registeredKills.Add(2, 0);
        }

        protected void Update()
        {
            if (Network.isServer && _state != MatchState.Ended)
            {
                MatchState previousState = _state;
                int team1Count = TeamHelper.GetPlayersCountInTeam(1);
                int team2Count = TeamHelper.GetPlayersCountInTeam(2);

                // Checks if there is missing players
				if ((team1Count < NumberOfPlayersRequiredInTeam || team2Count < NumberOfPlayersRequiredInTeam) && !BypassWaiting)
                {
                    // If so, set the state to Waiting for players
                    _state = MatchState.WaitingForPlayers;
                }
                else
                {
                    _state = MatchState.Running;

                    // Otherwise increases the timer
                    _timeElapsed += Time.deltaTime;
					_networkView.RPC("SetTimer", RPCMode.OthersBuffered, _timeElapsed);

                    // If the time allotted for the game is elapsed, ended the match
                    if (_timeElapsed > MaxTime)
                    {
                        _state = MatchState.Ended;

                        // Figures which team has won
                        int team1Kills = _registeredKills[1];
                        int team2Kills = _registeredKills[2];

                        if (team1Kills > team2Kills)
                        {
                            _resultState = MatchResultState.Victory_Team1;
                        }
                        else if (team2Kills > team1Kills)
                        {
                            _resultState = MatchResultState.Victory_Team2;
                        }
                        else
                        {
                            _resultState = MatchResultState.Draw;
                        }

                        // Updates the clients' MatchResultState
                        _networkView.RPC("SetMatchResultState", RPCMode.OthersBuffered, (int)_resultState);
                    }
                }

                if (previousState != _state)
                {
                    // Updates the clients' MatchState
                    _networkView.RPC("SetMatchState", RPCMode.OthersBuffered, (int)_state);
                }
            }
        }

        protected void OnGUI()
        {
			if(LanguageManager.Language == null)
			{
				LanguageManager.Load();
				return;
			}

            if (_state == MatchState.WaitingForPlayers)
            {
                // Waiting for players
                int boxWidth = 250;
                int boxHeight = 50;
                Rect position = new Rect((Screen.width - boxWidth) / 2, (Screen.height - boxHeight) / 2, boxWidth, boxHeight);
                GUI.Label(position, LanguageManager.Language ["GameManager_MatchManager_WaitingPlayers"]);
            }
            else if (_state == MatchState.Running)
            {
                // Timer
                int timerWidth = 100;
                int timerHeight = 50;
                Rect timerPosition = new Rect((Screen.width - timerWidth) / 2, 0f, timerWidth, timerHeight);

                int minutes = (int)(_timeElapsed / 60);
                int seconds = (int)(_timeElapsed - (minutes * 60)); 

                GUI.Label(timerPosition, string.Format("{0:00}:{1:00}", minutes, seconds));

                // Kill count
                for (int i = 0; i < 2; i++)
                {
                    int killCountWidth = 50;
                    int killCountHeight = 50;
                    int widthPosition = (Screen.width - 100) / 2 + (75 * (i == 0 ? -1 : 1));
                    Rect killCountPosition = new Rect(widthPosition, 0f, killCountWidth, killCountHeight);
                    GUI.Label(killCountPosition, _registeredKills[i+1].ToString());
                }
            }
            else
            {
                // End screen
                int boxWidth = 250;
                int boxHeight = 50;
                Rect position = new Rect((Screen.width - boxWidth) / 2, (Screen.height - boxHeight) / 2, boxWidth, boxHeight);
                string message = null;

                switch (_resultState)
                {
                    case MatchResultState.Draw:
                        message = LanguageManager.Language ["GameManager_MatchManager_Draw"];
                        break;
                    case MatchResultState.Victory_Team1:
                        message = LanguageManager.Language ["GameManager_MatchManager_VictoryTeam1"];
                        break;
                    case MatchResultState.Victory_Team2:
                        message = LanguageManager.Language ["GameManager_MatchManager_VictoryTeam2"];
                        break;
                }

                message += string.Format(" Team 1 : {0} - Team 2 : {1}", _registeredKills[1], _registeredKills[2]);

                GUI.Label(position, message);
            }
        }

        public void AddKill(int teamId)
        {
            _registeredKills [teamId == 1 ? 2 : 1]++;
            
            // Updates the clients' MatchState
            _networkView.RPC("SetKills", RPCMode.OthersBuffered, _registeredKills[1], _registeredKills[2]);
        }

		[RPC]
		private void SetTimer(float timer)
		{
			_timeElapsed = timer;
		}

        [RPC]
        private void SetMatchState(int matchState)
        {
            _state = (MatchState)matchState;
        }

        [RPC]
        private void SetMatchResultState(int matchResultState)
        {
            _resultState = (MatchResultState)matchResultState;
        }

        [RPC]
        private void SetKills(int team1Kills, int team2Kills)
        {
            _registeredKills [1] = team1Kills;
            _registeredKills [2] = team2Kills;
        }
    }
}

