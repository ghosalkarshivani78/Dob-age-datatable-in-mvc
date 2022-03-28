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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("usercascadModel", "city2_ibfk_1", "states1", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(cascadingprac.Models.states1), "city2", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(cascadingprac.Models.city2), true)]
[assembly: EdmRelationshipAttribute("usercascadModel", "empstate_ibfk_2", "city2", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(cascadingprac.Models.city2), "empstate", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(cascadingprac.Models.empstate), true)]
[assembly: EdmRelationshipAttribute("usercascadModel", "empstate_ibfk_3", "country", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(cascadingprac.Models.country), "empstate", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(cascadingprac.Models.empstate), true)]
[assembly: EdmRelationshipAttribute("usercascadModel", "states1_ibfk_1", "country", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(cascadingprac.Models.country), "states1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(cascadingprac.Models.states1), true)]
[assembly: EdmRelationshipAttribute("usercascadModel", "empstate_ibfk_1", "states1", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(cascadingprac.Models.states1), "empstate", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(cascadingprac.Models.empstate), true)]

#endregion

namespace cascadingprac.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class usercascadEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new usercascadEntities1 object using the connection string found in the 'usercascadEntities1' section of the application configuration file.
        /// </summary>
        public usercascadEntities1() : base("name=usercascadEntities1", "usercascadEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new usercascadEntities1 object.
        /// </summary>
        public usercascadEntities1(string connectionString) : base(connectionString, "usercascadEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new usercascadEntities1 object.
        /// </summary>
        public usercascadEntities1(EntityConnection connection) : base(connection, "usercascadEntities1")
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
        public ObjectSet<city2> city2
        {
            get
            {
                if ((_city2 == null))
                {
                    _city2 = base.CreateObjectSet<city2>("city2");
                }
                return _city2;
            }
        }
        private ObjectSet<city2> _city2;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<country> countries
        {
            get
            {
                if ((_countries == null))
                {
                    _countries = base.CreateObjectSet<country>("countries");
                }
                return _countries;
            }
        }
        private ObjectSet<country> _countries;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<empstate> empstates
        {
            get
            {
                if ((_empstates == null))
                {
                    _empstates = base.CreateObjectSet<empstate>("empstates");
                }
                return _empstates;
            }
        }
        private ObjectSet<empstate> _empstates;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<states1> states1
        {
            get
            {
                if ((_states1 == null))
                {
                    _states1 = base.CreateObjectSet<states1>("states1");
                }
                return _states1;
            }
        }
        private ObjectSet<states1> _states1;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the city2 EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocity2(city2 city2)
        {
            base.AddObject("city2", city2);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the countries EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocountries(country country)
        {
            base.AddObject("countries", country);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the empstates EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToempstates(empstate empstate)
        {
            base.AddObject("empstates", empstate);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the states1 EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTostates1(states1 states1)
        {
            base.AddObject("states1", states1);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="usercascadModel", Name="city2")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class city2 : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new city2 object.
        /// </summary>
        /// <param name="cityid">Initial value of the cityid property.</param>
        /// <param name="cityname">Initial value of the cityname property.</param>
        /// <param name="stateid">Initial value of the stateid property.</param>
        public static city2 Createcity2(global::System.Int32 cityid, global::System.String cityname, global::System.Int32 stateid)
        {
            city2 city2 = new city2();
            city2.cityid = cityid;
            city2.cityname = cityname;
            city2.stateid = stateid;
            return city2;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cityid
        {
            get
            {
                return _cityid;
            }
            set
            {
                if (_cityid != value)
                {
                    OncityidChanging(value);
                    ReportPropertyChanging("cityid");
                    _cityid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("cityid");
                    OncityidChanged();
                }
            }
        }
        private global::System.Int32 _cityid;
        partial void OncityidChanging(global::System.Int32 value);
        partial void OncityidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String cityname
        {
            get
            {
                return _cityname;
            }
            set
            {
                OncitynameChanging(value);
                ReportPropertyChanging("cityname");
                _cityname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("cityname");
                OncitynameChanged();
            }
        }
        private global::System.String _cityname;
        partial void OncitynameChanging(global::System.String value);
        partial void OncitynameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 stateid
        {
            get
            {
                return _stateid;
            }
            set
            {
                OnstateidChanging(value);
                ReportPropertyChanging("stateid");
                _stateid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("stateid");
                OnstateidChanged();
            }
        }
        private global::System.Int32 _stateid;
        partial void OnstateidChanging(global::System.Int32 value);
        partial void OnstateidChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "city2_ibfk_1", "states1")]
        public states1 states1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<states1>("usercascadModel.city2_ibfk_1", "states1").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<states1>("usercascadModel.city2_ibfk_1", "states1").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<states1> states1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<states1>("usercascadModel.city2_ibfk_1", "states1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<states1>("usercascadModel.city2_ibfk_1", "states1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "empstate_ibfk_2", "empstate")]
        public EntityCollection<empstate> empstates
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<empstate>("usercascadModel.empstate_ibfk_2", "empstate");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<empstate>("usercascadModel.empstate_ibfk_2", "empstate", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="usercascadModel", Name="country")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class country : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new country object.
        /// </summary>
        /// <param name="countryid">Initial value of the countryid property.</param>
        /// <param name="countryname">Initial value of the countryname property.</param>
        public static country Createcountry(global::System.Int32 countryid, global::System.String countryname)
        {
            country country = new country();
            country.countryid = countryid;
            country.countryname = countryname;
            return country;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 countryid
        {
            get
            {
                return _countryid;
            }
            set
            {
                if (_countryid != value)
                {
                    OncountryidChanging(value);
                    ReportPropertyChanging("countryid");
                    _countryid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("countryid");
                    OncountryidChanged();
                }
            }
        }
        private global::System.Int32 _countryid;
        partial void OncountryidChanging(global::System.Int32 value);
        partial void OncountryidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String countryname
        {
            get
            {
                return _countryname;
            }
            set
            {
                OncountrynameChanging(value);
                ReportPropertyChanging("countryname");
                _countryname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("countryname");
                OncountrynameChanged();
            }
        }
        private global::System.String _countryname;
        partial void OncountrynameChanging(global::System.String value);
        partial void OncountrynameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "empstate_ibfk_3", "empstate")]
        public EntityCollection<empstate> empstates
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<empstate>("usercascadModel.empstate_ibfk_3", "empstate");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<empstate>("usercascadModel.empstate_ibfk_3", "empstate", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "states1_ibfk_1", "states1")]
        public EntityCollection<states1> states1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<states1>("usercascadModel.states1_ibfk_1", "states1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<states1>("usercascadModel.states1_ibfk_1", "states1", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="usercascadModel", Name="empstate")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class empstate : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new empstate object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="firstname">Initial value of the firstname property.</param>
        /// <param name="lastname">Initial value of the lastname property.</param>
        /// <param name="email">Initial value of the email property.</param>
        /// <param name="address">Initial value of the address property.</param>
        /// <param name="countryid">Initial value of the countryid property.</param>
        /// <param name="stateid">Initial value of the stateid property.</param>
        /// <param name="cityid">Initial value of the cityid property.</param>
        /// <param name="number">Initial value of the number property.</param>
        public static empstate Createempstate(global::System.Int32 id, global::System.String firstname, global::System.String lastname, global::System.String email, global::System.String address, global::System.Int32 countryid, global::System.Int32 stateid, global::System.Int32 cityid, global::System.String number)
        {
            empstate empstate = new empstate();
            empstate.id = id;
            empstate.firstname = firstname;
            empstate.lastname = lastname;
            empstate.email = email;
            empstate.address = address;
            empstate.countryid = countryid;
            empstate.stateid = stateid;
            empstate.cityid = cityid;
            empstate.number = number;
            return empstate;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                OnfirstnameChanging(value);
                ReportPropertyChanging("firstname");
                _firstname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("firstname");
                OnfirstnameChanged();
            }
        }
        private global::System.String _firstname;
        partial void OnfirstnameChanging(global::System.String value);
        partial void OnfirstnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                OnlastnameChanging(value);
                ReportPropertyChanging("lastname");
                _lastname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("lastname");
                OnlastnameChanged();
            }
        }
        private global::System.String _lastname;
        partial void OnlastnameChanging(global::System.String value);
        partial void OnlastnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                OnaddressChanging(value);
                ReportPropertyChanging("address");
                _address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("address");
                OnaddressChanged();
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 countryid
        {
            get
            {
                return _countryid;
            }
            set
            {
                OncountryidChanging(value);
                ReportPropertyChanging("countryid");
                _countryid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("countryid");
                OncountryidChanged();
            }
        }
        private global::System.Int32 _countryid;
        partial void OncountryidChanging(global::System.Int32 value);
        partial void OncountryidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 stateid
        {
            get
            {
                return _stateid;
            }
            set
            {
                OnstateidChanging(value);
                ReportPropertyChanging("stateid");
                _stateid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("stateid");
                OnstateidChanged();
            }
        }
        private global::System.Int32 _stateid;
        partial void OnstateidChanging(global::System.Int32 value);
        partial void OnstateidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cityid
        {
            get
            {
                return _cityid;
            }
            set
            {
                OncityidChanging(value);
                ReportPropertyChanging("cityid");
                _cityid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cityid");
                OncityidChanged();
            }
        }
        private global::System.Int32 _cityid;
        partial void OncityidChanging(global::System.Int32 value);
        partial void OncityidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String number
        {
            get
            {
                return _number;
            }
            set
            {
                OnnumberChanging(value);
                ReportPropertyChanging("number");
                _number = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("number");
                OnnumberChanged();
            }
        }
        private global::System.String _number;
        partial void OnnumberChanging(global::System.String value);
        partial void OnnumberChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "empstate_ibfk_2", "city2")]
        public city2 city2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<city2>("usercascadModel.empstate_ibfk_2", "city2").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<city2>("usercascadModel.empstate_ibfk_2", "city2").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<city2> city2Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<city2>("usercascadModel.empstate_ibfk_2", "city2");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<city2>("usercascadModel.empstate_ibfk_2", "city2", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "empstate_ibfk_3", "country")]
        public country country
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("usercascadModel.empstate_ibfk_3", "country").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("usercascadModel.empstate_ibfk_3", "country").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<country> countryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("usercascadModel.empstate_ibfk_3", "country");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<country>("usercascadModel.empstate_ibfk_3", "country", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "empstate_ibfk_1", "states1")]
        public states1 states1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<states1>("usercascadModel.empstate_ibfk_1", "states1").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<states1>("usercascadModel.empstate_ibfk_1", "states1").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<states1> states1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<states1>("usercascadModel.empstate_ibfk_1", "states1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<states1>("usercascadModel.empstate_ibfk_1", "states1", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="usercascadModel", Name="states1")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class states1 : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new states1 object.
        /// </summary>
        /// <param name="stateid">Initial value of the stateid property.</param>
        /// <param name="statename">Initial value of the statename property.</param>
        /// <param name="countryid">Initial value of the countryid property.</param>
        public static states1 Createstates1(global::System.Int32 stateid, global::System.String statename, global::System.Int32 countryid)
        {
            states1 states1 = new states1();
            states1.stateid = stateid;
            states1.statename = statename;
            states1.countryid = countryid;
            return states1;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 stateid
        {
            get
            {
                return _stateid;
            }
            set
            {
                if (_stateid != value)
                {
                    OnstateidChanging(value);
                    ReportPropertyChanging("stateid");
                    _stateid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("stateid");
                    OnstateidChanged();
                }
            }
        }
        private global::System.Int32 _stateid;
        partial void OnstateidChanging(global::System.Int32 value);
        partial void OnstateidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String statename
        {
            get
            {
                return _statename;
            }
            set
            {
                OnstatenameChanging(value);
                ReportPropertyChanging("statename");
                _statename = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("statename");
                OnstatenameChanged();
            }
        }
        private global::System.String _statename;
        partial void OnstatenameChanging(global::System.String value);
        partial void OnstatenameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 countryid
        {
            get
            {
                return _countryid;
            }
            set
            {
                OncountryidChanging(value);
                ReportPropertyChanging("countryid");
                _countryid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("countryid");
                OncountryidChanged();
            }
        }
        private global::System.Int32 _countryid;
        partial void OncountryidChanging(global::System.Int32 value);
        partial void OncountryidChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "city2_ibfk_1", "city2")]
        public EntityCollection<city2> city2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<city2>("usercascadModel.city2_ibfk_1", "city2");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<city2>("usercascadModel.city2_ibfk_1", "city2", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "states1_ibfk_1", "country")]
        public country country
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("usercascadModel.states1_ibfk_1", "country").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("usercascadModel.states1_ibfk_1", "country").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<country> countryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<country>("usercascadModel.states1_ibfk_1", "country");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<country>("usercascadModel.states1_ibfk_1", "country", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("usercascadModel", "empstate_ibfk_1", "empstate")]
        public EntityCollection<empstate> empstates
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<empstate>("usercascadModel.empstate_ibfk_1", "empstate");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<empstate>("usercascadModel.empstate_ibfk_1", "empstate", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
