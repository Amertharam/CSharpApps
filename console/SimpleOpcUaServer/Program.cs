using System;
using System.Threading;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

namespace SimpleOpcUaServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting OPC UA Server...");

                var application = new ApplicationInstance
                {
                    ApplicationName = "Simple OPC UA Server",
                    ApplicationType = ApplicationType.Server,
                    ConfigSectionName = "SimpleOpcUaServer"
                };

                // Load configuration
                application.LoadApplicationConfiguration("Opc.Ua.Config.xml", false).Wait();
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // Start the server
                var server = new SimpleUaServer();
                application.Start(server).Wait();

                Console.WriteLine("Server started. Press Ctrl+C to exit...");

                // Wait for exit
                ManualResetEvent quitEvent = new ManualResetEvent(false);
                Console.CancelKeyPress += (sender, eArgs) =>
                {
                    quitEvent.Set();
                    eArgs.Cancel = true;
                };
                quitEvent.WaitOne();

                server.Stop();
                Console.WriteLine("Server stopped.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
