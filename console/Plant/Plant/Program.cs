using System;
using System.IO;
using System.Threading; // Added for ManualResetEvent
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server; // Added for StandardServer

namespace Plant
{
    internal static class Program
    {
        // A ManualResetEvent to keep the console application alive until a signal is received
        private static ManualResetEvent quitEvent = new ManualResetEvent(false);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] // STAThread is still relevant for some COM interop scenarios, even in console apps, but less critical here.
        static void Main(string[] args) // Added args to potentially process command line arguments
        {
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "PlantServer";

            try
            {
                // Process command line arguments. This is important if you use command line
                // tools to install/uninstall the server as a service.
                if (application.ProcessCommandLine())
                {
                    // If command line arguments were processed (e.g., /install, /uninstall),
                    // the application should exit after processing.
                    Console.WriteLine("Command line arguments processed. Exiting.");
                    return;
                }

                // Check if the application is running interactively.
                // In a console application, Environment.UserInteractive is typically true.
                // This block is primarily for when the app is installed and run as a Windows Service.
                if (!Environment.UserInteractive)
                {
                    Console.WriteLine("Starting Plant OPC UA Server as a Windows Service...");
                    application.StartAsService(new PlantServer());
                    // When running as a service, the service manager handles the lifetime.
                    // No need for Console.ReadLine() or quitEvent here.
                    return;
                }

                // --- Interactive Console Application Logic ---
                Console.WriteLine("Starting Plant OPC UA Server in interactive console mode...");

                // Load the application configuration.
                // IMPORTANT: The hardcoded path is not ideal for deployment.
                // Consider using a relative path or an environment variable.
                string currentDirectory = Directory.GetCurrentDirectory();
                Console.WriteLine($"Loading application configuration from: {currentDirectory}+\\..\\..\\PlantServer.Config.xml");
                application.LoadApplicationConfiguration(currentDirectory + "\\..\\..\\PlantServer.Config.xml", false).Wait();

                // Check and validate the application instance certificate.
                Console.WriteLine("Checking application instance certificate...");
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // Start the OPC UA server.
                Console.WriteLine("Starting OPC UA Server...");
                application.Start(new PlantServer()).Wait();
                Console.WriteLine("OPC UA Server started successfully.");

                // --- Display all server endpoints, similar to Form1's comboBox ---
                Console.WriteLine("\nAvailable Server Endpoints:");
                // Corrected: Access endpoints directly from the server instance after it has started.
                // Cast application.Server to StandardServer and then call GetEndpoints().
                var server = application.Server as StandardServer;
                if (server != null && server.GetEndpoints() != null && server.GetEndpoints().Count > 0)
                {
                    foreach (var endpoint in server.GetEndpoints())
                    {
                        Console.WriteLine($"- {endpoint.EndpointUrl}");
                    }
                }
                else
                {
                    Console.WriteLine("No endpoints found or server not fully initialized.");
                }
                Console.WriteLine(); // Add an empty line for better readability

                // Keep the console application running.
                // This replaces Application.Run(new Form1(...));
                Console.WriteLine("Press Ctrl+C or type 'quit' and press Enter to stop the server.");

                // Set up a handler for Ctrl+C (SIGINT) to gracefully shut down.
                Console.CancelKeyPress += (sender, eventArgs) =>
                {
                    Console.WriteLine("Ctrl+C pressed. Initiating server shutdown...");
                    eventArgs.Cancel = true; // Prevent the process from terminating immediately
                    quitEvent.Set(); // Signal the main thread to exit
                };

                // Wait for the quit signal (either Ctrl+C or typing 'quit')
                while (!quitEvent.WaitOne(1000)) // Check every second
                {
                    if (Console.KeyAvailable)
                    {
                        string input = Console.ReadLine();
                        if (input != null && input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Quit command received. Initiating server shutdown...");
                            break; // Exit the loop
                        }
                    }
                }

                // Stop the OPC UA server gracefully.
                Console.WriteLine("Stopping OPC UA Server...");
                application.Stop();
                Console.WriteLine("OPC UA Server stopped.");
            }
            catch (Exception ex)
            {
                // In a console app, write errors to the console.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAn error occurred:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
                Environment.ExitCode = 1; // Indicate an error exit code
            }
            finally
            {
                // Ensure the quit event is disposed
                quitEvent.Dispose();
            }
            Console.WriteLine("Application exiting.");
        }
    }
}