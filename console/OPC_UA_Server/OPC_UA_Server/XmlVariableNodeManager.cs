using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using UnifiedAutomation.UaBase;
using UnifiedAutomation.UaServer;

namespace OPC_UA_Server
{
    public class XmlVariableNodeManager : BaseNodeManager
    {
        // Path to the XML file containing variable data
        private const string XmlFilePath = "Variables.xml";

        // Dictionary to store variable nodes for easy access
        private Dictionary<string, VariableNode> _variables;

        // Namespace indices for types and instances
        public ushort InstanceNamespaceIndex { get; set; }

        /// <summary>
        /// Constructor for the XmlVariableNodeManager
        /// </summary>
        public XmlVariableNodeManager(ServerManager serverManager)
            : base(serverManager)
        {
            _variables = new Dictionary<string, VariableNode>();
        }

        /// <summary>
        /// Startup method called when the node manager is started
        /// </summary>
        public override void Startup()
        {
            try
            {
                Console.WriteLine("Starting XmlVariableNodeManager...");

                // Call base startup method
                base.Startup();

                // Set the namespace URI for our variables
                InstanceNamespaceIndex = AddNamespaceUri("http://example.org/OPC_UA_Server/");

                // Create a folder for our variables
                NodeId folderNodeId = new NodeId("Variables", InstanceNamespaceIndex);
                QualifiedName browseName = new QualifiedName("Variables", InstanceNamespaceIndex);
                LocalizedText displayName = new LocalizedText("Variables");

                CreateObjectSettings settings = new CreateObjectSettings()
                {
                    ParentNodeId = ObjectIds.ObjectsFolder,
                    ReferenceTypeId = ReferenceTypeIds.Organizes,
                    RequestedNodeId = folderNodeId,
                    BrowseName = browseName,
                    DisplayName = displayName,
                    TypeDefinitionId = ObjectTypeIds.FolderType
                };

                ObjectNode variablesFolder = CreateObject(Server.DefaultRequestContext, settings);

                // Read variables from XML and create OPC UA variables
                ReadVariablesFromXml(variablesFolder.NodeId);

                Console.WriteLine("XmlVariableNodeManager started successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting XmlVariableNodeManager: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Read variables from XML file and create corresponding OPC UA variables
        /// </summary>
        private void ReadVariablesFromXml(NodeId parentNodeId)
        {
            try
            {
                string filePath = Directory.GetCurrentDirectory() + "\\..\\..\\" + XmlFilePath;
                // Check if XML file exists
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Warning: XML file not found at {XmlFilePath}. Using default values.");
                    CreateDefaultVariables(parentNodeId);
                    return;
                }

                // Load XML document
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                // Get all Variable nodes
                XmlNodeList variableNodes = xmlDoc.SelectNodes("//Variable");

                if (variableNodes == null || variableNodes.Count == 0)
                {
                    Console.WriteLine("Warning: No variables found in XML file. Using default values.");
                    CreateDefaultVariables(parentNodeId);
                    return;
                }

                // Process each variable node
                foreach (XmlNode node in variableNodes)
                {
                    string id = node.Attributes["id"]?.Value;
                    string name = node.Attributes["name"]?.Value;
                    string valueStr = node.Attributes["value"]?.Value;

                    if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(valueStr))
                    {
                        Console.WriteLine("Warning: Variable with missing attributes found in XML. Skipping.");
                        continue;
                    }

                    // Try to parse the value as double
                    if (double.TryParse(valueStr, out double value))
                    {
                        // Create OPC UA variable
                        CreateVariable(parentNodeId, id, name, value);
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Could not parse value '{valueStr}' as double for variable {id}. Using default value.");
                        CreateVariable(parentNodeId, id, name, 0.0);
                    }
                }

                Console.WriteLine($"Successfully loaded {_variables.Count} variables from XML file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading variables from XML: {ex.Message}");
                Console.WriteLine("Using default values instead.");
                CreateDefaultVariables(parentNodeId);
            }
        }

        /// <summary>
        /// Create default variables if XML reading fails
        /// </summary>
        private void CreateDefaultVariables(NodeId parentNodeId)
        {
            CreateVariable(parentNodeId, "Variable1", "Temperature", 0.00);
            CreateVariable(parentNodeId, "Variable2", "Pressure", 0.00);
            CreateVariable(parentNodeId, "Variable3", "Humidity", 0.00);
        }

        /// <summary>
        /// Create an OPC UA variable with the specified properties
        /// </summary>
        private void CreateVariable(NodeId parentNodeId, string id, string name, double value)
        {
            try
            {
                // Create a unique NodeId for the variable
                NodeId nodeId = new NodeId($"Variable_{id}", InstanceNamespaceIndex);

                // Create browse name and display name
                QualifiedName browseName = new QualifiedName(name, InstanceNamespaceIndex);
                LocalizedText displayName = new LocalizedText(name);

                // Create the variable settings
                CreateVariableSettings settings = new CreateVariableSettings()
                {
                    ParentNodeId = parentNodeId,
                    ReferenceTypeId = ReferenceTypeIds.HasComponent,
                    RequestedNodeId = nodeId,
                    BrowseName = browseName,
                    DisplayName = displayName,
                    TypeDefinitionId = VariableTypeIds.BaseDataVariableType,
                    DataType = DataTypeIds.Double,
                    ValueRank = ValueRanks.Scalar,
                    AccessLevel = AccessLevels.CurrentRead
                };

                // Create the variable
                VariableNode variable = CreateVariable(Server.DefaultRequestContext, settings);

                // Set the value
                variable.Value = new Variant(value);

                // Store the variable in our dictionary for easy access
                _variables[id] = variable;

                Console.WriteLine($"Created variable: {name} with value {value}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating variable {id}: {ex.Message}");
            }
        }
    }
}
