using System.Configuration;
using System.Globalization;

namespace ADBoyaSU
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // reading language from configurationManager and applying it
            string? lang = ConfigurationManager.AppSettings["language"] ?? "az-latn-AZ";
            var culture = new System.Globalization.CultureInfo(lang);

            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}