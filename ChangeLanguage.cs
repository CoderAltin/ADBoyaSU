using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;

namespace MultiLanguageTest_01
{
    public static class ChangeLanguage
    {
        public static void ToEnglishUS()
        {
            //MessageBox.Show("Changing language to \n\tEnglish");

            UpdateLangConfig("en-US");
        }

        public static void ToEnglishUK()
        {
            //MessageBox.Show("Changing language to \n\tEnglish");

            UpdateLangConfig("en-GB");
        }

        public static void ToTurkuAzerbaycan()
        {
            //MessageBox.Show("Changing language to \n\tTurku-Azerbaycan");

            UpdateLangConfig("az-latn-AZ");
        }

        /// <summary>
        /// Changes the value of the 'language' node in app.config to the language specified by 'Value'
        /// </summary>
        /// <param name="value">desired language</param>
        static void UpdateLangConfig(string value)
        {
            XmlDocument configFile = new XmlDocument();

            string location = Directory.GetCurrentDirectory() + "\\ADBoyaSU.dll.config";

            configFile.Load(location);

            try
            {
                foreach (XmlElement element in configFile.DocumentElement)
                {
                    if (element.Name.Equals("appSettings"))
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            if (node.Attributes[0].Value.Equals("language"))
                                node.Attributes[1].Value = value;
                        }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when trying to find the language you're looking for in config file\n" +
                    "Possibly a null reference");
            }

            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
            configFile.Save(location);

            Application.Restart();
        }
    }
}
