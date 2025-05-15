using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SimplePluginFramework
{
    public class PluginManager
    {
        private List<IPlugin> _plugins = new List<IPlugin>();

        public void LoadPlugins(string pluginDirectory)
        {
            if (!System.IO.Directory.Exists(pluginDirectory))
            {
                Console.WriteLine($"Directory not found: {pluginDirectory}");
                return;
            }

            string[] pluginFiles = System.IO.Directory.GetFiles(pluginDirectory, "*.dll");

            foreach (string pluginFile in pluginFiles)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(pluginFile);
                    var types = assembly.GetTypes().Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

                    foreach (Type type in types)
                    {
                        if (Activator.CreateInstance(type) is IPlugin plugin)
                        {
                            _plugins.Add(plugin);
                            Console.WriteLine($"Loaded plugin: {plugin.Name}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading plugin from {pluginFile}: {ex.Message}");
                }
            }
        }

        public void RunAllPlugins()
        {
            Console.WriteLine("\nRunning all loaded plugins:");
            foreach (var plugin in _plugins)
            {
                Console.WriteLine($"- {plugin.Name}:");
                plugin.Execute();
            }
        }
    }
}