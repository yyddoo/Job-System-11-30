﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Workspace
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class DataWorkspace : global::Microsoft.LightSwitch.Framework.Base.DataWorkspace<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of a DataWorkspace.  Changes can be made to data sources in the new instance independent of changes made to data sources in the default DataWorkspace.
        /// </summary>
        public DataWorkspace() : base()
        {
        }
    
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Gets the MRC_DataBaseData datasource.  This provides members to query and update data in the data source.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.MRC_DataBaseDataService MRC_DataBaseData
        {
            get
            {
                return global::LightSwitchApplication.DataWorkspace.DetailsClass.GetValue(this, global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.MRC_DataBaseData);
            }
        }
        
        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.DataWorkspaceDetails<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.MRC_DataBaseData;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.DataWorkspacePropertySet<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MRC_DataBaseDataService> MRC_DataBaseData
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.MRC_DataBaseData) as global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MRC_DataBaseDataService>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MRC_DataBaseDataService>.Entry
                    MRC_DataBaseData = new global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MRC_DataBaseDataService>.Entry(
                        "MRC_DataBaseData",
                        global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties._MRC_DataBaseData_Stub);
                private static void _MRC_DataBaseData_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.DataWorkspace.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MRC_DataBaseDataService>.Data> c, global::LightSwitchApplication.DataWorkspace.DetailsClass d, object sf)
                {
                    c(d, ref d._MRC_DataBaseData, sf);
                }
                 
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MRC_DataBaseDataService>.Data _MRC_DataBaseData;
            
        }
    
        #endregion
    }
    
    #endregion
    
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the MRC_DataBaseData datasource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MRC_DataBaseData : global::Microsoft.LightSwitch.Framework.Base.DataService<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// This constructor is used for the internal LightSwitch framework. Use DataWorkspace instead.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public MRC_DataBaseData() : base()
        {
        }
    
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Gets the JobCards entity set.  The entity set provides members to access entities of a specific type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.JobCard> JobCards
        {
            get
            {
                return global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.GetValue(this, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.PropertySetProperties.JobCards);
            }
        }
        
        #endregion
    
        #region Queries
    
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s).
        /// </summary>
        /// <param name="JID">
        /// The value of the 'JID' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.JobCard JobCards_Single(global::System.Nullable<int> JID)
        {
            return this.Details.Methods.JobCards_Single.CreateInvocation(JID).Execute();
        }
        
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s) or null if no such entity exists.
        /// </summary>
        /// <param name="JID">
        /// The value of the 'JID' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.JobCard JobCards_SingleOrDefault(global::System.Nullable<int> JID)
        {
            return this.Details.Methods.JobCards_SingleOrDefault.CreateInvocation(JID).Execute();
        }
        
        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.DataServiceDetails<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.PropertySet, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.MethodSet>
        {
    
            static DetailsClass()
            {
                var initializeMethodEntry = global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.MethodSetProperties.JobCards_Single;
                var initializePropertyEntry = global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.PropertySetProperties.JobCards;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet : global::Microsoft.LightSwitch.Details.Framework.Base.DataServiceMethodSet<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass>
            {
    
                public MethodSet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard> JobCards_Single
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.MethodSetProperties.JobCards_Single) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard> JobCards_SingleOrDefault
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.MethodSetProperties.JobCards_SingleOrDefault) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.DataServicePropertySet<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard> JobCards
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.PropertySetProperties.JobCards) as global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class MethodSetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Entry
                    JobCards_Single = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Entry(
                        "JobCards_Single",
                        global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.MethodSetProperties._JobCards_Single_Stub);
                private static void _JobCards_Single_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Data> c, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass d, object sf)
                {
                    c(d, ref d._JobCards_Single, sf);
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Entry
                    JobCards_SingleOrDefault = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Entry(
                        "JobCards_SingleOrDefault",
                        global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.MethodSetProperties._JobCards_SingleOrDefault_Stub);
                private static void _JobCards_SingleOrDefault_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Data> c, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass d, object sf)
                {
                    c(d, ref d._JobCards_SingleOrDefault, sf);
                }
    
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Entry
                    JobCards = new global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Entry(
                        "JobCards",
                        global::LightSwitchApplication.MRC_DataBaseData.DetailsClass.PropertySetProperties._JobCards_Stub);
                private static void _JobCards_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Data> c, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass d, object sf)
                {
                    c(d, ref d._JobCards, sf);
                }
     
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Data _JobCards;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Data _JobCards_Single;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MRC_DataBaseData, global::LightSwitchApplication.MRC_DataBaseData.DetailsClass, global::LightSwitchApplication.JobCard>.Data _JobCards_SingleOrDefault;
            
        }
    
        #endregion
    }
    
    #endregion
    
}
