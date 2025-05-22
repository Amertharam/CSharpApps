using System;
using UnifiedAutomation.UaServer;

namespace OPC_UA_Server
{
    public class SimpleServerManager : ServerManager
    {
        /// <summary>
        /// Called when the root node manager has started
        /// </summary>
        protected override void OnRootNodeManagerStarted(RootNodeManager nodeManager)
        {
            Console.WriteLine("Creating Node Managers...");

            // Create and start our custom node manager
            XmlVariableNodeManager xmlNodeManager = new XmlVariableNodeManager(this);
            xmlNodeManager.Startup();
        }
    }
}
