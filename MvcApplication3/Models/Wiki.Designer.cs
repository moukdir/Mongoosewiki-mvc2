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

namespace MvcApplication3.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WikiEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public WikiEntities() : base("name=Entities", "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public WikiEntities(string connectionString) : base(connectionString, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public WikiEntities(EntityConnection connection) : base(connection, "Entities")
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
        public ObjectSet<Articles> Articles
        {
            get
            {
                if ((_Articles == null))
                {
                    _Articles = base.CreateObjectSet<Articles>("Articles");
                }
                return _Articles;
            }
        }
        private ObjectSet<Articles> _Articles;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Articles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToArticles(Articles articles)
        {
            base.AddObject("Articles", articles);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Articles")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Articles : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Articles object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        public static Articles CreateArticles(global::System.Int32 id, global::System.String title)
        {
            Articles articles = new Articles();
            articles.Id = id;
            articles.Title = title;
            return articles;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Body
        {
            get
            {
                return _Body;
            }
            set
            {
                OnBodyChanging(value);
                ReportPropertyChanging("Body");
                _Body = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Body");
                OnBodyChanged();
            }
        }
        private global::System.String _Body;
        partial void OnBodyChanging(global::System.String value);
        partial void OnBodyChanged();

        #endregion
    
    }

    #endregion
    
}
