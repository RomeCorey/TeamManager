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
    [Authorize]
    public class TeamMeetingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TeamMeetings
        public ActionResult Index()
        {
            return View(db.TeamMeetings.ToList());
        }

        // GET: TeamMeetings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamMeeting teamMeeting = db.TeamMeetings.Find(id);
            if (teamMeeting == null)
            {
                return HttpNotFound();
            }
            return View(teamMeeting);
        }

        // GET: TeamMeetings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamMeetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "teamMeetingId,teamMeetingLocation,teamMeetingTime,teamMeetingDate")] TeamMeeting teamMeeting)
        {
            if (ModelState.IsValid)
            {
                db.TeamMeetings.Add(teamMeeting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teamMeeting);
        }

        // GET: TeamMeetings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamMeeting teamMeeting = db.TeamMeetings.Find(id);
            if (teamMeeting == null)
            {
                return HttpNotFound();
            }
            return View(teamMeeting);
        }

        // POST: TeamMeetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "teamMeetingId,teamMeetingLocation,teamMeetingTime,teamMeetingDate")] TeamMeeting teamMeeting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teamMeeting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teamMeeting);
        }

        // GET: TeamMeetings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamMeeting teamMeeting = db.TeamMeetings.Find(id);
            if (teamMeeting == null)
            {
                return HttpNotFound();
            }
            return View(teamMeeting);
        }

        // POST: TeamMeetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeamMeeting teamMeeting = db.TeamMeetings.Find(id);
            db.TeamMeetings.Remove(teamMeeting);
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
