﻿//------------------------------------------------------------------------------
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

namespace CadastroEpi.Domain.Model
{

    /// <summary>
    /// There are no comments for CadastroEpi.Domain.Model.Funcionario in the schema.
    /// </summary>
    public partial class Funcionario    {

        public Funcionario()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for FuncionarioId in the schema.
        /// </summary>
        public virtual int FuncionarioId
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NomeFuncionario in the schema.
        /// </summary>
        public virtual string NomeFuncionario
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Cpf in the schema.
        /// </summary>
        public virtual string Cpf
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for FuncaoId in the schema.
        /// </summary>
        public virtual int FuncaoId
        {
            get;
            set;
        }


        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Funcao in the schema.
        /// </summary>
        public virtual Funcao Funcao
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for FuncionarioEpis in the schema.
        /// </summary>
        public virtual ICollection<FuncionarioEpi> FuncionarioEpis
        {
            get;
            set;
        }

        #endregion
    
        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion
    }

}
