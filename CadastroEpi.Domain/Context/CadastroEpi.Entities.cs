//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 20/04/2018 15:36:26
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using CadastroEpi.Domain.Model;

namespace CadastroEpi.Db
{
    public partial class Entities : DbContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities() :
                base(@"name=DefaultConnection")
        {
            Configure();
        }

        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities(string nameOrConnectionString) :
                base(nameOrConnectionString)
        {
            Configure();
        }

        private void Configure()
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;
        }

        #endregion

        

    
        /// <summary>
        /// There are no comments for Funcionario in the schema.
        /// </summary>
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
    
        /// <summary>
        /// There are no comments for Empresa in the schema.
        /// </summary>
        public virtual DbSet<Empresa> Empresas { get; set; }
    
        /// <summary>
        /// There are no comments for Funcao in the schema.
        /// </summary>
        public virtual DbSet<Funcao> Funcaos { get; set; }
    
        /// <summary>
        /// There are no comments for Epi in the schema.
        /// </summary>
        public virtual DbSet<Epi> Epis { get; set; }
    
        /// <summary>
        /// There are no comments for FuncionarioEpi in the schema.
        /// </summary>
        public virtual DbSet<FuncionarioEpi> FuncionarioEpis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
