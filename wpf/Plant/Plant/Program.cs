using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Configuration;

namespace Plant
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "PlantServer";
            try
            {
                if (application.ProcessCommandLine())
                {
                    return;
                }
                if (!Environment.UserInteractive) 
                {
                    application.StartAsService(new PlantServer());
                    return;
                }
                string currentDirectory = Directory.GetCurrentDirectory();
                application.LoadApplicationConfiguration(currentDirectory + "\\..\\..\\PlantServer.Config.xml", false).Wait();
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                application.Start(new PlantServer()).Wait();
                Application.Run(new Form1(application));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
