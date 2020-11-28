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
    public class VehiculoesController : Controller
    {
        private CerokmEntities db = new CerokmEntities();



        // GET: Vehiculoes/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Marca_Id = new SelectList(db.Marcas, "ID_Marca", "Nombre_Marca");
            ViewBag.Tipo_Auto_Id = new SelectList(db.TipoAutoes, "ID_Tipo_Auto", "Descripion");
            ViewBag.TipoTransmision_id = new SelectList(db.TipoTransmisions, "ID_TipoTransmision", "Descripcion");
            return View();
        }

        // POST: Vehiculoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Auto,Descripcion,Tipo_Auto_Id,TipoTransmision_id,Marca_Id,MotorCC,Modelo,Anho")] Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                db.Vehiculoes.Add(vehiculo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Marca_Id = new SelectList(db.Marcas, "ID_Marca", "Nombre_Marca", vehiculo.Marca_Id);
            ViewBag.Tipo_Auto_Id = new SelectList(db.TipoAutoes, "ID_Tipo_Auto", "Descripion", vehiculo.Tipo_Auto_Id);
            ViewBag.TipoTransmision_id = new SelectList(db.TipoTransmisions, "ID_TipoTransmision", "Descripcion", vehiculo.TipoTransmision_id);
            return View(vehiculo);
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
