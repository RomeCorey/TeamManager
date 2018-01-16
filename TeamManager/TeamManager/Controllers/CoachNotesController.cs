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
    public class CoachNotesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CoachNotes
        public ActionResult Index()
        {
            return View(db.CoachNotes.ToList());
        }

        // GET: CoachNotes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoachNotes coachNotes = db.CoachNotes.Find(id);
            if (coachNotes == null)
            {
                return HttpNotFound();
            }
            return View(coachNotes);
        }

        // GET: CoachNotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoachNotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "coachNotes")] CoachNotes coachNotes)
        {
            if (ModelState.IsValid)
            {
                db.CoachNotes.Add(coachNotes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coachNotes);
        }

        // GET: CoachNotes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoachNotes coachNotes = db.CoachNotes.Find(id);
            if (coachNotes == null)
            {
                return HttpNotFound();
            }
            return View(coachNotes);
        }

        // POST: CoachNotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "coachNotes")] CoachNotes coachNotes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coachNotes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coachNotes);
        }

        // GET: CoachNotes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoachNotes coachNotes = db.CoachNotes.Find(id);
            if (coachNotes == null)
            {
                return HttpNotFound();
            }
            return View(coachNotes);
        }

        // POST: CoachNotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CoachNotes coachNotes = db.CoachNotes.Find(id);
            db.CoachNotes.Remove(coachNotes);
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
