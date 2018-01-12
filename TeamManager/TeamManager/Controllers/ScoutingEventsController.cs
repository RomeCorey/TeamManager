using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TeamManager.Models;

namespace TeamManager.Controllers
{
    public class ScoutingEventsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ScoutingEvents
        public ActionResult Index()
        {
            return View(db.ScoutingEvents.ToList());
        }

        // GET: ScoutingEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScoutingEvent scoutingEvent = db.ScoutingEvents.Find(id);
            if (scoutingEvent == null)
            {
                return HttpNotFound();
            }
            return View(scoutingEvent);
        }

        // GET: ScoutingEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScoutingEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "scoutingEventId,rivalTeam,scoutingField,scoutingTime,scoutingNotes")] ScoutingEvent scoutingEvent)
        {
            if (ModelState.IsValid)
            {
                db.ScoutingEvents.Add(scoutingEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scoutingEvent);
        }

        // GET: ScoutingEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScoutingEvent scoutingEvent = db.ScoutingEvents.Find(id);
            if (scoutingEvent == null)
            {
                return HttpNotFound();
            }
            return View(scoutingEvent);
        }

        // POST: ScoutingEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "scoutingEventId,rivalTeam,scoutingField,scoutingTime,scoutingNotes")] ScoutingEvent scoutingEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scoutingEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scoutingEvent);
        }

        // GET: ScoutingEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScoutingEvent scoutingEvent = db.ScoutingEvents.Find(id);
            if (scoutingEvent == null)
            {
                return HttpNotFound();
            }
            return View(scoutingEvent);
        }

        // POST: ScoutingEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScoutingEvent scoutingEvent = db.ScoutingEvents.Find(id);
            db.ScoutingEvents.Remove(scoutingEvent);
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
