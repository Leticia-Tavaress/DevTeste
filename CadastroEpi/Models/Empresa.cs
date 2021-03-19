using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroEpi.WebUI.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set ; }
        public int TipoIdentificador { get ; set ; }
        public string Identificador { get ; set ; }              
        public string RazaoSocial { get ; set; }
		
	}

}
