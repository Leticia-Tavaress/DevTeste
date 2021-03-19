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
    public class EpiController : Controller
    {
        private Entities db = new Entities();

        // GET: Epi
        public ActionResult Index()
        {
            return View(db.Epis.ToList());
        }

        // GET: Epi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Epi epi = db.Epis.Find(id);
            if (epi == null)
            {
                return HttpNotFound();
            }
            return View(epi);
        }

        // GET: Epi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Epi/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EpiId,NomEpi,DatInclusao,DatValidade,NumCa,NumProcesso,NomFabricante,CnpjFabricante")] Epi epi)
        {
            if (ModelState.IsValid)
            {
                db.Epis.Add(epi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(epi);
        }

        // GET: Epi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Epi epi = db.Epis.Find(id);
            if (epi == null)
            {
                return HttpNotFound();
            }
            return View(epi);
        }

        // POST: Epi/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EpiId,NomEpi,DatInclusao,DatValidade,NumCa,NumProcesso,NomFabricante,CnpjFabricante")] Epi epi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(epi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(epi);
        }

        // GET: Epi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Epi epi = db.Epis.Find(id);
            if (epi == null)
            {
                return HttpNotFound();
            }
            return View(epi);
        }

        // POST: Epi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Epi epi = db.Epis.Find(id);
            db.Epis.Remove(epi);
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
