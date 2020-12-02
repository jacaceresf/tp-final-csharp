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
    public class VehiculoConcesionariasController : Controller
    {
        private cerokmdbEntities db = new cerokmdbEntities();

        // GET: VehiculoConcesionarias
        [Authorize]
        public ActionResult Index()
        {
            var vehiculoConcesionarias = db.VehiculoConcesionarias.Include(v => v.Concesionaria).Include(v => v.Vehiculo);
            return View(vehiculoConcesionarias.ToList());
        }

        // GET: VehiculoConcesionarias/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehiculoConcesionaria vehiculoConcesionaria = db.VehiculoConcesionarias.Find(id);
            if (vehiculoConcesionaria == null)
            {
                return HttpNotFound();
            }
            return View(vehiculoConcesionaria);
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
