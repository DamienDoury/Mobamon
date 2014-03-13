using UnityEngine;
using Mobamon.UI.Menus.Enums;
using System;
using Mobamon.UI.Languages;

namespace Mobamon.UI.Menus
{
    public class MainMenuController : MonoBehaviour
    {
        #region Constants

        private const string BUTTON_MAIN_PLAY = "Play";
        private const string BUTTON_MAIN_LEADERBOARD = "Leaderboard";
        private const string BUTTON_MAIN_OPTIONS = "Options";
        private const string BUTTON_MAIN_EXIT = "Exit";

        private const string BUTTON_EXIT_CONFIRM = "Yes";
        private const string BUTTON_EXIT_CANCEL = "No";

        #endregion

        #region Fields

        public Texture backgroundTexture;
        public GUISkin guiSkin;

        #endregion

        #region Properties

        private MainMenuStep Step { get; set; }

        #endregion

        #region MonoBehavior Methods

        protected void Start()
        {
            this.Step = MainMenuStep.Main;
        }

        protected void OnGUI()
        {
            switch (this.Step)
            {
                case MainMenuStep.Exit:
                    this.DrawExitMenu();
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

        /// <summary>
        /// Draws the button with the given text and checks if it's currently clicked
        /// </summary>
        /// <param name="buttonText">Button text.</param>
        /// <param name="clickAction">Method to call when the button is clicked.</param>
        private void CreateButton(string buttonText, Action clickAction)
        {
            if (GUILayout.Button(buttonText))
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
            this.Step = MainMenuStep.Play;
            Application.LoadLevel("Test");
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

        #endregion
    }
}
