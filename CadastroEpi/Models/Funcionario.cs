using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEpi.WebUI.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get ; set ; }
        public int FuncaoId { get ; set ; }
        public string NomeFuncionario { get; set; }
        public string Cpf { get ; set ; }
    }
    
}