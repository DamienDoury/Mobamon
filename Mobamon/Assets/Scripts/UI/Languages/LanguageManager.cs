using System;
using System.IO;
using System.Threading;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Mobamon.UI.Languages
{
    public static class LanguageManager
    {
        private static readonly Regex LanguageFileRegex = new Regex(@"^Language_(?<language>[a-z]{2}(?:-[A-Z]{2})?)$");
        private static readonly string LanguageDefault = "Language_default";

        private static Language _loadedLanguage = null;
        public static Language Language
        {
            get { return _loadedLanguage; }
            set { _loadedLanguage = value; }
        }

        public static void Load()
        {
            string cultureName = CultureInfo.CurrentCulture.Name;
            TextAsset[] languageFiles = Resources.LoadAll<TextAsset>("Languages");
            TextAsset defaultFile = Resources.Load<TextAsset>(string.Format("Languages/{0}",LanguageDefault));
            TextAsset chosenFile = null;

            foreach (var file in languageFiles)
            {
                var match = LanguageFileRegex.Match(file.name);

                // If the file matches the language file template, we can check it against the current culture
                if (match.Success && match.Groups.Count > 0)
                {
                    string groupValue = match.Groups["language"].Value;

                    // Checks if the file corresponds to the current culture of the player
                    if (groupValue == cultureName)
                    {
                        // This is the strongest match as it matches the current culture at 100%
                        chosenFile = file;
                        break;
                    }
                    else if (cultureName.StartsWith(groupValue))
                    {
                        // This is not a strong match as it partially matches the current culture
                        // Though we keep it in case we don't find a strongest match
                        chosenFile = file;
                    }
                }
            }

            // If there is no language found, try to load the default one
            if (chosenFile == null)
            {
                if (defaultFile == null)
                {
                    throw new Exception("No language file found");
                }

                chosenFile = defaultFile;
            }

            // Loads the chosen language file
            _loadedLanguage = Language.Create(chosenFile.text);
        }
    }
}

