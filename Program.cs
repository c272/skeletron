using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AQASkeletronPlus.GUI;
using Config.Net;

namespace AQASkeletronPlus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Set up the configuration file.
            Settings.Get = new ConfigurationBuilder<ISettings>().UseIniFile("settings.ini").Build();

            //Run the main form.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
