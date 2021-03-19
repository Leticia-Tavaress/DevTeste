using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CadastroEpi.Db;
using CadastroEpi.Domain.Model;

namespace CadastroEpi.WebUI.Controllers
{
    public class EpisController : Controller
    {
        Entities db = new Entities();

        public ActionResult Index()
        {
            var funcionarioEpis = db.FuncionarioEpis.Include(f => f.Epi).Include(f => f.Funcionario);
            return View(funcionarioEpis.ToList());
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void  ListarEpis(object sender, EventArgs e)
        {
            Response.Write("<script>alert(ViewBag.EpiId = new SelectList(db.Epis, 'EpiId', 'NomEpi')) </script>");
           
            
        }
    }
}