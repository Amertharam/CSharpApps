using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using Opc.Ua;
using Opc.Ua.Server;

namespace SimpleOpcUaServer
{
    public class SimpleUaServer : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Console.WriteLine("Creating Node Manager...");
            return new MasterNodeManager(server, configuration, null, new CustomNodeManager(server, configuration));
        }
    }

    public class CustomNodeManager : CustomNodeManager2
    {
        public CustomNodeManager(IServerInternal server, ApplicationConfiguration configuration)
            : base(server, configuration, "http://yourcompany.com/SimpleOpcUaServer")
        {
            SystemContext.NodeIdFactory = this;
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            return new NodeStateCollection();
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            BaseObjectState root = CreateFolder(null, "MyData", "MyData", externalReferences);

            AddVariable(root, "Temperature", 25.3, DataTypeIds.Double);
            AddVariable(root, "Pressure", 1.2, DataTypeIds.Double);
            AddVariable(root, "Status", "Running", DataTypeIds.String);
        }

        private BaseObjectState CreateFolder(NodeState parent, string path, string name, IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            var folder = new FolderState(parent)
            {
                SymbolicName = name,
                ReferenceTypeId = ReferenceTypeIds.Organizes,
                TypeDefinitionId = ObjectTypeIds.FolderType,
                NodeId = new NodeId(path, NamespaceIndex),
                BrowseName = new QualifiedName(name, NamespaceIndex),
                DisplayName = name,
                WriteMask = AttributeWriteMask.None,
                UserWriteMask = AttributeWriteMask.None,
                EventNotifier = EventNotifiers.None
            };

            if (parent == null)
            {
                if (!externalReferences.TryGetValue(ObjectIds.ObjectsFolder, out var references))
                {
                    references = new List<IReference>();
                    externalReferences[ObjectIds.ObjectsFolder] = references;
                }

                references.Add(new NodeStateReference(ReferenceTypeIds.Organizes, false, folder.NodeId));
                folder.AddReference(ReferenceTypeIds.Organizes, true, ObjectIds.ObjectsFolder);
            }
            else
            {
                parent.AddReference(ReferenceTypeIds.Organizes, false, folder.NodeId);
            }

            AddPredefinedNode(SystemContext, folder);
            return folder;
        }

        private void AddVariable(BaseObjectState parent, string name, object defaultValue, NodeId dataType)
        {
            var variable = new BaseDataVariableState(parent)
            {
                SymbolicName = name,
                ReferenceTypeId = ReferenceTypeIds.HasComponent,
                TypeDefinitionId = VariableTypeIds.BaseDataVariableType,
                NodeId = new NodeId(name, NamespaceIndex),
                BrowseName = new QualifiedName(name, NamespaceIndex),
                DisplayName = name,
                DataType = dataType,
                ValueRank = ValueRanks.Scalar,
                AccessLevel = AccessLevels.CurrentRead,
                UserAccessLevel = AccessLevels.CurrentRead,
                Value = defaultValue,
                StatusCode = StatusCodes.Good,
                Timestamp = DateTime.UtcNow
            };

            parent?.AddChild(variable);
        }
    }
}
