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
    
    #region JobCard
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/MRC_DataBaseData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class JobCard :
        global::LightSwitchApplication.JobCard.DetailsClass.IImplementation
    {
        partial void OnJIDChanged()
        {
            this.___OnPropertyChanged("JID");
        }
        
        partial void OnJNameChanged()
        {
            this.___OnPropertyChanged("JName");
        }
        
        partial void OnJDescriptionChanged()
        {
            this.___OnPropertyChanged("JDescription");
        }
        
        partial void OnJWarrentyChanged()
        {
            this.___OnPropertyChanged("JWarrenty");
        }
        
        partial void OnJHoursEstmatedChanged()
        {
            this.___OnPropertyChanged("JHoursEstmated");
        }
        
        partial void OnJHoursTookChanged()
        {
            this.___OnPropertyChanged("JHoursTook");
        }
        
        partial void OnJPriceChanged()
        {
            this.___OnPropertyChanged("JPrice");
        }
        
        partial void OnJSquaresChanged()
        {
            this.___OnPropertyChanged("JSquares");
        }
        
        partial void OnJDateChanged()
        {
            this.___OnPropertyChanged("JDate");
        }
        
        partial void OnJobNumberChanged()
        {
            this.___OnPropertyChanged("JobNumber");
        }
        
        partial void OnWarrantyNumberChanged()
        {
            this.___OnPropertyChanged("WarrantyNumber");
        }
        
        partial void OnWarrantyStartChanged()
        {
            this.___OnPropertyChanged("WarrantyStart");
        }
        
        partial void OnWarrantyEndChanged()
        {
            this.___OnPropertyChanged("WarrantyEnd");
        }
        
        partial void OnAddress1Changed()
        {
            this.___OnPropertyChanged("Address1");
        }
        
        partial void OnAddress2Changed()
        {
            this.___OnPropertyChanged("Address2");
        }
        
        partial void OnCityChanged()
        {
            this.___OnPropertyChanged("City");
        }
        
        partial void OnStateChanged()
        {
            this.___OnPropertyChanged("State");
        }
        
        partial void OnZipChanged()
        {
            this.___OnPropertyChanged("Zip");
        }
        
        partial void OnGeneralContractorChanged()
        {
            this.___OnPropertyChanged("GeneralContractor");
        }
        
        partial void OnBuildingOwnerChanged()
        {
            this.___OnPropertyChanged("BuildingOwner");
        }
        
    }
    #endregion
    
    #region MRC_DataBaseData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class MRC_DataBaseData
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.JobCard))
            {
                return new global::LightSwitchApplication.Implementation.JobCard();
            }
            return null;
        }
        
        protected override void InitializeDataServiceContext()
        {
            this.Format.LoadServiceModel = global::LightSwitchApplication.Implementation.MRC_DataBaseData.GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.MRC_DataBaseData))
            {
                return new global::LightSwitchApplication.MRC_DataBaseData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.MRC_DataBaseData))
            {
                return new global::LightSwitchApplication.Implementation.MRC_DataBaseData(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../../MRC_DataBaseData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.JobCard) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.JobCard);
            }
            return null;
        }
    }
}