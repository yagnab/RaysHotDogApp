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
using RaysHotDogApp.WebService.Models;

namespace RaysHotDogApp.WebService.Controllers
{
    public class HotDogsController : ApiController
    {
        private RaysAppContext db = new RaysAppContext();

        // GET: api/HotDogs
        public IQueryable<HotDog> GetHotDogs()
        {
            return db.HotDogs;
        }

        // GET: api/HotDogs/5
        [ResponseType(typeof(HotDog))]
        public IHttpActionResult GetHotDog(int id)
        {
            HotDog hotDog = db.HotDogs.Find(id);
            if (hotDog == null)
            {
                return NotFound();
            }

            return Ok(hotDog);
        }

        // PUT: api/HotDogs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotDog(int id, HotDog hotDog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotDog.HotDogId)
            {
                return BadRequest();
            }

            db.Entry(hotDog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotDogExists(id))
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

        // POST: api/HotDogs
        [ResponseType(typeof(HotDog))]
        public IHttpActionResult PostHotDog(HotDog hotDog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HotDogs.Add(hotDog);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hotDog.HotDogId }, hotDog);
        }

        // DELETE: api/HotDogs/5
        [ResponseType(typeof(HotDog))]
        public IHttpActionResult DeleteHotDog(int id)
        {
            HotDog hotDog = db.HotDogs.Find(id);
            if (hotDog == null)
            {
                return NotFound();
            }

            db.HotDogs.Remove(hotDog);
            db.SaveChanges();

            return Ok(hotDog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotDogExists(int id)
        {
            return db.HotDogs.Count(e => e.HotDogId == id) > 0;
        }
    }
}