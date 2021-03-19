using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEpi.WebUI.Models
{
    public class FuncionarioEpi
    {
        public int FuncionarioEpiId { get; set; }
        public DateTime DatEntrega { get; set; }
        public DateTime DatTroca { get; set; }
        public int FuncionarioId { get; set; }
        public int EpiId { get; set; }
    }
}