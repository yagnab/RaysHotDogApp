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
    public class HotDogGroupsController : ApiController
    {
        private RaysAppContext db = new RaysAppContext();

        // GET: api/HotDogGroups
        public IQueryable<HotDogGroup> GetHotDogGroups()
        {
            return db.HotDogGroups;
        }

        // GET: api/HotDogGroups/5
        [ResponseType(typeof(HotDogGroup))]
        public IHttpActionResult GetHotDogGroup(string id)
        {
            HotDogGroup hotDogGroup = db.HotDogGroups.Find(id);
            if (hotDogGroup == null)
            {
                return NotFound();
            }

            return Ok(hotDogGroup);
        }

        // PUT: api/HotDogGroups/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotDogGroup(string id, HotDogGroup hotDogGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotDogGroup.GroupName)
            {
                return BadRequest();
            }

            db.Entry(hotDogGroup).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotDogGroupExists(id))
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

        // POST: api/HotDogGroups
        [ResponseType(typeof(HotDogGroup))]
        public IHttpActionResult PostHotDogGroup(HotDogGroup hotDogGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HotDogGroups.Add(hotDogGroup);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HotDogGroupExists(hotDogGroup.GroupName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hotDogGroup.GroupName }, hotDogGroup);
        }

        // DELETE: api/HotDogGroups/5
        [ResponseType(typeof(HotDogGroup))]
        public IHttpActionResult DeleteHotDogGroup(string id)
        {
            HotDogGroup hotDogGroup = db.HotDogGroups.Find(id);
            if (hotDogGroup == null)
            {
                return NotFound();
            }

            db.HotDogGroups.Remove(hotDogGroup);
            db.SaveChanges();

            return Ok(hotDogGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotDogGroupExists(string id)
        {
            return db.HotDogGroups.Count(e => e.GroupName == id) > 0;
        }
    }
}