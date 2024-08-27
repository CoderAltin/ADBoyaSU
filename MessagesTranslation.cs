using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBoyaSU
{
    public class MessagesTranslation
    {
        // reading language from configurationManager and applying it
        string? lang = ConfigurationManager.AppSettings["language"] ?? "az-latn-AZ";

        public void LoadMessages()
        {
            CultureInfo culture = new System.Globalization.CultureInfo(lang);

            
        }

    }
}
