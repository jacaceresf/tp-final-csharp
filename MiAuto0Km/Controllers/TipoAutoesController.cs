using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MiAuto0Km;

namespace MiAuto0Km.Controllers
{
    public class TipoAutoesController : ApiController
    {
        private cerokmdbEntities db = new cerokmdbEntities();

        // GET: api/TipoAutoes
        public IQueryable<TipoAuto> GetTipoAutoes()
        {
            return db.TipoAutoes;
        }

        // GET: api/TipoAutoes/5
        [ResponseType(typeof(TipoAuto))]
        public IHttpActionResult GetTipoAuto(int id)
        {
            TipoAuto tipoAuto = db.TipoAutoes.Find(id);
            if (tipoAuto == null)
            {
                return NotFound();
            }

            return Ok(tipoAuto);
        }

        // PUT: api/TipoAutoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoAuto(int id, TipoAuto tipoAuto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoAuto.ID_Tipo_Auto)
            {
                return BadRequest();
            }

            db.Entry(tipoAuto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoAutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TipoAutoes
        [ResponseType(typeof(TipoAuto))]
        public IHttpActionResult PostTipoAuto(TipoAuto tipoAuto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoAutoes.Add(tipoAuto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipoAuto.ID_Tipo_Auto }, tipoAuto);
        }

        // DELETE: api/TipoAutoes/5
        [ResponseType(typeof(TipoAuto))]
        public IHttpActionResult DeleteTipoAuto(int id)
        {
            TipoAuto tipoAuto = db.TipoAutoes.Find(id);
            if (tipoAuto == null)
            {
                return NotFound();
            }

            db.TipoAutoes.Remove(tipoAuto);
            db.SaveChanges();

            return Ok(tipoAuto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoAutoExists(int id)
        {
            return db.TipoAutoes.Count(e => e.ID_Tipo_Auto == id) > 0;
        }
    }
}