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
            CultureInfo culture = new CultureInfo("az-latn-AZ");
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}