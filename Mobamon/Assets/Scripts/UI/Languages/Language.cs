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
            get;
            private set;
        }

        public string MainMenu_Buttons_Leaderboard
        {
            get;
            private set;
        }

        public string MainMenu_Buttons_Options
        {
            get;
            private set;
        }

        public string MainMenu_Buttons_Exit
        {
            get;
            private set;
        }

        public string MainMenu_Buttons_Confirm
        {
            get;
            private set;
        }

        public string MainMenu_Buttons_Cancel
        {
            get;
            private set;
        }

        #endregion

        #endregion

        public static Language Create(string fileContent)
        {
            Language language = new Language();
            Type type = typeof(Language);
            XDocument document = XDocument.Parse(fileContent);
            var root = document.Root;

            Dictionary<string, string> translations = new Dictionary<string, string>();

            foreach (XElement element in root.Elements())
            {
                var values = ReadDocument(element, string.Empty);
                foreach (var kvp in values)
                {
                    translations.Add(kvp.Key, kvp.Value);
                }
            }

            foreach (var translation in translations)
            {
                var property = type.GetProperty(translation.Key);

                if (property != null)
                {
                    property.SetValue(language, translation.Value, null);
                }
            }

            return language;
        }

        private static Dictionary<string, string> ReadDocument(XElement root, string rootString)
        {
            Dictionary<string, string> results = new Dictionary<string, string>();
            string key = string.IsNullOrEmpty(rootString) ? root.Name.ToString() : string.Format("{0}_{1}", rootString, root.Name);
            
            if (root.HasElements)
            {
                foreach (var element in root.Elements())
                {
                    var values = ReadDocument(element, key);

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
            this.MainMenu_Buttons_Cancel = "MainMenu_Buttons_Cancel";
            this.MainMenu_Buttons_Confirm = "MainMenu_Buttons_Confirm";
            this.MainMenu_Buttons_Exit = "MainMenu_Buttons_Exit";
            this.MainMenu_Buttons_Leaderboard = "MainMenu_Buttons_Leaderboard";
            this.MainMenu_Buttons_Options = "MainMenu_Buttons_Options";
            this.MainMenu_Buttons_Play = "MainMenu_Buttons_Play";
        }
    }
}

