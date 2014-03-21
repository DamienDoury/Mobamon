using System;
using System.IO;
using System.Xml.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace Mobamon.UI.Languages
{
    public class Language
    {
        #region Properties

        #region Main Menu

        public string MainMenu_Buttons_Play
        {
            get { return translations ["MainMenu_Buttons_Play"]; }
        }

        public string MainMenu_Buttons_Leaderboard
        {
            get { return translations ["MainMenu_Buttons_Leaderboard"]; }
        }

        public string MainMenu_Buttons_Options
        {
            get { return translations ["MainMenu_Buttons_Options"]; }
        }

        public string MainMenu_Buttons_Exit
        {
            get { return translations ["MainMenu_Buttons_Exit"]; }
        }

        public string MainMenu_Buttons_Confirm
        {
            get { return translations ["MainMenu_Buttons_Confirm"]; }
        }

        public string MainMenu_Buttons_Cancel
        {
            get { return translations ["MainMenu_Buttons_Cancel"]; }
        }

        #endregion

        #endregion

        private static Dictionary<string, string> translations;

        public string this[string key]
        {
            get { return translations.ContainsKey(key) ? translations[key] : key; }
            private set { translations[key] = value; }
        }

        public static Language Create(string fileContent)
        {
            Language language = new Language();
            XDocument document = XDocument.Parse(fileContent);
            var root = document.Root;

            translations = ReadDocument(root, string.Empty, true);

            return language;
        }

        private static Dictionary<string, string> ReadDocument(XElement root, string rootString, bool isRoot)
        {
            Dictionary<string, string> results = new Dictionary<string, string>();
            string key = string.Empty;

            if (!isRoot)
            {
                key = string.IsNullOrEmpty(rootString) ? root.Name.ToString() : string.Format("{0}_{1}", rootString, root.Name);
            }
            
            if (root.HasElements)
            {
                foreach (var element in root.Elements())
                {
                    var values = ReadDocument(element, key, false);

                    foreach (var kvp in values)
                    {
                        results.Add(kvp.Key, kvp.Value);
                    }
                }
            }
            else
            {
                results.Add(key, root.Value);
            }

            return results;
        }

        private Language()
        {
        }
    }
}

