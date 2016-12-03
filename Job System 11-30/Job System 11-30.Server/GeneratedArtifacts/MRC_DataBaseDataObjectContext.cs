﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace LightSwitchApplication.Implementation
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MRC_DataBaseData : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MRC_DataBaseData object using the connection string found in the 'MRC_DataBaseData' section of the application configuration file.
        /// </summary>
        public MRC_DataBaseData() : base("name=MRC_DataBaseData", "MRC_DataBaseData")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MRC_DataBaseData object.
        /// </summary>
        public MRC_DataBaseData(string connectionString) : base(connectionString, "MRC_DataBaseData")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MRC_DataBaseData object.
        /// </summary>
        public MRC_DataBaseData(EntityConnection connection) : base(connection, "MRC_DataBaseData")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<JobCard> JobCards
        {
            get
            {
                if ((_JobCards == null))
                {
                    _JobCards = base.CreateObjectSet<JobCard>("JobCards");
                }
                return _JobCards;
            }
        }
        private ObjectSet<JobCard> _JobCards;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the JobCards EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToJobCards(JobCard jobCard)
        {
            base.AddObject("JobCards", jobCard);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="JobCard")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class JobCard : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new JobCard object.
        /// </summary>
        /// <param name="jID">Initial value of the JID property.</param>
        public static JobCard CreateJobCard(global::System.Int32 jID)
        {
            JobCard jobCard = new JobCard();
            jobCard.JID = jID;
            return jobCard;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 JID
        {
            get
            {
                return _JID;
            }
            set
            {
                if (_JID != value)
                {
                    OnJIDChanging(value);
                    ReportPropertyChanging("JID");
                    _JID = value;
                    ReportPropertyChanged("JID");
                    OnJIDChanged();
                }
            }
        }
        private global::System.Int32 _JID;
        partial void OnJIDChanging(global::System.Int32 value);
        partial void OnJIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String JobNumber
        {
            get
            {
                return _JobNumber;
            }
            set
            {
                OnJobNumberChanging(value);
                ReportPropertyChanging("JobNumber");
                _JobNumber = value;
                ReportPropertyChanged("JobNumber");
                OnJobNumberChanged();
            }
        }
        private global::System.String _JobNumber;
        partial void OnJobNumberChanging(global::System.String value);
        partial void OnJobNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String JName
        {
            get
            {
                return _JName;
            }
            set
            {
                OnJNameChanging(value);
                ReportPropertyChanging("JName");
                _JName = value;
                ReportPropertyChanged("JName");
                OnJNameChanged();
            }
        }
        private global::System.String _JName;
        partial void OnJNameChanging(global::System.String value);
        partial void OnJNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String BuildingOwner
        {
            get
            {
                return _BuildingOwner;
            }
            set
            {
                OnBuildingOwnerChanging(value);
                ReportPropertyChanging("BuildingOwner");
                _BuildingOwner = value;
                ReportPropertyChanged("BuildingOwner");
                OnBuildingOwnerChanged();
            }
        }
        private global::System.String _BuildingOwner;
        partial void OnBuildingOwnerChanging(global::System.String value);
        partial void OnBuildingOwnerChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String GeneralContractor
        {
            get
            {
                return _GeneralContractor;
            }
            set
            {
                OnGeneralContractorChanging(value);
                ReportPropertyChanging("GeneralContractor");
                _GeneralContractor = value;
                ReportPropertyChanged("GeneralContractor");
                OnGeneralContractorChanged();
            }
        }
        private global::System.String _GeneralContractor;
        partial void OnGeneralContractorChanging(global::System.String value);
        partial void OnGeneralContractorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String JDescription
        {
            get
            {
                return _JDescription;
            }
            set
            {
                OnJDescriptionChanging(value);
                ReportPropertyChanging("JDescription");
                _JDescription = value;
                ReportPropertyChanged("JDescription");
                OnJDescriptionChanged();
            }
        }
        private global::System.String _JDescription;
        partial void OnJDescriptionChanging(global::System.String value);
        partial void OnJDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> JHoursEstmated
        {
            get
            {
                return _JHoursEstmated;
            }
            set
            {
                OnJHoursEstmatedChanging(value);
                ReportPropertyChanging("JHoursEstmated");
                _JHoursEstmated = value;
                ReportPropertyChanged("JHoursEstmated");
                OnJHoursEstmatedChanged();
            }
        }
        private Nullable<global::System.Decimal> _JHoursEstmated;
        partial void OnJHoursEstmatedChanging(Nullable<global::System.Decimal> value);
        partial void OnJHoursEstmatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> JHoursTook
        {
            get
            {
                return _JHoursTook;
            }
            set
            {
                OnJHoursTookChanging(value);
                ReportPropertyChanging("JHoursTook");
                _JHoursTook = value;
                ReportPropertyChanged("JHoursTook");
                OnJHoursTookChanged();
            }
        }
        private Nullable<global::System.Decimal> _JHoursTook;
        partial void OnJHoursTookChanging(Nullable<global::System.Decimal> value);
        partial void OnJHoursTookChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> JPrice
        {
            get
            {
                return _JPrice;
            }
            set
            {
                OnJPriceChanging(value);
                ReportPropertyChanging("JPrice");
                _JPrice = value;
                ReportPropertyChanged("JPrice");
                OnJPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _JPrice;
        partial void OnJPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnJPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> JSquares
        {
            get
            {
                return _JSquares;
            }
            set
            {
                OnJSquaresChanging(value);
                ReportPropertyChanging("JSquares");
                _JSquares = value;
                ReportPropertyChanged("JSquares");
                OnJSquaresChanged();
            }
        }
        private Nullable<global::System.Decimal> _JSquares;
        partial void OnJSquaresChanging(Nullable<global::System.Decimal> value);
        partial void OnJSquaresChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> JDate
        {
            get
            {
                return _JDate;
            }
            set
            {
                OnJDateChanging(value);
                ReportPropertyChanging("JDate");
                _JDate = value;
                ReportPropertyChanged("JDate");
                OnJDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _JDate;
        partial void OnJDateChanging(Nullable<global::System.DateTime> value);
        partial void OnJDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String JWarrenty
        {
            get
            {
                return _JWarrenty;
            }
            set
            {
                OnJWarrentyChanging(value);
                ReportPropertyChanging("JWarrenty");
                _JWarrenty = value;
                ReportPropertyChanged("JWarrenty");
                OnJWarrentyChanged();
            }
        }
        private global::System.String _JWarrenty;
        partial void OnJWarrentyChanging(global::System.String value);
        partial void OnJWarrentyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String WarrantyNumber
        {
            get
            {
                return _WarrantyNumber;
            }
            set
            {
                OnWarrantyNumberChanging(value);
                ReportPropertyChanging("WarrantyNumber");
                _WarrantyNumber = value;
                ReportPropertyChanged("WarrantyNumber");
                OnWarrantyNumberChanged();
            }
        }
        private global::System.String _WarrantyNumber;
        partial void OnWarrantyNumberChanging(global::System.String value);
        partial void OnWarrantyNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> WarrantyStart
        {
            get
            {
                return _WarrantyStart;
            }
            set
            {
                OnWarrantyStartChanging(value);
                ReportPropertyChanging("WarrantyStart");
                _WarrantyStart = value;
                ReportPropertyChanged("WarrantyStart");
                OnWarrantyStartChanged();
            }
        }
        private Nullable<global::System.DateTime> _WarrantyStart;
        partial void OnWarrantyStartChanging(Nullable<global::System.DateTime> value);
        partial void OnWarrantyStartChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> WarrantyEnd
        {
            get
            {
                return _WarrantyEnd;
            }
            set
            {
                OnWarrantyEndChanging(value);
                ReportPropertyChanging("WarrantyEnd");
                _WarrantyEnd = value;
                ReportPropertyChanged("WarrantyEnd");
                OnWarrantyEndChanged();
            }
        }
        private Nullable<global::System.DateTime> _WarrantyEnd;
        partial void OnWarrantyEndChanging(Nullable<global::System.DateTime> value);
        partial void OnWarrantyEndChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address1
        {
            get
            {
                return _Address1;
            }
            set
            {
                OnAddress1Changing(value);
                ReportPropertyChanging("Address1");
                _Address1 = value;
                ReportPropertyChanged("Address1");
                OnAddress1Changed();
            }
        }
        private global::System.String _Address1;
        partial void OnAddress1Changing(global::System.String value);
        partial void OnAddress1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address2
        {
            get
            {
                return _Address2;
            }
            set
            {
                OnAddress2Changing(value);
                ReportPropertyChanging("Address2");
                _Address2 = value;
                ReportPropertyChanged("Address2");
                OnAddress2Changed();
            }
        }
        private global::System.String _Address2;
        partial void OnAddress2Changing(global::System.String value);
        partial void OnAddress2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = value;
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = value;
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Zip
        {
            get
            {
                return _Zip;
            }
            set
            {
                OnZipChanging(value);
                ReportPropertyChanging("Zip");
                _Zip = value;
                ReportPropertyChanged("Zip");
                OnZipChanged();
            }
        }
        private global::System.String _Zip;
        partial void OnZipChanging(global::System.String value);
        partial void OnZipChanged();

        #endregion

    
    }

    #endregion

    
}
