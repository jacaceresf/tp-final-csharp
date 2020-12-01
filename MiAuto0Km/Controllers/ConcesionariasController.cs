using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MiAuto0Km;

namespace MiAuto0Km.Controllers
{
    public class ConcesionariasController : Controller
    {
        private cerokmdbEntities db = new cerokmdbEntities();

        [Authorize]
        // GET: Concesionarias
        public ActionResult Index()
        {
            return View(db.Concesionarias.ToList());
        }

        [Authorize]
        // GET: Concesionarias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concesionaria concesionaria = db.Concesionarias.Find(id);
            if (concesionaria == null)
            {
                return HttpNotFound();
            }
            return View(concesionaria);
        }

        [Authorize]
        // GET: Concesionarias/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Concesionarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Concesionaria,Nombre,Direccion,Telefono,Email")] Concesionaria concesionaria)
        {
            if (ModelState.IsValid)
            {
                db.Concesionarias.Add(concesionaria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(concesionaria);
        }

        // GET: Concesionarias/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concesionaria concesionaria = db.Concesionarias.Find(id);
            if (concesionaria == null)
            {
                return HttpNotFound();
            }
            return View(concesionaria);
        }

        // POST: Concesionarias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Concesionaria,Nombre,Direccion,Telefono,Email")] Concesionaria concesionaria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(concesionaria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(concesionaria);
        }

        // GET: Concesionarias/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concesionaria concesionaria = db.Concesionarias.Find(id);
            if (concesionaria == null)
            {
                return HttpNotFound();
            }
            return View(concesionaria);
        }

        // POST: Concesionarias/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Concesionaria concesionaria = db.Concesionarias.Find(id);
            db.Concesionarias.Remove(concesionaria);
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
