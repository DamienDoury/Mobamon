using UnityEngine;
using System;
using System.Linq;
using Mobamon.UI.Languages;

namespace Mobamon.UI.Menus
{
    public class StartMenuController : MonoBehaviour 
    {
        // Entry point
        protected void Start()
        {
            bool launchedByLauncher = false;
            bool isServer = false;
            string[] commandLineParameters = Environment.GetCommandLineArgs();

            // On game launch, checks the command line parameters
            if (commandLineParameters != null && commandLineParameters.Length > 0)
            {
                isServer = commandLineParameters.Any((commandLineParameter) => commandLineParameter == "--server");

                // The game is launched as a client
                if (!isServer)
                {                
                    launchedByLauncher = commandLineParameters.Any((commandLineParameter) => commandLineParameter == "--launcher");

                    // Checks if the game is launched by the launcher
                    if (launchedByLauncher)
                    {
                        // TODO : Client logic goes here
                        Application.LoadLevel("MainMenuScene");
                    }
                    else
                    {
                        // The game has been launched manually
                        // TODO : Display an error message asking the user to use the launcher instead of running the game manually
                        LanguageManager.Load();
                        Application.LoadLevel("MainMenuScene");
                    }
                }
                else
                {
                    // The game is launched as a server
                    // TODO : Server logic goes here
                }
            }
        }
    }
}