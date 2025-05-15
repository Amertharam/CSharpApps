using System;
using SimplePluginFramework;
using System.IO;

namespace FrameworkConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pluginManager = new PluginManager();
            string pluginDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");

            // Create the Plugins directory if it doesn't exist
            Directory.CreateDirectory(pluginDirectory);

            // Copy the ExamplePlugin.dll to the Plugins directory (for simplicity)
            string sourcePluginPath = "C:\\Users\\amert\\source\\repos\\cSharpApps\\console\\FrameworkConsumer\\ExamplePlugin\\bin\\Debug\\netstandard2.0\\ExamplePlugin.dll";//Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..","..", "..", "ExamplePlugin", "bin", "Debug", "netstandard2.0", "ExamplePlugin.dll"); // Adjust path as needed
            string destinationPluginPath = Path.Combine(pluginDirectory, "ExamplePlugin.dll");
            if (File.Exists(sourcePluginPath) && !File.Exists(destinationPluginPath))
            {
                File.Copy(sourcePluginPath, destinationPluginPath, true);
                Console.WriteLine($"Copied plugin to: {destinationPluginPath}");
            }
            else if (!File.Exists(sourcePluginPath))
            {
                Console.WriteLine($"Warning: ExamplePlugin.dll not found at: {sourcePluginPath}");
            }


            pluginManager.LoadPlugins(pluginDirectory);
            pluginManager.RunAllPlugins();
            Console.ReadKey ();
        }
    }
}