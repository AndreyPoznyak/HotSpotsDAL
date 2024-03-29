﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace HotSpotsConnectedLayer
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class HotSpotsDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new HotSpotsDBEntities object using the connection string found in the 'HotSpotsDBEntities' section of the application configuration file.
        /// </summary>
        public HotSpotsDBEntities() : base("name=HotSpotsDBEntities", "HotSpotsDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HotSpotsDBEntities object.
        /// </summary>
        public HotSpotsDBEntities(string connectionString) : base(connectionString, "HotSpotsDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HotSpotsDBEntities object.
        /// </summary>
        public HotSpotsDBEntities(EntityConnection connection) : base(connection, "HotSpotsDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
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
        public ObjectSet<HotSpot> HotSpot
        {
            get
            {
                if ((_HotSpot == null))
                {
                    _HotSpot = base.CreateObjectSet<HotSpot>("HotSpot");
                }
                return _HotSpot;
            }
        }
        private ObjectSet<HotSpot> _HotSpot;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the HotSpot EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHotSpot(HotSpot hotSpot)
        {
            base.AddObject("HotSpot", hotSpot);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HotSpotsDBModel", Name="HotSpot")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class HotSpot : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new HotSpot object.
        /// </summary>
        /// <param name="bssid">Initial value of the bssid property.</param>
        public static HotSpot CreateHotSpot(global::System.String bssid)
        {
            HotSpot hotSpot = new HotSpot();
            hotSpot.bssid = bssid;
            return hotSpot;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String bssid
        {
            get
            {
                return _bssid;
            }
            set
            {
                if (_bssid != value)
                {
                    OnbssidChanging(value);
                    ReportPropertyChanging("bssid");
                    _bssid = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("bssid");
                    OnbssidChanged();
                }
            }
        }
        private global::System.String _bssid;
        partial void OnbssidChanging(global::System.String value);
        partial void OnbssidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> longitude1
        {
            get
            {
                return _longitude1;
            }
            set
            {
                Onlongitude1Changing(value);
                ReportPropertyChanging("longitude1");
                _longitude1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("longitude1");
                Onlongitude1Changed();
            }
        }
        private Nullable<global::System.Double> _longitude1;
        partial void Onlongitude1Changing(Nullable<global::System.Double> value);
        partial void Onlongitude1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> longitude2
        {
            get
            {
                return _longitude2;
            }
            set
            {
                Onlongitude2Changing(value);
                ReportPropertyChanging("longitude2");
                _longitude2 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("longitude2");
                Onlongitude2Changed();
            }
        }
        private Nullable<global::System.Double> _longitude2;
        partial void Onlongitude2Changing(Nullable<global::System.Double> value);
        partial void Onlongitude2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> longitude3
        {
            get
            {
                return _longitude3;
            }
            set
            {
                Onlongitude3Changing(value);
                ReportPropertyChanging("longitude3");
                _longitude3 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("longitude3");
                Onlongitude3Changed();
            }
        }
        private Nullable<global::System.Double> _longitude3;
        partial void Onlongitude3Changing(Nullable<global::System.Double> value);
        partial void Onlongitude3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> latitude1
        {
            get
            {
                return _latitude1;
            }
            set
            {
                Onlatitude1Changing(value);
                ReportPropertyChanging("latitude1");
                _latitude1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("latitude1");
                Onlatitude1Changed();
            }
        }
        private Nullable<global::System.Double> _latitude1;
        partial void Onlatitude1Changing(Nullable<global::System.Double> value);
        partial void Onlatitude1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> latitude2
        {
            get
            {
                return _latitude2;
            }
            set
            {
                Onlatitude2Changing(value);
                ReportPropertyChanging("latitude2");
                _latitude2 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("latitude2");
                Onlatitude2Changed();
            }
        }
        private Nullable<global::System.Double> _latitude2;
        partial void Onlatitude2Changing(Nullable<global::System.Double> value);
        partial void Onlatitude2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> latitude3
        {
            get
            {
                return _latitude3;
            }
            set
            {
                Onlatitude3Changing(value);
                ReportPropertyChanging("latitude3");
                _latitude3 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("latitude3");
                Onlatitude3Changed();
            }
        }
        private Nullable<global::System.Double> _latitude3;
        partial void Onlatitude3Changing(Nullable<global::System.Double> value);
        partial void Onlatitude3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                OnlongitudeChanging(value);
                ReportPropertyChanging("longitude");
                _longitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("longitude");
                OnlongitudeChanged();
            }
        }
        private Nullable<global::System.Double> _longitude;
        partial void OnlongitudeChanging(Nullable<global::System.Double> value);
        partial void OnlongitudeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                OnlatitudeChanging(value);
                ReportPropertyChanging("latitude");
                _latitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("latitude");
                OnlatitudeChanged();
            }
        }
        private Nullable<global::System.Double> _latitude;
        partial void OnlatitudeChanging(Nullable<global::System.Double> value);
        partial void OnlatitudeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> strength1
        {
            get
            {
                return _strength1;
            }
            set
            {
                Onstrength1Changing(value);
                ReportPropertyChanging("strength1");
                _strength1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("strength1");
                Onstrength1Changed();
            }
        }
        private Nullable<global::System.Int32> _strength1;
        partial void Onstrength1Changing(Nullable<global::System.Int32> value);
        partial void Onstrength1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> strenght2
        {
            get
            {
                return _strenght2;
            }
            set
            {
                Onstrenght2Changing(value);
                ReportPropertyChanging("strenght2");
                _strenght2 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("strenght2");
                Onstrenght2Changed();
            }
        }
        private Nullable<global::System.Int32> _strenght2;
        partial void Onstrenght2Changing(Nullable<global::System.Int32> value);
        partial void Onstrenght2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> strength3
        {
            get
            {
                return _strength3;
            }
            set
            {
                Onstrength3Changing(value);
                ReportPropertyChanging("strength3");
                _strength3 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("strength3");
                Onstrength3Changed();
            }
        }
        private Nullable<global::System.Int32> _strength3;
        partial void Onstrength3Changing(Nullable<global::System.Int32> value);
        partial void Onstrength3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String password
        {
            get
            {
                return _password;
            }
            set
            {
                OnpasswordChanging(value);
                ReportPropertyChanging("password");
                _password = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("password");
                OnpasswordChanged();
            }
        }
        private global::System.String _password;
        partial void OnpasswordChanging(global::System.String value);
        partial void OnpasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String information
        {
            get
            {
                return _information;
            }
            set
            {
                OninformationChanging(value);
                ReportPropertyChanging("information");
                _information = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("information");
                OninformationChanged();
            }
        }
        private global::System.String _information;
        partial void OninformationChanging(global::System.String value);
        partial void OninformationChanged();

        #endregion
    
    }

    #endregion
    
}
