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
    public class FuncaoFunController : Controller
    {
        private Entities db = new Entities();

        // GET: FuncaoFun
        public ActionResult Index(string FuncaoId = "")
        {
            var q = db.Funcaos.AsQueryable();
            if (!string.IsNullOrEmpty(FuncaoId))
            {
                q = q.Where(c => c.NomeFuncao.Contains(FuncaoId));
                q = q.OrderBy(c => c.NomeFuncao);
                
            }
            return View(q.ToList());

        }
      

    }
}
