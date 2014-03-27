using UnityEngine;
using Mobamon.UI.Menus.Enums;
using System;
using Mobamon.UI.Languages;
using System.Text.RegularExpressions;
using Mobamon.Pokemon.Player;
using Mobamon.Networking;
using Mobamon.Database;

namespace Mobamon.UI.Menus
{
    public class MainMenuController : MonoBehaviour
    {
        #region Fields

        public Texture backgroundTexture;
        public GUISkin guiSkin;
        private Vector2 scrollPosition;

        #endregion

        #region Properties

        private MainMenuStep Step { get; set; }

        #endregion

        #region MonoBehavior Methods

        protected void Start()
        {
            this.Step = MainMenuStep.Server;
        }

        protected void OnGUI()
        {
            switch (this.Step)
            {
				case MainMenuStep.Server:
					this.DrawServer();
					break;

                case MainMenuStep.Exit:
                    this.DrawExitMenu();
                    break;

                case MainMenuStep.PokemonSelection:
                    this.DrawSelectPokemonMenu();
                    break;

                case MainMenuStep.Play:
                case MainMenuStep.Leaderboard:
                case MainMenuStep.Options:
                case MainMenuStep.Main:
                default:
                    this.DrawMainMenu();
                    break;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Draws the main menu.
        /// </summary>
        private void DrawMainMenu()
        {
            GUI.skin = this.guiSkin;
            
            // Draws the background image
            GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), this.backgroundTexture);
            
            // Draws the title
            GUI.Label(new Rect(0f, Screen.height * 0.1f, Screen.width, Screen.height * 0.1f), "Mobamon");
            
            // Draws the choices
            GUILayout.BeginArea(new Rect(100f, Screen.height * 0.3f, Screen.width - 200f, Screen.height * 0.6f));
            
            GUILayout.BeginVertical();
            this.CreateButton(LanguageManager.Language.MainMenu_Buttons_Play, OnPlayMainButtonClicked);
            this.CreateButton(LanguageManager.Language.MainMenu_Buttons_Leaderboard, OnLeaderboardMainButtonClicked);
            this.CreateButton(LanguageManager.Language.MainMenu_Buttons_Options, OnOptionsMainButtonClicked);
            this.CreateButton(LanguageManager.Language.MainMenu_Buttons_Exit, OnExitMainButtonClicked);
            GUILayout.EndVertical();
            
            GUILayout.EndArea();
        }

        private void DrawExitMenu()
        {
            GUI.skin = this.guiSkin;
            
            // Draws the background image
            GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), this.backgroundTexture);

            // Draws the choices
            GUILayout.BeginArea(new Rect(100f, Screen.height * 0.3f, Screen.width - 200f, Screen.height * 0.6f));
            
            GUILayout.BeginHorizontal();
            this.CreateButton(LanguageManager.Language.MainMenu_Buttons_Confirm, OnConfirmExitButtonClicked);
            this.CreateButton(LanguageManager.Language.MainMenu_Buttons_Cancel, OnCancelExitButtonClicked);
            GUILayout.EndHorizontal();
            
