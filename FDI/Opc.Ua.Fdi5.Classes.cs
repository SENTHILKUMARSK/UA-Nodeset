/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
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
using Opc.Ua.Di;
using Opc.Ua;

namespace Opc.Ua.Fdi5
{
    #region UIDescriptionState Class
    #if (!OPCUA_EXCLUDE_UIDescriptionState)
    /// <summary>
    /// Stores an instance of the UIDescriptionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class UIDescriptionState : UIElementState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public UIDescriptionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi5.VariableTypes.UIDescriptionType, Opc.Ua.Fdi5.Namespaces.OpcUaFdi5, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
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
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQACAAAAAQAZAAAAVUlEZXNjcmlwdGlvblR5cGVJbnN0" +
           "YW5jZQEBAQABAQEAAAz/////AQH/////AAAAAA==";
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

    #region UIPlugInState Class
    #if (!OPCUA_EXCLUDE_UIPlugInState)
    /// <summary>
    /// Stores an instance of the UIPlugInType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class UIPlugInState : UIElementState<byte[]>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public UIPlugInState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi5.VariableTypes.UIPlugInType, Opc.Ua.Fdi5.Namespaces.OpcUaFdi5, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Byte, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.OneDimension;
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

            if (Documentation != null)
            {
                Documentation.Initialize(context, Documentation_InitializationString);
            }
        }

        #region Initialization String
        private const string Documentation_InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQANAAAARG9jdW1lbnRhdGlvbgEBCgAALwA9" +
           "CgAAAP////8AAAAA";

        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQACAAAAAQAUAAAAVUlQbHVnSW5UeXBlSW5zdGFuY2UB" +
           "AQIAAQECAAADAQAAAAEB/////wgAAAAVYIkKAgAAAAEAEQAAAFVJUFZhcmlhbnRWZXJzaW9uAQEDAAAu" +
           "AEQDAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAUAAAARkRJVGVjaG5vbG9neVZlcnNpb24BAQQA" +
           "AC4ARAQAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAkAAABSdW50aW1lSWQBAQUAAC4ARAUAAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAA4AAABDcHVJbmZvcm1hdGlvbgEBBgAALgBEBgAAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEACgAAAFBsYXRmb3JtSWQBAQcAAC4ARAcAAAAADP////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAUAAABTdHlsZQEBCAAALgBECAAAAAEBxAD/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAQAAAAU3RhcnRFbGVtZW50TmFtZQEBCQAALgBECQAAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEA" +
           "DQAAAERvY3VtZW50YXRpb24BAQoAAC8APQoAAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the UIPVariantVersion Property.
        /// </summary>
        public PropertyState<string> UIPVariantVersion
        {
            get
            {
                return m_uIPVariantVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uIPVariantVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uIPVariantVersion = value;
            }
        }

        /// <summary>
        /// A description for the FDITechnologyVersion Property.
        /// </summary>
        public PropertyState<string> FDITechnologyVersion
        {
            get
            {
                return m_fDITechnologyVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fDITechnologyVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fDITechnologyVersion = value;
            }
        }

        /// <summary>
        /// A description for the RuntimeId Property.
        /// </summary>
        public PropertyState<string> RuntimeId
        {
            get
            {
                return m_runtimeId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runtimeId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runtimeId = value;
            }
        }

        /// <summary>
        /// A description for the CpuInformation Property.
        /// </summary>
        public PropertyState<string> CpuInformation
        {
            get
            {
                return m_cpuInformation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cpuInformation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cpuInformation = value;
            }
        }

        /// <summary>
        /// A description for the PlatformId Property.
        /// </summary>
        public PropertyState<string> PlatformId
        {
            get
            {
                return m_platformId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_platformId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_platformId = value;
            }
        }

        /// <summary>
        /// A description for the Style Property.
        /// </summary>
        public PropertyState<StyleType> Style
        {
            get
            {
                return m_style;
            }

            set
            {
                if (!Object.ReferenceEquals(m_style, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_style = value;
            }
        }

        /// <summary>
        /// A description for the StartElementName Property.
        /// </summary>
        public PropertyState<string> StartElementName
        {
            get
            {
                return m_startElementName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startElementName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startElementName = value;
            }
        }

        /// <summary>
        /// A description for the Documentation Object.
        /// </summary>
        public FolderState Documentation
        {
            get
            {
                return m_documentation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_documentation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_documentation = value;
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
            if (m_uIPVariantVersion != null)
            {
                children.Add(m_uIPVariantVersion);
            }

            if (m_fDITechnologyVersion != null)
            {
                children.Add(m_fDITechnologyVersion);
            }

            if (m_runtimeId != null)
            {
                children.Add(m_runtimeId);
            }

            if (m_cpuInformation != null)
            {
                children.Add(m_cpuInformation);
            }

            if (m_platformId != null)
            {
                children.Add(m_platformId);
            }

            if (m_style != null)
            {
                children.Add(m_style);
            }

            if (m_startElementName != null)
            {
                children.Add(m_startElementName);
            }

            if (m_documentation != null)
            {
                children.Add(m_documentation);
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
                case Opc.Ua.Fdi5.BrowseNames.UIPVariantVersion:
                {
                    if (createOrReplace)
                    {
                        if (UIPVariantVersion == null)
                        {
                            if (replacement == null)
                            {
                                UIPVariantVersion = new PropertyState<string>(this);
                            }
                            else
                            {
                                UIPVariantVersion = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = UIPVariantVersion;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.FDITechnologyVersion:
                {
                    if (createOrReplace)
                    {
                        if (FDITechnologyVersion == null)
                        {
                            if (replacement == null)
                            {
                                FDITechnologyVersion = new PropertyState<string>(this);
                            }
                            else
                            {
                                FDITechnologyVersion = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = FDITechnologyVersion;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.RuntimeId:
                {
                    if (createOrReplace)
                    {
                        if (RuntimeId == null)
                        {
                            if (replacement == null)
                            {
                                RuntimeId = new PropertyState<string>(this);
                            }
                            else
                            {
                                RuntimeId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = RuntimeId;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.CpuInformation:
                {
                    if (createOrReplace)
                    {
                        if (CpuInformation == null)
                        {
                            if (replacement == null)
                            {
                                CpuInformation = new PropertyState<string>(this);
                            }
                            else
                            {
                                CpuInformation = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CpuInformation;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.PlatformId:
                {
                    if (createOrReplace)
                    {
                        if (PlatformId == null)
                        {
                            if (replacement == null)
                            {
                                PlatformId = new PropertyState<string>(this);
                            }
                            else
                            {
                                PlatformId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = PlatformId;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.Style:
                {
                    if (createOrReplace)
                    {
                        if (Style == null)
                        {
                            if (replacement == null)
                            {
                                Style = new PropertyState<StyleType>(this);
                            }
                            else
                            {
                                Style = (PropertyState<StyleType>)replacement;
                            }
                        }
                    }

                    instance = Style;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.StartElementName:
                {
                    if (createOrReplace)
                    {
                        if (StartElementName == null)
                        {
                            if (replacement == null)
                            {
                                StartElementName = new PropertyState<string>(this);
                            }
                            else
                            {
                                StartElementName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = StartElementName;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.Documentation:
                {
                    if (createOrReplace)
                    {
                        if (Documentation == null)
                        {
                            if (replacement == null)
                            {
                                Documentation = new FolderState(this);
                            }
                            else
                            {
                                Documentation = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Documentation;
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
        private PropertyState<string> m_uIPVariantVersion;
        private PropertyState<string> m_fDITechnologyVersion;
        private PropertyState<string> m_runtimeId;
        private PropertyState<string> m_cpuInformation;
        private PropertyState<string> m_platformId;
        private PropertyState<StyleType> m_style;
        private PropertyState<string> m_startElementName;
        private FolderState m_documentation;
        #endregion
    }
    #endif
    #endregion

    #region ActionState Class
    #if (!OPCUA_EXCLUDE_ActionState)
    /// <summary>
    /// Stores an instance of the ActionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActionState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ActionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi5.ObjectTypes.ActionType, Opc.Ua.Fdi5.Namespaces.OpcUaFdi5, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQASAAAAQWN0aW9uVHlwZUluc3RhbmNlAQEL" +
           "AAEBCwD/////AAAAAA==";
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

    #region InvokeActionMethodState Class
    #if (!OPCUA_EXCLUDE_InvokeActionMethodState)
    /// <summary>
    /// Stores an instance of the InvokeActionMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InvokeActionMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public InvokeActionMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new InvokeActionMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAWAAAASW52b2tlQWN0aW9uTWV0aG9kVHlw" +
           "ZQEBDAAALwEBDAAMAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQ0AAC4A" +
           "RA0AAACWAgAAAAEAKgEBGQAAAAoAAABBY3Rpb25OYW1lAAz/////AAAAAAABACoBAR4AAAAPAAAATWV0" +
           "aG9kQXJndW1lbnRzAAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBDgAALgBEDgAAAJYCAAAAAQAqAQEbAAAADAAAAEFjdGlvbk5vZGVJZAAR/////wAA" +
           "AAAAAQAqAQEgAAAAEQAAAEludm9rZUFjdGlvbkVycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public InvokeActionMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string actionName = (string)inputArguments[0];
            string methodArguments = (string)inputArguments[1];

            NodeId actionNodeId = (NodeId)outputArguments[0];
            int invokeActionError = (int)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    actionName,
                    methodArguments,
                    ref actionNodeId,
                    ref invokeActionError);
            }

            outputArguments[0] = actionNodeId;
            outputArguments[1] = invokeActionError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult InvokeActionMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string actionName,
        string methodArguments,
        ref NodeId actionNodeId,
        ref int invokeActionError);
    #endif
    #endregion

    #region RespondActionMethodState Class
    #if (!OPCUA_EXCLUDE_RespondActionMethodState)
    /// <summary>
    /// Stores an instance of the RespondActionMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RespondActionMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RespondActionMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new RespondActionMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAXAAAAUmVzcG9uZEFjdGlvbk1ldGhvZFR5" +
           "cGUBAQ8AAC8BAQ8ADwAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEQAAAu" +
           "AEQQAAAAlgIAAAABACoBARsAAAAMAAAAQWN0aW9uTm9kZUlkABH/////AAAAAAABACoBARcAAAAIAAAA" +
           "UmVzcG9uc2UADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQERAAAuAEQRAAAAlgEAAAABACoBASEAAAASAAAAUmVzcG9uZEFjdGlvbkVycm9yAAb/////" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public RespondActionMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            NodeId actionNodeId = (NodeId)inputArguments[0];
            string response = (string)inputArguments[1];

            int respondActionError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    actionNodeId,
                    response,
                    ref respondActionError);
            }

            outputArguments[0] = respondActionError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult RespondActionMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId actionNodeId,
        string response,
        ref int respondActionError);
    #endif
    #endregion

    #region AbortActionMethodState Class
    #if (!OPCUA_EXCLUDE_AbortActionMethodState)
    /// <summary>
    /// Stores an instance of the AbortActionMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AbortActionMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AbortActionMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new AbortActionMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAVAAAAQWJvcnRBY3Rpb25NZXRob2RUeXBl" +
           "AQESAAAvAQESABIAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEwAALgBE" +
           "EwAAAJYBAAAAAQAqAQEbAAAADAAAAEFjdGlvbk5vZGVJZAAR/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARQAAC4ARBQAAACWAQAAAAEAKgEBHwAAABAA" +
           "AABBYm9ydEFjdGlvbkVycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public AbortActionMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            NodeId actionNodeId = (NodeId)inputArguments[0];

            int abortActionError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    actionNodeId,
                    ref abortActionError);
            }

            outputArguments[0] = abortActionError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult AbortActionMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        NodeId actionNodeId,
        ref int abortActionError);
    #endif
    #endregion

    #region ActionServiceState Class
    #if (!OPCUA_EXCLUDE_ActionServiceState)
    /// <summary>
    /// Stores an instance of the ActionServiceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActionServiceState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ActionServiceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi5.ObjectTypes.ActionServiceType, Opc.Ua.Fdi5.Namespaces.OpcUaFdi5, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAZAAAAQWN0aW9uU2VydmljZVR5cGVJbnN0" +
           "YW5jZQEBFQABARUA/////wMAAAAEYYIKBAAAAAEADAAAAEludm9rZUFjdGlvbgEBFgAALwEBFgAWAAAA" +
           "AQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBARcAAC4ARBcAAACWAgAAAAEAKgEB" +
           "GQAAAAoAAABBY3Rpb25OYW1lAAz/////AAAAAAABACoBAR4AAAAPAAAATWV0aG9kQXJndW1lbnRzAAz/" +
           "////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBGAAA" +
           "LgBEGAAAAJYCAAAAAQAqAQEbAAAADAAAAEFjdGlvbk5vZGVJZAAR/////wAAAAAAAQAqAQEgAAAAEQAA" +
           "AEludm9rZUFjdGlvbkVycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEADQAA" +
           "AFJlc3BvbmRBY3Rpb24BARkAAC8BARkAGQAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQEaAAAuAEQaAAAAlgIAAAABACoBARsAAAAMAAAAQWN0aW9uTm9kZUlkABH/////AAAAAAAB" +
           "ACoBARcAAAAIAAAAUmVzcG9uc2UADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQEbAAAuAEQbAAAAlgEAAAABACoBASEAAAASAAAAUmVzcG9uZEFjdGlv" +
           "bkVycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAAEYYIKBAAAAAEACwAAAEFib3J0QWN0aW9u" +
           "AQEcAAAvAQEcABwAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBHQAALgBE" +
           "HQAAAJYBAAAAAQAqAQEbAAAADAAAAEFjdGlvbk5vZGVJZAAR/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAR4AAC4ARB4AAACWAQAAAAEAKgEBHwAAABAA" +
           "AABBYm9ydEFjdGlvbkVycm9yAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the InvokeActionMethodType Method.
        /// </summary>
        public InvokeActionMethodState InvokeAction
        {
            get
            {
                return m_invokeActionMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_invokeActionMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_invokeActionMethod = value;
            }
        }

        /// <summary>
        /// A description for the RespondActionMethodType Method.
        /// </summary>
        public RespondActionMethodState RespondAction
        {
            get
            {
                return m_respondActionMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_respondActionMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_respondActionMethod = value;
            }
        }

        /// <summary>
        /// A description for the AbortActionMethodType Method.
        /// </summary>
        public AbortActionMethodState AbortAction
        {
            get
            {
                return m_abortActionMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_abortActionMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_abortActionMethod = value;
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
            if (m_invokeActionMethod != null)
            {
                children.Add(m_invokeActionMethod);
            }

            if (m_respondActionMethod != null)
            {
                children.Add(m_respondActionMethod);
            }

            if (m_abortActionMethod != null)
            {
                children.Add(m_abortActionMethod);
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
                case Opc.Ua.Fdi5.BrowseNames.InvokeAction:
                {
                    if (createOrReplace)
                    {
                        if (InvokeAction == null)
                        {
                            if (replacement == null)
                            {
                                InvokeAction = new InvokeActionMethodState(this);
                            }
                            else
                            {
                                InvokeAction = (InvokeActionMethodState)replacement;
                            }
                        }
                    }

                    instance = InvokeAction;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.RespondAction:
                {
                    if (createOrReplace)
                    {
                        if (RespondAction == null)
                        {
                            if (replacement == null)
                            {
                                RespondAction = new RespondActionMethodState(this);
                            }
                            else
                            {
                                RespondAction = (RespondActionMethodState)replacement;
                            }
                        }
                    }

                    instance = RespondAction;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.AbortAction:
                {
                    if (createOrReplace)
                    {
                        if (AbortAction == null)
                        {
                            if (replacement == null)
                            {
                                AbortAction = new AbortActionMethodState(this);
                            }
                            else
                            {
                                AbortAction = (AbortActionMethodState)replacement;
                            }
                        }
                    }

                    instance = AbortAction;
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
        private InvokeActionMethodState m_invokeActionMethod;
        private RespondActionMethodState m_respondActionMethod;
        private AbortActionMethodState m_abortActionMethod;
        #endregion
    }
    #endif
    #endregion

    #region GetEditContextMethodState Class
    #if (!OPCUA_EXCLUDE_GetEditContextMethodState)
    /// <summary>
    /// Stores an instance of the GetEditContextMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetEditContextMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GetEditContextMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GetEditContextMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAYAAAAR2V0RWRpdENvbnRleHRNZXRob2RU" +
           "eXBlAQEiAAAvAQEiACIAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBIwAA" +
           "LgBEIwAAAJYCAAAAAQAqAQEXAAAACAAAAFBhcmVudElkAAz/////AAAAAAABACoBASEAAAAQAAAAVGFy" +
           "Z2V0V2luZG93TW9kZQEBwgD/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBJAAALgBEJAAAAJYCAAAAAQAqAQEcAAAADQAAAEVkaXRDb250ZXh0SWQADP//" +
           "//8AAAAAAAEAKgEBIwAAABQAAABHZXRFZGl0Q29udGV4dFN0YXR1cwAG/////wAAAAAAAQAoAQEAAAAB" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GetEditContextMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string parentId = (string)inputArguments[0];
            WindowModeType targetWindowMode = (WindowModeType)inputArguments[1];

            string editContextId = (string)outputArguments[0];
            int getEditContextStatus = (int)outputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    parentId,
                    targetWindowMode,
                    ref editContextId,
                    ref getEditContextStatus);
            }

            outputArguments[0] = editContextId;
            outputArguments[1] = getEditContextStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult GetEditContextMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string parentId,
        WindowModeType targetWindowMode,
        ref string editContextId,
        ref int getEditContextStatus);
    #endif
    #endregion

    #region RegisterNodesMethodState Class
    #if (!OPCUA_EXCLUDE_RegisterNodesMethodState)
    /// <summary>
    /// Stores an instance of the RegisterNodesMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RegisterNodesMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RegisterNodesMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new RegisterNodesMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAXAAAAUmVnaXN0ZXJOb2Rlc01ldGhvZFR5" +
           "cGUBASgAAC8BASgAKAAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEpAAAu" +
           "AEQpAAAAlgIAAAABACoBARwAAAANAAAARWRpdENvbnRleHRJZAAM/////wAAAAAAAQAqAQEgAAAADwAA" +
           "AE5vZGVzVG9SZWdpc3RlcgEBJQABAAAAAAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBKgAALgBEKgAAAJYBAAAAAQAqAQEkAAAAEwAAAFJlZ2lzdGVyTm9kZXNT" +
           "dGF0dXMBAScA/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public RegisterNodesMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string editContextId = (string)inputArguments[0];
            RegistrationParameters[] nodesToRegister = (RegistrationParameters[])ExtensionObject.ToArray(inputArguments[1], typeof(RegistrationParameters));

            RegisterNodesResult registerNodesStatus = (RegisterNodesResult)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    editContextId,
                    nodesToRegister,
                    ref registerNodesStatus);
            }

            outputArguments[0] = registerNodesStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult RegisterNodesMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string editContextId,
        RegistrationParameters[] nodesToRegister,
        ref RegisterNodesResult registerNodesStatus);
    #endif
    #endregion

    #region ApplyMethodState Class
    #if (!OPCUA_EXCLUDE_ApplyMethodState)
    /// <summary>
    /// Stores an instance of the ApplyMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ApplyMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ApplyMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ApplyMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAPAAAAQXBwbHlNZXRob2RUeXBlAQEtAAAv" +
           "AQEtAC0AAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBLgAALgBELgAAAJYB" +
           "AAAAAQAqAQEcAAAADQAAAEVkaXRDb250ZXh0SWQADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEvAAAuAEQvAAAAlgEAAAABACoBARwAAAALAAAAQXBw" +
           "bHlTdGF0dXMBASwA/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ApplyMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string editContextId = (string)inputArguments[0];

            ApplyResult applyStatus = (ApplyResult)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    editContextId,
                    ref applyStatus);
            }

            outputArguments[0] = applyStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ApplyMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string editContextId,
        ref ApplyResult applyStatus);
    #endif
    #endregion

    #region ResetMethodState Class
    #if (!OPCUA_EXCLUDE_ResetMethodState)
    /// <summary>
    /// Stores an instance of the ResetMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResetMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ResetMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ResetMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAPAAAAUmVzZXRNZXRob2RUeXBlAQEwAAAv" +
           "AQEwADAAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBMQAALgBEMQAAAJYB" +
           "AAAAAQAqAQEcAAAADQAAAEVkaXRDb250ZXh0SWQADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEyAAAuAEQyAAAAlgEAAAABACoBARoAAAALAAAAUmVz" +
           "ZXRTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ResetMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string editContextId = (string)inputArguments[0];

            int resetStatus = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    editContextId,
                    ref resetStatus);
            }

            outputArguments[0] = resetStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ResetMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string editContextId,
        ref int resetStatus);
    #endif
    #endregion

    #region DiscardMethodState Class
    #if (!OPCUA_EXCLUDE_DiscardMethodState)
    /// <summary>
    /// Stores an instance of the DiscardMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DiscardMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DiscardMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new DiscardMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQARAAAARGlzY2FyZE1ldGhvZFR5cGUBATMA" +
           "AC8BATMAMwAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE0AAAuAEQ0AAAA" +
           "lgEAAAABACoBARwAAAANAAAARWRpdENvbnRleHRJZAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAA" +
           "FWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATUAAC4ARDUAAACWAQAAAAEAKgEBHAAAAA0AAABE" +
           "aXNjYXJkU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public DiscardMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string editContextId = (string)inputArguments[0];

            int discardStatus = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    editContextId,
                    ref discardStatus);
            }

            outputArguments[0] = discardStatus;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult DiscardMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string editContextId,
        ref int discardStatus);
    #endif
    #endregion

    #region EditContextState Class
    #if (!OPCUA_EXCLUDE_EditContextState)
    /// <summary>
    /// Stores an instance of the EditContextType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EditContextState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EditContextState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi5.ObjectTypes.EditContextType, Opc.Ua.Fdi5.Namespaces.OpcUaFdi5, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAXAAAARWRpdENvbnRleHRUeXBlSW5zdGFu" +
           "Y2UBATYAAQE2AP////8GAAAABGGCCgQAAAABAA4AAABHZXRFZGl0Q29udGV4dAEBNwAALwEBNwA3AAAA" +
           "AQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATgAAC4ARDgAAACWAgAAAAEAKgEB" +
           "FwAAAAgAAABQYXJlbnRJZAAM/////wAAAAAAAQAqAQEhAAAAEAAAAFRhcmdldFdpbmRvd01vZGUBAcIA" +
           "/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATkA" +
           "AC4ARDkAAACWAgAAAAEAKgEBHAAAAA0AAABFZGl0Q29udGV4dElkAAz/////AAAAAAABACoBASMAAAAU" +
           "AAAAR2V0RWRpdENvbnRleHRTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoEAAAA" +
           "AQARAAAAUmVnaXN0ZXJOb2Rlc0J5SWQBAToAAC8BAToAOgAAAAEB/////wIAAAAVYKkKAgAAAAAADgAA" +
           "AElucHV0QXJndW1lbnRzAQE7AAAuAEQ7AAAAlgIAAAABACoBARwAAAANAAAARWRpdENvbnRleHRJZAAM" +
           "/////wAAAAAAAQAqAQEgAAAADwAAAE5vZGVzVG9SZWdpc3RlcgEBJQABAAAAAAAAAAABACgBAQAAAAEB" +
           "/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBPAAALgBEPAAAAJYBAAAAAQAqAQEk" +
           "AAAAEwAAAFJlZ2lzdGVyTm9kZXNTdGF0dXMBAScA/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGC" +
           "CgQAAAABABsAAABSZWdpc3Rlck5vZGVzQnlSZWxhdGl2ZVBhdGgBAT0AAC8BAT0APQAAAAEB/////wIA" +
           "AAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE+AAAuAEQ+AAAAlgIAAAABACoBARwAAAANAAAA" +
           "RWRpdENvbnRleHRJZAAM/////wAAAAAAAQAqAQEgAAAADwAAAE5vZGVzVG9SZWdpc3RlcgEBJQABAAAA" +
           "AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBPwAALgBE" +
           "PwAAAJYBAAAAAQAqAQEkAAAAEwAAAFJlZ2lzdGVyTm9kZXNTdGF0dXMBAScA/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAABGGCCgQAAAABAAUAAABBcHBseQEBQAAALwEBQABAAAAAAQH/////AgAAABVgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUEAAC4AREEAAACWAQAAAAEAKgEBHAAAAA0AAABFZGl0Q29u" +
           "dGV4dElkAAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBQgAALgBEQgAAAJYBAAAAAQAqAQEcAAAACwAAAEFwcGx5U3RhdHVzAQEsAP////8AAAAAAAEA" +
           "KAEBAAAAAQH/////AAAAAARhggoEAAAAAQAFAAAAUmVzZXQBAUMAAC8BAUMAQwAAAAEB/////wIAAAAV" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFEAAAuAEREAAAAlgEAAAABACoBARwAAAANAAAARWRp" +
           "dENvbnRleHRJZAAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAUUAAC4AREUAAACWAQAAAAEAKgEBGgAAAAsAAABSZXNldFN0YXR1cwAG/////wAAAAAA" +
           "AQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAcAAABEaXNjYXJkAQFGAAAvAQFGAEYAAAABAf////8C" +
           "AAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBRwAALgBERwAAAJYBAAAAAQAqAQEcAAAADQAA" +
           "AEVkaXRDb250ZXh0SWQADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQFIAAAuAERIAAAAlgEAAAABACoBARwAAAANAAAARGlzY2FyZFN0YXR1cwAG////" +
           "/wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the GetEditContextMethodType Method.
        /// </summary>
        public GetEditContextMethodState GetEditContext
        {
            get
            {
                return m_getEditContextMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getEditContextMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getEditContextMethod = value;
            }
        }

        /// <summary>
        /// A description for the RegisterNodesMethodType Method.
        /// </summary>
        public RegisterNodesMethodState RegisterNodesById
        {
            get
            {
                return m_registerNodesByIdMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_registerNodesByIdMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_registerNodesByIdMethod = value;
            }
        }

        /// <summary>
        /// A description for the RegisterNodesMethodType Method.
        /// </summary>
        public RegisterNodesMethodState RegisterNodesByRelativePath
        {
            get
            {
                return m_registerNodesByRelativePathMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_registerNodesByRelativePathMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_registerNodesByRelativePathMethod = value;
            }
        }

        /// <summary>
        /// A description for the ApplyMethodType Method.
        /// </summary>
        public ApplyMethodState Apply
        {
            get
            {
                return m_applyMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_applyMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_applyMethod = value;
            }
        }

        /// <summary>
        /// A description for the ResetMethodType Method.
        /// </summary>
        public ResetMethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }

        /// <summary>
        /// A description for the DiscardMethodType Method.
        /// </summary>
        public DiscardMethodState Discard
        {
            get
            {
                return m_discardMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_discardMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_discardMethod = value;
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
            if (m_getEditContextMethod != null)
            {
                children.Add(m_getEditContextMethod);
            }

            if (m_registerNodesByIdMethod != null)
            {
                children.Add(m_registerNodesByIdMethod);
            }

            if (m_registerNodesByRelativePathMethod != null)
            {
                children.Add(m_registerNodesByRelativePathMethod);
            }

            if (m_applyMethod != null)
            {
                children.Add(m_applyMethod);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            if (m_discardMethod != null)
            {
                children.Add(m_discardMethod);
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
                case Opc.Ua.Fdi5.BrowseNames.GetEditContext:
                {
                    if (createOrReplace)
                    {
                        if (GetEditContext == null)
                        {
                            if (replacement == null)
                            {
                                GetEditContext = new GetEditContextMethodState(this);
                            }
                            else
                            {
                                GetEditContext = (GetEditContextMethodState)replacement;
                            }
                        }
                    }

                    instance = GetEditContext;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.RegisterNodesById:
                {
                    if (createOrReplace)
                    {
                        if (RegisterNodesById == null)
                        {
                            if (replacement == null)
                            {
                                RegisterNodesById = new RegisterNodesMethodState(this);
                            }
                            else
                            {
                                RegisterNodesById = (RegisterNodesMethodState)replacement;
                            }
                        }
                    }

                    instance = RegisterNodesById;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.RegisterNodesByRelativePath:
                {
                    if (createOrReplace)
                    {
                        if (RegisterNodesByRelativePath == null)
                        {
                            if (replacement == null)
                            {
                                RegisterNodesByRelativePath = new RegisterNodesMethodState(this);
                            }
                            else
                            {
                                RegisterNodesByRelativePath = (RegisterNodesMethodState)replacement;
                            }
                        }
                    }

                    instance = RegisterNodesByRelativePath;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.Apply:
                {
                    if (createOrReplace)
                    {
                        if (Apply == null)
                        {
                            if (replacement == null)
                            {
                                Apply = new ApplyMethodState(this);
                            }
                            else
                            {
                                Apply = (ApplyMethodState)replacement;
                            }
                        }
                    }

                    instance = Apply;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new ResetMethodState(this);
                            }
                            else
                            {
                                Reset = (ResetMethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.Discard:
                {
                    if (createOrReplace)
                    {
                        if (Discard == null)
                        {
                            if (replacement == null)
                            {
                                Discard = new DiscardMethodState(this);
                            }
                            else
                            {
                                Discard = (DiscardMethodState)replacement;
                            }
                        }
                    }

                    instance = Discard;
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
        private GetEditContextMethodState m_getEditContextMethod;
        private RegisterNodesMethodState m_registerNodesByIdMethod;
        private RegisterNodesMethodState m_registerNodesByRelativePathMethod;
        private ApplyMethodState m_applyMethod;
        private ResetMethodState m_resetMethod;
        private DiscardMethodState m_discardMethod;
        #endregion
    }
    #endif
    #endregion

    #region InitDirectAccessMethodState Class
    #if (!OPCUA_EXCLUDE_InitDirectAccessMethodState)
    /// <summary>
    /// Stores an instance of the InitDirectAccessMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InitDirectAccessMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public InitDirectAccessMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new InitDirectAccessMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAaAAAASW5pdERpcmVjdEFjY2Vzc01ldGhv" +
           "ZFR5cGUBAUkAAC8BAUkASQAAAAEB/////wIAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFK" +
           "AAAuAERKAAAAlgEAAAABACoBARYAAAAHAAAAQ29udGV4dAAM/////wAAAAAAAQAoAQEAAAABAf////8A" +
           "AAAAFWCpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUsAAC4AREsAAACWAQAAAAEAKgEBJAAAABUA" +
           "AABJbml0RGlyZWN0QWNjZXNzRXJyb3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public InitDirectAccessMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string context = (string)inputArguments[0];

            int initDirectAccessError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    context,
                    ref initDirectAccessError);
            }

            outputArguments[0] = initDirectAccessError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult InitDirectAccessMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string context,
        ref int initDirectAccessError);
    #endif
    #endregion

    #region TransferMethodState Class
    #if (!OPCUA_EXCLUDE_TransferMethodState)
    /// <summary>
    /// Stores an instance of the TransferMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TransferMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TransferMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new TransferMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQASAAAAVHJhbnNmZXJNZXRob2RUeXBlAQFM" +
           "AAAvAQFMAEwAAAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBTQAALgBETQAA" +
           "AJYCAAAAAQAqAQEXAAAACAAAAFNlbmREYXRhAAz/////AAAAAAABACoBARoAAAALAAAAUmVjZWl2ZURh" +
           "dGEADP////8AAAAAAAEAKAEBAAAAAQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQFOAAAuAEROAAAAlgEAAAABACoBARwAAAANAAAAVHJhbnNmZXJFcnJvcgAG/////wAAAAAAAQAoAQEA" +
           "AAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public TransferMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string sendData = (string)inputArguments[0];
            string receiveData = (string)inputArguments[1];

            int transferError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    sendData,
                    receiveData,
                    ref transferError);
            }

            outputArguments[0] = transferError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult TransferMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string sendData,
        string receiveData,
        ref int transferError);
    #endif
    #endregion

    #region EndDirectAccessMethodState Class
    #if (!OPCUA_EXCLUDE_EndDirectAccessMethodState)
    /// <summary>
    /// Stores an instance of the EndDirectAccessMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EndDirectAccessMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EndDirectAccessMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new EndDirectAccessMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAZAAAARW5kRGlyZWN0QWNjZXNzTWV0aG9k" +
           "VHlwZQEBTwAALwEBTwBPAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVAA" +
           "AC4ARFAAAACWAQAAAAEAKgEBHgAAAA8AAABJbnZhbGlkYXRlQ2FjaGUAAf////8AAAAAAAEAKAEBAAAA" +
           "AQH/////AAAAABVgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFRAAAuAERRAAAAlgEAAAABACoB" +
           "ASMAAAAUAAAARW5kRGlyZWN0QWNjZXNzRXJyb3IABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public EndDirectAccessMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            bool invalidateCache = (bool)inputArguments[0];

            int endDirectAccessError = (int)outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    invalidateCache,
                    ref endDirectAccessError);
            }

            outputArguments[0] = endDirectAccessError;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult EndDirectAccessMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        bool invalidateCache,
        ref int endDirectAccessError);
    #endif
    #endregion

    #region DirectDeviceAccessState Class
    #if (!OPCUA_EXCLUDE_DirectDeviceAccessState)
    /// <summary>
    /// Stores an instance of the DirectDeviceAccessType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DirectDeviceAccessState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DirectDeviceAccessState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Fdi5.ObjectTypes.DirectDeviceAccessType, Opc.Ua.Fdi5.Namespaces.OpcUaFdi5, namespaceUris);
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
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAeAAAARGlyZWN0RGV2aWNlQWNjZXNzVHlw" +
           "ZUluc3RhbmNlAQFSAAEBUgD/////AwAAAARhggoEAAAAAQAQAAAASW5pdERpcmVjdEFjY2VzcwEBUwAA" +
           "LwEBUwBTAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVQAAC4ARFQAAACW" +
           "AQAAAAEAKgEBFgAAAAcAAABDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVQAALgBEVQAAAJYBAAAAAQAqAQEkAAAAFQAAAEluaXREaXJl" +
           "Y3RBY2Nlc3NFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAABGGCCgQAAAABAAgAAABUcmFu" +
           "c2ZlcgEBVgAALwEBVgBWAAAAAQH/////AgAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVcA" +
           "AC4ARFcAAACWAgAAAAEAKgEBFwAAAAgAAABTZW5kRGF0YQAM/////wAAAAAAAQAqAQEaAAAACwAAAFJl" +
           "Y2VpdmVEYXRhAAz/////AAAAAAABACgBAQAAAAEB/////wAAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBWAAALgBEWAAAAJYBAAAAAQAqAQEcAAAADQAAAFRyYW5zZmVyRXJyb3IABv////8AAAAA" +
           "AAEAKAEBAAAAAQH/////AAAAAARhggoEAAAAAQAPAAAARW5kRGlyZWN0QWNjZXNzAQFZAAAvAQFZAFkA" +
           "AAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBWgAALgBEWgAAAJYBAAAAAQAq" +
           "AQEeAAAADwAAAEludmFsaWRhdGVDYWNoZQAB/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVsAAC4ARFsAAACWAQAAAAEAKgEBIwAAABQAAABFbmREaXJl" +
           "Y3RBY2Nlc3NFcnJvcgAG/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the InitDirectAccessMethodType Method.
        /// </summary>
        public InitDirectAccessMethodState InitDirectAccess
        {
            get
            {
                return m_initDirectAccessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_initDirectAccessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_initDirectAccessMethod = value;
            }
        }

        /// <summary>
        /// A description for the TransferMethodType Method.
        /// </summary>
        public TransferMethodState Transfer
        {
            get
            {
                return m_transferMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_transferMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transferMethod = value;
            }
        }

        /// <summary>
        /// A description for the EndDirectAccessMethodType Method.
        /// </summary>
        public EndDirectAccessMethodState EndDirectAccess
        {
            get
            {
                return m_endDirectAccessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_endDirectAccessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_endDirectAccessMethod = value;
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
            if (m_initDirectAccessMethod != null)
            {
                children.Add(m_initDirectAccessMethod);
            }

            if (m_transferMethod != null)
            {
                children.Add(m_transferMethod);
            }

            if (m_endDirectAccessMethod != null)
            {
                children.Add(m_endDirectAccessMethod);
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
                case Opc.Ua.Fdi5.BrowseNames.InitDirectAccess:
                {
                    if (createOrReplace)
                    {
                        if (InitDirectAccess == null)
                        {
                            if (replacement == null)
                            {
                                InitDirectAccess = new InitDirectAccessMethodState(this);
                            }
                            else
                            {
                                InitDirectAccess = (InitDirectAccessMethodState)replacement;
                            }
                        }
                    }

                    instance = InitDirectAccess;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.Transfer:
                {
                    if (createOrReplace)
                    {
                        if (Transfer == null)
                        {
                            if (replacement == null)
                            {
                                Transfer = new TransferMethodState(this);
                            }
                            else
                            {
                                Transfer = (TransferMethodState)replacement;
                            }
                        }
                    }

                    instance = Transfer;
                    break;
                }

                case Opc.Ua.Fdi5.BrowseNames.EndDirectAccess:
                {
                    if (createOrReplace)
                    {
                        if (EndDirectAccess == null)
                        {
                            if (replacement == null)
                            {
                                EndDirectAccess = new EndDirectAccessMethodState(this);
                            }
                            else
                            {
                                EndDirectAccess = (EndDirectAccessMethodState)replacement;
                            }
                        }
                    }

                    instance = EndDirectAccess;
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
        private InitDirectAccessMethodState m_initDirectAccessMethod;
        private TransferMethodState m_transferMethod;
        private EndDirectAccessMethodState m_endDirectAccessMethod;
        #endregion
    }
    #endif
    #endregion

    #region LogAuditTrailMessageMethodState Class
    #if (!OPCUA_EXCLUDE_LogAuditTrailMessageMethodState)
    /// <summary>
    /// Stores an instance of the LogAuditTrailMessage Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LogAuditTrailMessageMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LogAuditTrailMessageMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new LogAuditTrailMessageMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACYAAABodHRwOi8vZmRpLWNvb3BlcmF0aW9uLmNvbS9PUENVQS9GREk1Lx8AAABodHRwOi8vb3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAUAAAATG9nQXVkaXRUcmFpbE1lc3NhZ2UB" +
           "AVwAAC8BAVwAXAAAAAEB/////wEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFdAAAuAERd" +
           "AAAAlgEAAAABACoBARYAAAAHAAAATWVzc2FnZQAM/////wAAAAAAAQAoAQEAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public LogAuditTrailMessageMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="objectId">The id of the object.</param>
        /// <param name="inputArguments">The input arguments which have been already validated.</param>
        /// <param name="outputArguments">The output arguments which have initialized with thier default values.</param>
        /// <returns></returns>
        protected override ServiceResult Call(
            ISystemContext context,
            NodeId objectId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(context, objectId, inputArguments, outputArguments);
            }

            ServiceResult result = null;

            string message = (string)inputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    context,
                    this,
                    objectId,
                    message);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult LogAuditTrailMessageMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string message);
    #endif
    #endregion
}
