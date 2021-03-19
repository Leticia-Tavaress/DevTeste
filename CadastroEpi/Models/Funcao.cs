using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEpi.WebUI.Models
{
    public class Funcao
    {
        public int FuncaoId { get; set; }
        public string  NomeFuncao { get; set; }
        public int EmpresaId { get; set; }
        public int EpiId { get; set; }
    }
}