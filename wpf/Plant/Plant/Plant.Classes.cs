/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Plant
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the PlantType_StartProcess Method.
        /// </summary>
        public const uint PlantType_StartProcess = 15120;

        /// <summary>
        /// The identifier for the PlantType_StopProcess Method.
        /// </summary>
        public const uint PlantType_StopProcess = 15121;

        /// <summary>
        /// The identifier for the Plant1_StartProcess Method.
        /// </summary>
        public const uint Plant1_StartProcess = 15168;

        /// <summary>
        /// The identifier for the Plant1_StopProcess Method.
        /// </summary>
        public const uint Plant1_StopProcess = 15169;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Tank1Type_Tank1LevelIndicator Object.
        /// </summary>
        public const uint Tank1Type_Tank1LevelIndicator = 15030;

        /// <summary>
        /// The identifier for the Tank1Type_Tank1DischargeValve Object.
        /// </summary>
        public const uint Tank1Type_Tank1DischargeValve = 15037;

        /// <summary>
        /// The identifier for the Tank2Type_Tank2LevelIndicator Object.
        /// </summary>
        public const uint Tank2Type_Tank2LevelIndicator = 15045;

        /// <summary>
        /// The identifier for the Tank2Type_Tank2DischargeValve Object.
        /// </summary>
        public const uint Tank2Type_Tank2DischargeValve = 15052;

        /// <summary>
        /// The identifier for the Tank3Type_Tank3LevelIndicator Object.
        /// </summary>
        public const uint Tank3Type_Tank3LevelIndicator = 15060;

        /// <summary>
        /// The identifier for the Tank3Type_Tank3DischargeValve Object.
        /// </summary>
        public const uint Tank3Type_Tank3DischargeValve = 15067;

        /// <summary>
        /// The identifier for the PlantType_Tank1 Object.
        /// </summary>
        public const uint PlantType_Tank1 = 15075;

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1LevelIndicator Object.
        /// </summary>
        public const uint PlantType_Tank1_Tank1LevelIndicator = 15076;

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1DischargeValve Object.
        /// </summary>
        public const uint PlantType_Tank1_Tank1DischargeValve = 15083;

        /// <summary>
        /// The identifier for the PlantType_Tank2 Object.
        /// </summary>
        public const uint PlantType_Tank2 = 15090;

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2LevelIndicator Object.
        /// </summary>
        public const uint PlantType_Tank2_Tank2LevelIndicator = 15091;

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2DischargeValve Object.
        /// </summary>
        public const uint PlantType_Tank2_Tank2DischargeValve = 15098;

        /// <summary>
        /// The identifier for the PlantType_Tank3 Object.
        /// </summary>
        public const uint PlantType_Tank3 = 15105;

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3LevelIndicator Object.
        /// </summary>
        public const uint PlantType_Tank3_Tank3LevelIndicator = 15106;

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3DischargeValve Object.
        /// </summary>
        public const uint PlantType_Tank3_Tank3DischargeValve = 15113;

        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public const uint Plant1 = 15122;

        /// <summary>
        /// The identifier for the Plant1_Tank1 Object.
        /// </summary>
        public const uint Plant1_Tank1 = 15123;

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1LevelIndicator Object.
        /// </summary>
        public const uint Plant1_Tank1_Tank1LevelIndicator = 15124;

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1DischargeValve Object.
        /// </summary>
        public const uint Plant1_Tank1_Tank1DischargeValve = 15131;

        /// <summary>
        /// The identifier for the Plant1_Tank2 Object.
        /// </summary>
        public const uint Plant1_Tank2 = 15138;

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2LevelIndicator Object.
        /// </summary>
        public const uint Plant1_Tank2_Tank2LevelIndicator = 15139;

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2DischargeValve Object.
        /// </summary>
        public const uint Plant1_Tank2_Tank2DischargeValve = 15146;

        /// <summary>
        /// The identifier for the Plant1_Tank3 Object.
        /// </summary>
        public const uint Plant1_Tank3 = 15153;

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3LevelIndicator Object.
        /// </summary>
        public const uint Plant1_Tank3_Tank3LevelIndicator = 15154;

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3DischargeValve Object.
        /// </summary>
        public const uint Plant1_Tank3_Tank3DischargeValve = 15161;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public const uint GenericSensorType = 15001;

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public const uint GenericActuatorType = 15008;

        /// <summary>
        /// The identifier for the LevelIndicatorType ObjectType.
        /// </summary>
        public const uint LevelIndicatorType = 15015;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 15022;

        /// <summary>
        /// The identifier for the Tank1Type ObjectType.
        /// </summary>
        public const uint Tank1Type = 15029;

        /// <summary>
        /// The identifier for the Tank2Type ObjectType.
        /// </summary>
        public const uint Tank2Type = 15044;

        /// <summary>
        /// The identifier for the Tank3Type ObjectType.
        /// </summary>
        public const uint Tank3Type = 15059;

        /// <summary>
        /// The identifier for the PlantType ObjectType.
        /// </summary>
        public const uint PlantType = 15074;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public const uint GenericSensorType_Output = 15002;

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public const uint GenericSensorType_Output_EURange = 15006;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public const uint GenericActuatorType_Input = 15009;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public const uint GenericActuatorType_Input_EURange = 15013;

        /// <summary>
        /// The identifier for the LevelIndicatorType_Output_EURange Variable.
        /// </summary>
        public const uint LevelIndicatorType_Output_EURange = 15020;

        /// <summary>
        /// The identifier for the ValveType_Input_EURange Variable.
        /// </summary>
        public const uint ValveType_Input_EURange = 15027;

        /// <summary>
        /// The identifier for the Tank1Type_Tank1LevelIndicator_Output Variable.
        /// </summary>
        public const uint Tank1Type_Tank1LevelIndicator_Output = 15031;

        /// <summary>
        /// The identifier for the Tank1Type_Tank1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Tank1Type_Tank1LevelIndicator_Output_EURange = 15035;

        /// <summary>
        /// The identifier for the Tank1Type_Tank1DischargeValve_Input Variable.
        /// </summary>
        public const uint Tank1Type_Tank1DischargeValve_Input = 15038;

        /// <summary>
        /// The identifier for the Tank1Type_Tank1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Tank1Type_Tank1DischargeValve_Input_EURange = 15042;

        /// <summary>
        /// The identifier for the Tank2Type_Tank2LevelIndicator_Output Variable.
        /// </summary>
        public const uint Tank2Type_Tank2LevelIndicator_Output = 15046;

        /// <summary>
        /// The identifier for the Tank2Type_Tank2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Tank2Type_Tank2LevelIndicator_Output_EURange = 15050;

        /// <summary>
        /// The identifier for the Tank2Type_Tank2DischargeValve_Input Variable.
        /// </summary>
        public const uint Tank2Type_Tank2DischargeValve_Input = 15053;

        /// <summary>
        /// The identifier for the Tank2Type_Tank2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Tank2Type_Tank2DischargeValve_Input_EURange = 15057;

        /// <summary>
        /// The identifier for the Tank3Type_Tank3LevelIndicator_Output Variable.
        /// </summary>
        public const uint Tank3Type_Tank3LevelIndicator_Output = 15061;

        /// <summary>
        /// The identifier for the Tank3Type_Tank3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Tank3Type_Tank3LevelIndicator_Output_EURange = 15065;

        /// <summary>
        /// The identifier for the Tank3Type_Tank3DischargeValve_Input Variable.
        /// </summary>
        public const uint Tank3Type_Tank3DischargeValve_Input = 15068;

        /// <summary>
        /// The identifier for the Tank3Type_Tank3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Tank3Type_Tank3DischargeValve_Input_EURange = 15072;

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1LevelIndicator_Output Variable.
        /// </summary>
        public const uint PlantType_Tank1_Tank1LevelIndicator_Output = 15077;

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PlantType_Tank1_Tank1LevelIndicator_Output_EURange = 15081;

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1DischargeValve_Input Variable.
        /// </summary>
        public const uint PlantType_Tank1_Tank1DischargeValve_Input = 15084;

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint PlantType_Tank1_Tank1DischargeValve_Input_EURange = 15088;

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2LevelIndicator_Output Variable.
        /// </summary>
        public const uint PlantType_Tank2_Tank2LevelIndicator_Output = 15092;

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PlantType_Tank2_Tank2LevelIndicator_Output_EURange = 15096;

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2DischargeValve_Input Variable.
        /// </summary>
        public const uint PlantType_Tank2_Tank2DischargeValve_Input = 15099;

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint PlantType_Tank2_Tank2DischargeValve_Input_EURange = 15103;

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3LevelIndicator_Output Variable.
        /// </summary>
        public const uint PlantType_Tank3_Tank3LevelIndicator_Output = 15107;

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PlantType_Tank3_Tank3LevelIndicator_Output_EURange = 15111;

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3DischargeValve_Input Variable.
        /// </summary>
        public const uint PlantType_Tank3_Tank3DischargeValve_Input = 15114;

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint PlantType_Tank3_Tank3DischargeValve_Input_EURange = 15118;

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1LevelIndicator_Output Variable.
        /// </summary>
        public const uint Plant1_Tank1_Tank1LevelIndicator_Output = 15125;

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Plant1_Tank1_Tank1LevelIndicator_Output_EURange = 15129;

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1DischargeValve_Input Variable.
        /// </summary>
        public const uint Plant1_Tank1_Tank1DischargeValve_Input = 15132;

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Plant1_Tank1_Tank1DischargeValve_Input_EURange = 15136;

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2LevelIndicator_Output Variable.
        /// </summary>
        public const uint Plant1_Tank2_Tank2LevelIndicator_Output = 15140;

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Plant1_Tank2_Tank2LevelIndicator_Output_EURange = 15144;

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2DischargeValve_Input Variable.
        /// </summary>
        public const uint Plant1_Tank2_Tank2DischargeValve_Input = 15147;

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Plant1_Tank2_Tank2DischargeValve_Input_EURange = 15151;

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3LevelIndicator_Output Variable.
        /// </summary>
        public const uint Plant1_Tank3_Tank3LevelIndicator_Output = 15155;

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Plant1_Tank3_Tank3LevelIndicator_Output_EURange = 15159;

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3DischargeValve_Input Variable.
        /// </summary>
        public const uint Plant1_Tank3_Tank3DischargeValve_Input = 15162;

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Plant1_Tank3_Tank3DischargeValve_Input_EURange = 15166;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the PlantType_StartProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_StartProcess = new ExpandedNodeId(Plant.Methods.PlantType_StartProcess, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_StopProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_StopProcess = new ExpandedNodeId(Plant.Methods.PlantType_StopProcess, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_StartProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_StartProcess = new ExpandedNodeId(Plant.Methods.Plant1_StartProcess, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_StopProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_StopProcess = new ExpandedNodeId(Plant.Methods.Plant1_StopProcess, Plant.Namespaces.Plant);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Tank1Type_Tank1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Tank1Type_Tank1LevelIndicator = new ExpandedNodeId(Plant.Objects.Tank1Type_Tank1LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank1Type_Tank1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Tank1Type_Tank1DischargeValve = new ExpandedNodeId(Plant.Objects.Tank1Type_Tank1DischargeValve, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank2Type_Tank2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Tank2Type_Tank2LevelIndicator = new ExpandedNodeId(Plant.Objects.Tank2Type_Tank2LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank2Type_Tank2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Tank2Type_Tank2DischargeValve = new ExpandedNodeId(Plant.Objects.Tank2Type_Tank2DischargeValve, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank3Type_Tank3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Tank3Type_Tank3LevelIndicator = new ExpandedNodeId(Plant.Objects.Tank3Type_Tank3LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank3Type_Tank3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Tank3Type_Tank3DischargeValve = new ExpandedNodeId(Plant.Objects.Tank3Type_Tank3DischargeValve, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank1 Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank1 = new ExpandedNodeId(Plant.Objects.PlantType_Tank1, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank1_Tank1LevelIndicator = new ExpandedNodeId(Plant.Objects.PlantType_Tank1_Tank1LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank1_Tank1DischargeValve = new ExpandedNodeId(Plant.Objects.PlantType_Tank1_Tank1DischargeValve, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank2 = new ExpandedNodeId(Plant.Objects.PlantType_Tank2, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank2_Tank2LevelIndicator = new ExpandedNodeId(Plant.Objects.PlantType_Tank2_Tank2LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank2_Tank2DischargeValve = new ExpandedNodeId(Plant.Objects.PlantType_Tank2_Tank2DischargeValve, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank3 Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank3 = new ExpandedNodeId(Plant.Objects.PlantType_Tank3, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank3_Tank3LevelIndicator = new ExpandedNodeId(Plant.Objects.PlantType_Tank3_Tank3LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank3_Tank3DischargeValve = new ExpandedNodeId(Plant.Objects.PlantType_Tank3_Tank3DischargeValve, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1 = new ExpandedNodeId(Plant.Objects.Plant1, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1 = new ExpandedNodeId(Plant.Objects.Plant1_Tank1, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_Tank1LevelIndicator = new ExpandedNodeId(Plant.Objects.Plant1_Tank1_Tank1LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_Tank1DischargeValve = new ExpandedNodeId(Plant.Objects.Plant1_Tank1_Tank1DischargeValve, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank2 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank2 = new ExpandedNodeId(Plant.Objects.Plant1_Tank2, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank2_Tank2LevelIndicator = new ExpandedNodeId(Plant.Objects.Plant1_Tank2_Tank2LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank2_Tank2DischargeValve = new ExpandedNodeId(Plant.Objects.Plant1_Tank2_Tank2DischargeValve, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank3 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank3 = new ExpandedNodeId(Plant.Objects.Plant1_Tank3, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank3_Tank3LevelIndicator = new ExpandedNodeId(Plant.Objects.Plant1_Tank3_Tank3LevelIndicator, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank3_Tank3DischargeValve = new ExpandedNodeId(Plant.Objects.Plant1_Tank3_Tank3DischargeValve, Plant.Namespaces.Plant);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(Plant.ObjectTypes.GenericSensorType, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(Plant.ObjectTypes.GenericActuatorType, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the LevelIndicatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LevelIndicatorType = new ExpandedNodeId(Plant.ObjectTypes.LevelIndicatorType, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(Plant.ObjectTypes.ValveType, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank1Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Tank1Type = new ExpandedNodeId(Plant.ObjectTypes.Tank1Type, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank2Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Tank2Type = new ExpandedNodeId(Plant.ObjectTypes.Tank2Type, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank3Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Tank3Type = new ExpandedNodeId(Plant.ObjectTypes.Tank3Type, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PlantType = new ExpandedNodeId(Plant.ObjectTypes.PlantType, Plant.Namespaces.Plant);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(Plant.Variables.GenericSensorType_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(Plant.Variables.GenericSensorType_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(Plant.Variables.GenericActuatorType_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(Plant.Variables.GenericActuatorType_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the LevelIndicatorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LevelIndicatorType_Output_EURange = new ExpandedNodeId(Plant.Variables.LevelIndicatorType_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the ValveType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ValveType_Input_EURange = new ExpandedNodeId(Plant.Variables.ValveType_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank1Type_Tank1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank1Type_Tank1LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.Tank1Type_Tank1LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank1Type_Tank1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank1Type_Tank1LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.Tank1Type_Tank1LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank1Type_Tank1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank1Type_Tank1DischargeValve_Input = new ExpandedNodeId(Plant.Variables.Tank1Type_Tank1DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank1Type_Tank1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank1Type_Tank1DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.Tank1Type_Tank1DischargeValve_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank2Type_Tank2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank2Type_Tank2LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.Tank2Type_Tank2LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank2Type_Tank2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank2Type_Tank2LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.Tank2Type_Tank2LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank2Type_Tank2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank2Type_Tank2DischargeValve_Input = new ExpandedNodeId(Plant.Variables.Tank2Type_Tank2DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank2Type_Tank2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank2Type_Tank2DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.Tank2Type_Tank2DischargeValve_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank3Type_Tank3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank3Type_Tank3LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.Tank3Type_Tank3LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank3Type_Tank3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank3Type_Tank3LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.Tank3Type_Tank3LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank3Type_Tank3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank3Type_Tank3DischargeValve_Input = new ExpandedNodeId(Plant.Variables.Tank3Type_Tank3DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Tank3Type_Tank3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Tank3Type_Tank3DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.Tank3Type_Tank3DischargeValve_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank1_Tank1LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.PlantType_Tank1_Tank1LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank1_Tank1LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.PlantType_Tank1_Tank1LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank1_Tank1DischargeValve_Input = new ExpandedNodeId(Plant.Variables.PlantType_Tank1_Tank1DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank1_Tank1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank1_Tank1DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.PlantType_Tank1_Tank1DischargeValve_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank2_Tank2LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.PlantType_Tank2_Tank2LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank2_Tank2LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.PlantType_Tank2_Tank2LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank2_Tank2DischargeValve_Input = new ExpandedNodeId(Plant.Variables.PlantType_Tank2_Tank2DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank2_Tank2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank2_Tank2DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.PlantType_Tank2_Tank2DischargeValve_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank3_Tank3LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.PlantType_Tank3_Tank3LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank3_Tank3LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.PlantType_Tank3_Tank3LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank3_Tank3DischargeValve_Input = new ExpandedNodeId(Plant.Variables.PlantType_Tank3_Tank3DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the PlantType_Tank3_Tank3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantType_Tank3_Tank3DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.PlantType_Tank3_Tank3DischargeValve_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_Tank1LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.Plant1_Tank1_Tank1LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_Tank1LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.Plant1_Tank1_Tank1LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_Tank1DischargeValve_Input = new ExpandedNodeId(Plant.Variables.Plant1_Tank1_Tank1DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_Tank1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_Tank1DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.Plant1_Tank1_Tank1DischargeValve_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank2_Tank2LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.Plant1_Tank2_Tank2LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank2_Tank2LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.Plant1_Tank2_Tank2LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank2_Tank2DischargeValve_Input = new ExpandedNodeId(Plant.Variables.Plant1_Tank2_Tank2DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank2_Tank2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank2_Tank2DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.Plant1_Tank2_Tank2DischargeValve_Input_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank3_Tank3LevelIndicator_Output = new ExpandedNodeId(Plant.Variables.Plant1_Tank3_Tank3LevelIndicator_Output, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank3_Tank3LevelIndicator_Output_EURange = new ExpandedNodeId(Plant.Variables.Plant1_Tank3_Tank3LevelIndicator_Output_EURange, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank3_Tank3DischargeValve_Input = new ExpandedNodeId(Plant.Variables.Plant1_Tank3_Tank3DischargeValve_Input, Plant.Namespaces.Plant);

        /// <summary>
        /// The identifier for the Plant1_Tank3_Tank3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank3_Tank3DischargeValve_Input_EURange = new ExpandedNodeId(Plant.Variables.Plant1_Tank3_Tank3DischargeValve_Input_EURange, Plant.Namespaces.Plant);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the GenericActuatorType component.
        /// </summary>
        public const string GenericActuatorType = "GenericActuatorType";

        /// <summary>
        /// The BrowseName for the GenericSensorType component.
        /// </summary>
        public const string GenericSensorType = "GenericSensorType";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the LevelIndicatorType component.
        /// </summary>
        public const string LevelIndicatorType = "LevelIndicatorType";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the Plant1 component.
        /// </summary>
        public const string Plant1 = "Plant #1";

        /// <summary>
        /// The BrowseName for the PlantType component.
        /// </summary>
        public const string PlantType = "PlantType";

        /// <summary>
        /// The BrowseName for the StartProcess component.
        /// </summary>
        public const string StartProcess = "StartProcess";

        /// <summary>
        /// The BrowseName for the StopProcess component.
        /// </summary>
        public const string StopProcess = "StopProcess";

        /// <summary>
        /// The BrowseName for the Tank1 component.
        /// </summary>
        public const string Tank1 = "TankX01";

        /// <summary>
        /// The BrowseName for the Tank1DischargeValve component.
        /// </summary>
        public const string Tank1DischargeValve = "DV01";

        /// <summary>
        /// The BrowseName for the Tank1LevelIndicator component.
        /// </summary>
        public const string Tank1LevelIndicator = "LI01";

        /// <summary>
        /// The BrowseName for the Tank1Type component.
        /// </summary>
        public const string Tank1Type = "Tank1Type";

        /// <summary>
        /// The BrowseName for the Tank2 component.
        /// </summary>
        public const string Tank2 = "TankX02";

        /// <summary>
        /// The BrowseName for the Tank2DischargeValve component.
        /// </summary>
        public const string Tank2DischargeValve = "DV02";

        /// <summary>
        /// The BrowseName for the Tank2LevelIndicator component.
        /// </summary>
        public const string Tank2LevelIndicator = "LI02";

        /// <summary>
        /// The BrowseName for the Tank2Type component.
        /// </summary>
        public const string Tank2Type = "Tank2Type";

        /// <summary>
        /// The BrowseName for the Tank3 component.
        /// </summary>
        public const string Tank3 = "TankX03";

        /// <summary>
        /// The BrowseName for the Tank3DischargeValve component.
        /// </summary>
        public const string Tank3DischargeValve = "DV03";

        /// <summary>
        /// The BrowseName for the Tank3LevelIndicator component.
        /// </summary>
        public const string Tank3LevelIndicator = "LI03";

        /// <summary>
        /// The BrowseName for the Tank3Type component.
        /// </summary>
        public const string Tank3Type = "Tank3Type";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the Plant namespace (.NET code namespace is 'Plant').
        /// </summary>
        public const string Plant = "http://opcfoundation.org/Plant";
    }
    #endregion

    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <summary>
    /// Stores an instance of the GenericSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Plant.ObjectTypes.GenericSensorType, Plant.Namespaces.Plant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnT/////BGCAAAEAAAABABkAAABHZW5l" +
           "cmljU2Vuc29yVHlwZUluc3RhbmNlAQGZOgEBmTr/////AQAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQGa" +
           "OgAvAQBACZo6AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGeOgAuAESeOgAA" +
           "AQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Output Variable.
        /// </summary>
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Plant.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_output;
        #endregion
    }
    #endif
    #endregion

    #region GenericActuatorState Class
    #if (!OPCUA_EXCLUDE_GenericActuatorState)
    /// <summary>
    /// Stores an instance of the GenericActuatorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericActuatorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Plant.ObjectTypes.GenericActuatorType, Plant.Namespaces.Plant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnT/////BGCAAAEAAAABABsAAABHZW5l" +
           "cmljQWN0dWF0b3JUeXBlSW5zdGFuY2UBAaA6AQGgOv////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB" +
           "oToALwEAQAmhOgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpToALgBEpToA" +
           "AAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Input Variable.
        /// </summary>
        public AnalogItemState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Plant.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_input;
        #endregion
    }
    #endif
    #endregion

    #region LevelIndicatorState Class
    #if (!OPCUA_EXCLUDE_LevelIndicatorState)
    /// <summary>
    /// Stores an instance of the LevelIndicatorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LevelIndicatorState : GenericSensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LevelIndicatorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Plant.ObjectTypes.LevelIndicatorType, Plant.Namespaces.Plant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnT/////BGCAAAEAAAABABoAAABMZXZl" +
           "bEluZGljYXRvclR5cGVJbnN0YW5jZQEBpzoBAac6/////wEAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB" +
           "qDoALwEAQAmoOgAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBrDoALgBErDoA" +
           "AAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <summary>
    /// Stores an instance of the ValveType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : GenericActuatorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Plant.ObjectTypes.ValveType, Plant.Namespaces.Plant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnT/////BGCAAAEAAAABABEAAABWYWx2" +
           "ZVR5cGVJbnN0YW5jZQEBrjoBAa46/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQGvOgAvAQBACa86" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGzOgAuAESzOgAAAQB0A/////8B" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Tank1State Class
    #if (!OPCUA_EXCLUDE_Tank1State)
    /// <summary>
    /// Stores an instance of the Tank1Type ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Tank1State : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Tank1State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Plant.ObjectTypes.Tank1Type, Plant.Namespaces.Plant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnT/////BGCAAAEAAAABABEAAABUYW5r" +
           "MVR5cGVJbnN0YW5jZQEBtToBAbU6AgAAAAAwAAEBtjoAMAABAb06AgAAAIRgwAoBAAAAEwAAAFRhbmsx" +
           "TGV2ZWxJbmRpY2F0b3IBAAQAAABMSTAxAQG2OgAvAQGnOrY6AAABAQAAAAAwAQEBtToBAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAbc6AC8BAEAJtzoAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAbs6AC4ARLs6AAABAHQD/////wEB/////wAAAACEYMAKAQAAABMAAABUYW5rMURpc2NoYXJn" +
           "ZVZhbHZlAQAEAAAARFYwMQEBvToALwEBrjq9OgAAAQEAAAAAMAEBAbU6AQAAABVgiQoCAAAAAQAFAAAA" +
           "SW5wdXQBAb46AC8BAEAJvjoAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAcI6" +
           "AC4ARMI6AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the LI01 Object.
        /// </summary>
        public LevelIndicatorState Tank1LevelIndicator
        {
            get
            {
                return m_tank1LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank1LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank1LevelIndicator = value;
            }
        }

        /// <summary>
        /// A description for the DV01 Object.
        /// </summary>
        public ValveState Tank1DischargeValve
        {
            get
            {
                return m_tank1DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank1DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank1DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_tank1LevelIndicator != null)
            {
                children.Add(m_tank1LevelIndicator);
            }

            if (m_tank1DischargeValve != null)
            {
                children.Add(m_tank1DischargeValve);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Plant.BrowseNames.Tank1LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Tank1LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Tank1LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Tank1LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Tank1LevelIndicator;
                    break;
                }

                case Plant.BrowseNames.Tank1DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Tank1DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Tank1DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Tank1DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Tank1DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_tank1LevelIndicator;
        private ValveState m_tank1DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region Tank2State Class
    #if (!OPCUA_EXCLUDE_Tank2State)
    /// <summary>
    /// Stores an instance of the Tank2Type ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Tank2State : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Tank2State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Plant.ObjectTypes.Tank2Type, Plant.Namespaces.Plant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnT/////BGCAAAEAAAABABEAAABUYW5r" +
           "MlR5cGVJbnN0YW5jZQEBxDoBAcQ6AgAAAAAwAAEBxToAMAABAcw6AgAAAIRgwAoBAAAAEwAAAFRhbmsy" +
           "TGV2ZWxJbmRpY2F0b3IBAAQAAABMSTAyAQHFOgAvAQGnOsU6AAABAQAAAAAwAQEBxDoBAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAcY6AC8BAEAJxjoAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAco6AC4ARMo6AAABAHQD/////wEB/////wAAAACEYMAKAQAAABMAAABUYW5rMkRpc2NoYXJn" +
           "ZVZhbHZlAQAEAAAARFYwMgEBzDoALwEBrjrMOgAAAQEAAAAAMAEBAcQ6AQAAABVgiQoCAAAAAQAFAAAA" +
           "SW5wdXQBAc06AC8BAEAJzToAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdE6" +
           "AC4ARNE6AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the LI02 Object.
        /// </summary>
        public LevelIndicatorState Tank2LevelIndicator
        {
            get
            {
                return m_tank2LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank2LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank2LevelIndicator = value;
            }
        }

        /// <summary>
        /// A description for the DV02 Object.
        /// </summary>
        public ValveState Tank2DischargeValve
        {
            get
            {
                return m_tank2DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank2DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank2DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_tank2LevelIndicator != null)
            {
                children.Add(m_tank2LevelIndicator);
            }

            if (m_tank2DischargeValve != null)
            {
                children.Add(m_tank2DischargeValve);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Plant.BrowseNames.Tank2LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Tank2LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Tank2LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Tank2LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Tank2LevelIndicator;
                    break;
                }

                case Plant.BrowseNames.Tank2DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Tank2DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Tank2DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Tank2DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Tank2DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_tank2LevelIndicator;
        private ValveState m_tank2DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region Tank3State Class
    #if (!OPCUA_EXCLUDE_Tank3State)
    /// <summary>
    /// Stores an instance of the Tank3Type ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Tank3State : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Tank3State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Plant.ObjectTypes.Tank3Type, Plant.Namespaces.Plant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnT/////BGCAAAEAAAABABEAAABUYW5r" +
           "M1R5cGVJbnN0YW5jZQEB0zoBAdM6AgAAAAAwAAEB1DoAMAABAds6AgAAAIRgwAoBAAAAEwAAAFRhbmsz" +
           "TGV2ZWxJbmRpY2F0b3IBAAQAAABMSTAzAQHUOgAvAQGnOtQ6AAABAQAAAAAwAQEB0zoBAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAdU6AC8BAEAJ1ToAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAdk6AC4ARNk6AAABAHQD/////wEB/////wAAAACEYMAKAQAAABMAAABUYW5rM0Rpc2NoYXJn" +
           "ZVZhbHZlAQAEAAAARFYwMwEB2zoALwEBrjrbOgAAAQEAAAAAMAEBAdM6AQAAABVgiQoCAAAAAQAFAAAA" +
           "SW5wdXQBAdw6AC8BAEAJ3DoAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAeA6" +
           "AC4AROA6AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the LI03 Object.
        /// </summary>
        public LevelIndicatorState Tank3LevelIndicator
        {
            get
            {
                return m_tank3LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank3LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank3LevelIndicator = value;
            }
        }

        /// <summary>
        /// A description for the DV03 Object.
        /// </summary>
        public ValveState Tank3DischargeValve
        {
            get
            {
                return m_tank3DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank3DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank3DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_tank3LevelIndicator != null)
            {
                children.Add(m_tank3LevelIndicator);
            }

            if (m_tank3DischargeValve != null)
            {
                children.Add(m_tank3DischargeValve);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Plant.BrowseNames.Tank3LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Tank3LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Tank3LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Tank3LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Tank3LevelIndicator;
                    break;
                }

                case Plant.BrowseNames.Tank3DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Tank3DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Tank3DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Tank3DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Tank3DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_tank3LevelIndicator;
        private ValveState m_tank3DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region PlantState Class
    #if (!OPCUA_EXCLUDE_PlantState)
    /// <summary>
    /// Stores an instance of the PlantType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PlantState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PlantState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Plant.ObjectTypes.PlantType, Plant.Namespaces.Plant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnT/////hGCAAAEAAAABABEAAABQbGFu" +
           "dFR5cGVJbnN0YW5jZQEB4joBAeI6AQMAAAAAMAABAeM6ADAAAQHyOgAwAAEBATsFAAAAhGDACgEAAAAF" +
           "AAAAVGFuazEBAAcAAABUYW5rWDAxAQHjOgAvAQG1OuM6AAABAwAAAAAwAQEB4joAMAABAeQ6ADAAAQHr" +
           "OgIAAACEYMAKAQAAABMAAABUYW5rMUxldmVsSW5kaWNhdG9yAQAEAAAATEkwMQEB5DoALwEBpzrkOgAA" +
           "AQEAAAAAMAEBAeM6AQAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQHlOgAvAQBACeU6AAAAC/////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHpOgAuAETpOgAAAQB0A/////8BAf////8AAAAAhGDA" +
           "CgEAAAATAAAAVGFuazFEaXNjaGFyZ2VWYWx2ZQEABAAAAERWMDEBAes6AC8BAa466zoAAAEBAAAAADAB" +
           "AQHjOgEAAAAVYIkKAgAAAAEABQAAAElucHV0AQHsOgAvAQBACew6AAAAC/////8DA/////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQHwOgAuAETwOgAAAQB0A/////8BAf////8AAAAAhGDACgEAAAAFAAAA" +
           "VGFuazIBAAcAAABUYW5rWDAyAQHyOgAvAQHEOvI6AAABAwAAAAAwAQEB4joAMAABAfM6ADAAAQH6OgIA" +
           "AACEYMAKAQAAABMAAABUYW5rMkxldmVsSW5kaWNhdG9yAQAEAAAATEkwMgEB8zoALwEBpzrzOgAAAQEA" +
           "AAAAMAEBAfI6AQAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQH0OgAvAQBACfQ6AAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH4OgAuAET4OgAAAQB0A/////8BAf////8AAAAAhGDACgEA" +
           "AAATAAAAVGFuazJEaXNjaGFyZ2VWYWx2ZQEABAAAAERWMDIBAfo6AC8BAa46+joAAAEBAAAAADABAQHy" +
           "OgEAAAAVYIkKAgAAAAEABQAAAElucHV0AQH7OgAvAQBACfs6AAAAC/////8DA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQH/OgAuAET/OgAAAQB0A/////8BAf////8AAAAAhGDACgEAAAAFAAAAVGFu" +
           "azMBAAcAAABUYW5rWDAzAQEBOwAvAQHTOgE7AAABAwAAAAAwAQEB4joAMAABAQI7ADAAAQEJOwIAAACE" +
           "YMAKAQAAABMAAABUYW5rM0xldmVsSW5kaWNhdG9yAQAEAAAATEkwMwEBAjsALwEBpzoCOwAAAQEAAAAA" +
           "MAEBAQE7AQAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQEDOwAvAQBACQM7AAAAC/////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQEHOwAuAEQHOwAAAQB0A/////8BAf////8AAAAAhGDACgEAAAAT" +
           "AAAAVGFuazNEaXNjaGFyZ2VWYWx2ZQEABAAAAERWMDMBAQk7AC8BAa46CTsAAAEBAAAAADABAQEBOwEA" +
           "AAAVYIkKAgAAAAEABQAAAElucHV0AQEKOwAvAQBACQo7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQEOOwAuAEQOOwAAAQB0A/////8BAf////8AAAAABGGCCgQAAAABAAwAAABTdGFy" +
           "dFByb2Nlc3MBARA7AC8BARA7EDsAAAEB/////wAAAAAEYYIKBAAAAAEACwAAAFN0b3BQcm9jZXNzAQER" +
           "OwAvAQEROxE7AAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the TankX01 Object.
        /// </summary>
        public Tank1State Tank1
        {
            get
            {
                return m_tank1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank1 = value;
            }
        }

        /// <summary>
        /// A description for the TankX02 Object.
        /// </summary>
        public Tank2State Tank2
        {
            get
            {
                return m_tank2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank2 = value;
            }
        }

        /// <summary>
        /// A description for the TankX03 Object.
        /// </summary>
        public Tank3State Tank3
        {
            get
            {
                return m_tank3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank3 = value;
            }
        }

        /// <summary>
        /// A description for the StartProcess Method.
        /// </summary>
        public MethodState StartProcess
        {
            get
            {
                return m_startProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startProcessMethod = value;
            }
        }

        /// <summary>
        /// A description for the StopProcess Method.
        /// </summary>
        public MethodState StopProcess
        {
            get
            {
                return m_stopProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopProcessMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_tank1 != null)
            {
                children.Add(m_tank1);
            }

            if (m_tank2 != null)
            {
                children.Add(m_tank2);
            }

            if (m_tank3 != null)
            {
                children.Add(m_tank3);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Plant.BrowseNames.Tank1:
                {
                    if (createOrReplace)
                    {
                        if (Tank1 == null)
                        {
                            if (replacement == null)
                            {
                                Tank1 = new Tank1State(this);
                            }
                            else
                            {
                                Tank1 = (Tank1State)replacement;
                            }
                        }
                    }

                    instance = Tank1;
                    break;
                }

                case Plant.BrowseNames.Tank2:
                {
                    if (createOrReplace)
                    {
                        if (Tank2 == null)
                        {
                            if (replacement == null)
                            {
                                Tank2 = new Tank2State(this);
                            }
                            else
                            {
                                Tank2 = (Tank2State)replacement;
                            }
                        }
                    }

                    instance = Tank2;
                    break;
                }

                case Plant.BrowseNames.Tank3:
                {
                    if (createOrReplace)
                    {
                        if (Tank3 == null)
                        {
                            if (replacement == null)
                            {
                                Tank3 = new Tank3State(this);
                            }
                            else
                            {
                                Tank3 = (Tank3State)replacement;
                            }
                        }
                    }

                    instance = Tank3;
                    break;
                }

                case Plant.BrowseNames.StartProcess:
                {
                    if (createOrReplace)
                    {
                        if (StartProcess == null)
                        {
                            if (replacement == null)
                            {
                                StartProcess = new MethodState(this);
                            }
                            else
                            {
                                StartProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartProcess;
                    break;
                }

                case Plant.BrowseNames.StopProcess:
                {
                    if (createOrReplace)
                    {
                        if (StopProcess == null)
                        {
                            if (replacement == null)
                            {
                                StopProcess = new MethodState(this);
                            }
                            else
                            {
                                StopProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopProcess;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private Tank1State m_tank1;
        private Tank2State m_tank2;
        private Tank3State m_tank3;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        #endregion
    }
    #endif
    #endregion
}