            GUILayout.EndArea();
        }

        private void DrawSelectPokemonMenu()
        {
            // Draws the background image
            GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), this.backgroundTexture);

            GUILayout.BeginArea(new Rect(100f, Screen.height * 0.3f, Screen.width - 200f, Screen.height * 0.6f));

            GUILayout.BeginHorizontal();
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, new GUIStyle());

            var pokemons = Resources.LoadAll("Pokemons");
            Regex regex = new Regex("(?<id>[0-9]{3}) - [a-zA-Z0-9]+");
            foreach (var pokemon in pokemons)
            {
                GameObject pokemonGO = (GameObject)pokemon;
                var controller = pokemonGO.GetComponent<PokemonController>();
                if (controller == null)
                {
                    continue;
                }

                Match match = regex.Match(pokemon.name);

                if (match.Success)
                {
                    int id = int.Parse(match.Groups["id"].Value);
                    string pokemonKey = Pokedex.pokemons[id].NameKey;
                    string name = LanguageManager.Language[pokemonKey];

                    Texture icon = Resources.Load<Texture>("Portraits/Front/pokemon_front_" + id);
                    GUIContent content = new GUIContent(name, icon);

                    this.CreateButton(content, () => { this.OnPokemonSelected(id); });
                }
            }

            GUILayout.EndScrollView();
            GUILayout.EndHorizontal();

            GUILayout.EndArea();
        }

		private void DrawServer()
		{
            GUI.skin = this.guiSkin;
            GUIStyle style = new GUIStyle();
            style.fontSize = 30;
            style.normal.textColor = Color.white;
			
			// Draws the background image
			GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), this.backgroundTexture);
			
			// Draws the choices
			GUILayout.BeginArea(new Rect(100f, Screen.height * 0.3f, Screen.width - 200f, Screen.height * 0.6f));
			
			GUILayout.BeginVertical();
            GUILayout.Label(LanguageManager.Language ["MainMenu_Labels_PlayType"], style);
			this.CreateButton(LanguageManager.Language["MainMenu_Buttons_Client"], OnClientButtonClicked);
			this.CreateButton(LanguageManager.Language["MainMenu_Buttons_Server"], OnServerButtonClicked);
			GUILayout.EndVertical();
			
			GUILayout.EndArea();
		}

        /// <summary>
        /// Draws the button with the given text and checks if it's currently clicked
        /// </summary>
        /// <param name="buttonText">Button text.</param>
        /// <param name="clickAction">Method to call when the button is clicked.</param>
        private void CreateButton(string text, Action clickAction)
        {
            if (GUILayout.Button(text))
            {
                clickAction();
            }
        }
        
        /// <summary>
        /// Draws the button with the given text and checks if it's currently clicked
        /// </summary>
        /// <param name="buttonText">Button text.</param>
        /// <param name="clickAction">Method to call when the button is clicked.</param>
        private void CreateButton(GUIContent content, Action clickAction)
        {
            if (GUILayout.Button(content))
            {
                clickAction();
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Raises the play button clicked event.
        /// </summary>
        private void OnPlayMainButtonClicked()
        {
            this.Step = MainMenuStep.PokemonSelection;
        }

        /// <summary>
        /// Raises the leaderboard button clicked event.
        /// </summary>
        private void OnLeaderboardMainButtonClicked()
        {
            this.Step = MainMenuStep.Leaderboard;
            Application.OpenURL("http://rickrolled.fr");
        }

        private bool test = false;

        /// <summary>
        /// Raises the options button clicked event.
        /// </summary>
        private void OnOptionsMainButtonClicked()
        {
            this.Step = MainMenuStep.Options;
            if (test)
            {
                LanguageManager.Language = Language.Create(Resources.Load<TextAsset>("Languages/Language_en").text);
                test = false;
            }
            else
            {
                LanguageManager.Language = Language.Create(Resources.Load<TextAsset>("Languages/Language_fr").text);
                test = true;
            }
        }

        /// <summary>
        /// Raises the exit button clicked event.
        /// </summary>
        private void OnExitMainButtonClicked()
        {
            this.Step = MainMenuStep.Exit;
        }

        /// <summary>
        /// Raises the confirm exit button clicked event.
        /// </summary>
        private void OnConfirmExitButtonClicked()
        {
            Application.Quit();
        }

        /// <summary>
        /// Raises the cancel exit button clicked event.
        /// </summary>
        private void OnCancelExitButtonClicked()
        {
            this.Step = MainMenuStep.Main;
        }

        private void OnPokemonSelected(int id)
        {
            this.Step = MainMenuStep.Play;
            NetworkManager.ChosenPokemonId = id;
            Application.LoadLevel("Test");
        }

		private void OnClientButtonClicked()
		{
			NetworkManager.IsServer = false;
			this.Step = MainMenuStep.Play;
		}

		private void OnServerButtonClicked()
		{
			NetworkManager.IsServer = true;
			Application.LoadLevel("Test");
		}

        #endregion
    }
}
