﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.ClientGenerated.IClientApplicationFactory))]
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class ApplicationFactory
        : global::Microsoft.LightSwitch.ClientGenerated.Implementation.ClientApplicationFactory
    {
        protected override global::Microsoft.LightSwitch.Client.IClientApplication CreateApplication(global::Microsoft.LightSwitch.Model.IApplicationDefinition applicationDefinition)
        {
            return new global::LightSwitchApplication.Application(applicationDefinition);
        }
    }

    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.IModuleFactory))]
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::Microsoft.LightSwitch.Framework.Base.ModuleFactory("LightSwitchApplication.Job_System_11_30.DesktopClient")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class ModuleFactory
        : global::Microsoft.LightSwitch.Framework.Base.ModuleFactory
    {
        public override global::Microsoft.LightSwitch.IModule GetModule(global::Microsoft.LightSwitch.Model.IModuleDefinition moduleDefinition)
        {
            return global::LightSwitchApplication.Application.Current;
        }
    }
}
