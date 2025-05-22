using System;
using UnifiedAutomation.UaBase;

namespace OPC_UA_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Load the license from embedded resource
                ApplicationLicenseManager.AddProcessLicenses(typeof(Program).Assembly, "License.lic");

                Console.WriteLine("Starting OPC UA Server...");

                // Create an instance of our custom server manager
                SimpleServerManager server = new SimpleServerManager();

                // Create and configure the application instance
                ApplicationInstance application = ApplicationInstance.Default;
                application.NoAutoStartService = true;
                application.AutoCreateCertificate = true;

                // Handle untrusted certificates
                application.UntrustedCertificate += (sender, e) =>
                {
                    e.Accept = true; // Auto-accept untrusted certificates
                };

                // Start the server
                application.Start(server, null, server);

                // Print available endpoints
                PrintEndpoints(server);

                Console.WriteLine("Server started successfully.");
                Console.WriteLine("Press <enter> to exit the program.");
                Console.ReadLine();

                Console.WriteLine("Stopping Server...");
                server.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Press <enter> to exit the program.");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Print available endpoints to the console
        /// </summary>
        static void PrintEndpoints(SimpleServerManager server)
        {
            Console.WriteLine();
            Console.WriteLine("Listening at the following endpoints:");
            foreach (EndpointDescription endpoint in server.Application.Endpoints)
            {
                StatusCode error = server.Application.GetEndpointStatus(endpoint);
                Console.WriteLine($" {endpoint}: Status={error.ToString(true)}");
            }
            Console.WriteLine();
        }
    }
}
