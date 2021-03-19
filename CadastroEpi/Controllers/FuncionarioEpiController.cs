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
    public class FuncionarioEpiController : Controller
    {
        private Entities db = new Entities();

        // GET: FuncionarioEpi
        public ActionResult Index()
        {
            var funcionarioEpis = db.FuncionarioEpis.Include(f => f.Epi).Include(f => f.Funcionario);
            return View(funcionarioEpis.ToList());
        }

        // GET: FuncionarioEpi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuncionarioEpi funcionarioEpi = db.FuncionarioEpis.Find(id);
            if (funcionarioEpi == null)
            {
                return HttpNotFound();
            }
            return View(funcionarioEpi);
        }

        // GET: FuncionarioEpi/Create
        public ActionResult Create()
        {
            ViewBag.EpiId = new SelectList(db.Epis, "EpiId", "NomEpi");
            ViewBag.FuncionarioId = new SelectList(db.Funcionarios, "FuncionarioId", "NomeFuncionario");
            return View();
        }

        // POST: FuncionarioEpi/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FuncionarioEpiId,DatEntrega,DatTroca,FuncionarioId,EpiId")] FuncionarioEpi funcionarioEpi)
        {
            if (ModelState.IsValid)
            {
                db.FuncionarioEpis.Add(funcionarioEpi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EpiId = new SelectList(db.Epis, "EpiId", "NomEpi", funcionarioEpi.EpiId);
            ViewBag.FuncionarioId = new SelectList(db.Funcionarios, "FuncionarioId", "NomeFuncionario", funcionarioEpi.FuncionarioId);
            return View(funcionarioEpi);
        }

        // GET: FuncionarioEpi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuncionarioEpi funcionarioEpi = db.FuncionarioEpis.Find(id);
            if (funcionarioEpi == null)
            {
                return HttpNotFound();
            }
            ViewBag.EpiId = new SelectList(db.Epis, "EpiId", "NomEpi", funcionarioEpi.EpiId);
            ViewBag.FuncionarioId = new SelectList(db.Funcionarios, "FuncionarioId", "NomeFuncionario", funcionarioEpi.FuncionarioId);
            return View(funcionarioEpi);
        }

        // POST: FuncionarioEpi/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FuncionarioEpiId,DatEntrega,DatTroca,FuncionarioId,EpiId")] FuncionarioEpi funcionarioEpi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionarioEpi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EpiId = new SelectList(db.Epis, "EpiId", "NomEpi", funcionarioEpi.EpiId);
            ViewBag.FuncionarioId = new SelectList(db.Funcionarios, "FuncionarioId", "NomeFuncionario", funcionarioEpi.FuncionarioId);
            return View(funcionarioEpi);
        }

        // GET: FuncionarioEpi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuncionarioEpi funcionarioEpi = db.FuncionarioEpis.Find(id);
            if (funcionarioEpi == null)
            {
                return HttpNotFound();
            }
            return View(funcionarioEpi);
        }

        // POST: FuncionarioEpi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FuncionarioEpi funcionarioEpi = db.FuncionarioEpis.Find(id);
            db.FuncionarioEpis.Remove(funcionarioEpi);
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
