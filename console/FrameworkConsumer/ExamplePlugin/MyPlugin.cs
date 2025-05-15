using SimplePluginFramework;
using System;

namespace ExamplePlugin
{
    public class MyPlugin : IPlugin
    {
        public string Name => "My Awesome Plugin";

        public void Execute()
        {
            Console.WriteLine("Executing the awesome plugin's functionality!");
        }
    }
}