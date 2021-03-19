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
    public class FuncaoController : Controller
    {
        private Entities db = new Entities();

        // GET: Funcao
        public ActionResult Index()
        {
            var funcaos = db.Funcaos.Include(f => f.Empresa).Include(f => f.Epi);
            
            return View(funcaos.ToList());
        }
        

        // GET: Funcao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcao funcao = db.Funcaos.Find(id);
            if (funcao == null)
            {
                return HttpNotFound();
            }
            return View(funcao);
        }

        // GET: Funcao/Create
        public ActionResult Create()
        {
            ViewBag.EmpresaId = new SelectList(db.Empresas, "EmpresaId", "RazaoSocial");
            ViewBag.EpiId = new SelectList(db.Epis, "EpiId", "NomEpi");
            return View();
        }

        // POST: Funcao/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FuncaoId,NomeFuncao,EmpresaId,EpiId")] Funcao funcao)
        {
            if (ModelState.IsValid)
            {
                db.Funcaos.Add(funcao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpresaId = new SelectList(db.Empresas, "EmpresaId", "RazaoSocial", funcao.EmpresaId);
            ViewBag.EpiId = new SelectList(db.Epis, "EpiId", "NomEpi", funcao.EpiId);
            return View(funcao);
        }

        // GET: Funcao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcao funcao = db.Funcaos.Find(id);
            if (funcao == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpresaId = new SelectList(db.Empresas, "EmpresaId", "RazaoSocial", funcao.EmpresaId);
            ViewBag.EpiId = new SelectList(db.Epis, "EpiId", "NomEpi", funcao.EpiId);
            return View(funcao);
        }

        // POST: Funcao/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FuncaoId,NomeFuncao,EmpresaId,EpiId")] Funcao funcao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpresaId = new SelectList(db.Empresas, "EmpresaId", "RazaoSocial", funcao.EmpresaId);
            ViewBag.EpiId = new SelectList(db.Epis, "EpiId", "NomEpi", funcao.EpiId);
            return View(funcao);
        }

        // GET: Funcao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcao funcao = db.Funcaos.Find(id);
            if (funcao == null)
            {
                return HttpNotFound();
            }
            return View(funcao);
        }

        // POST: Funcao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcao funcao = db.Funcaos.Find(id);
            db.Funcaos.Remove(funcao);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
