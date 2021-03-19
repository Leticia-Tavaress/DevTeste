using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEpi.WebUI.Models
{
    public class Epi
    {
        public int EpiId { get; set; }
        public string NomEpi { get; set; }
        public DateTime DatInclusao { get; set; }
        public DateTime DatValidade { get; set; }
        public int NumCa { get; set; }
        public string NumProcesso  { get; set; }
        public string NomFabricante  { get; set; }
        public string CnpjFabricante { get; set; }


    }
}