using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Opc.Ua;
using Opc.Ua.Server;

namespace Plant
{
    internal class PlantNodeManager : CustomNodeManager2
    {
        public PlantNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = Plant.Namespaces.Plant;
            namespaceUrls[1] = Plant.Namespaces.Plant + "/Instance";
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<PlantServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (m_configuration == null)
            {
                m_configuration = new PlantServerConfiguration();
            }
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            string currentDirectory = Directory.GetCurrentDirectory();
            predefinedNodes.LoadFromBinaryResource(context,
                currentDirectory + "\\..\\..\\Plant.PredefinedNodes.uanodes",
                typeof(PlantNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock) 
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // find the untyped Batch Plant 1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(Plant.Objects.Plant1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // convert the untyped node to a typed node that can be manipulated within the server.
                m_Plant1 = new PlantState(null);
                m_Plant1.Create(SystemContext, passiveNode);

                // replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, m_Plant1);

                m_Plant1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                m_Plant1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);

                m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
            }
        }
        public void DoSimulation(object state)
        {
            //Tank1
            m_Plant1.Tank1.Tank1LevelIndicator.Output.Value = 11;
            m_Plant1.Tank1.Tank1DischargeValve.Input.Value = 12;
            //Tank2
            m_Plant1.Tank2.Tank2LevelIndicator.Output.Value = 21;
            m_Plant1.Tank2.Tank2DischargeValve.Input.Value = 22;
            //Tank3
            m_Plant1.Tank3.Tank3LevelIndicator.Output.Value = 31;
            m_Plant1.Tank3.Tank3DischargeValve.Input.Value = 32;
        }
        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }

        private PlantServerConfiguration m_configuration;
        private static PlantState m_Plant1;
        private System.Threading.Timer m_simulationTimer;
    }
}
