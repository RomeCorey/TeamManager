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
    public class TeamDinnersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TeamDinners
        public ActionResult Index()
        {
            return View(db.TeamDinners.ToList());
        }

        // GET: TeamDinners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamDinner teamDinner = db.TeamDinners.Find(id);
            if (teamDinner == null)
            {
                return HttpNotFound();
            }
            return View(teamDinner);
        }

        // GET: TeamDinners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamDinners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "teamDinnerId,teamDinnerTime,teamDinnerLocation")] TeamDinner teamDinner)
        {
            if (ModelState.IsValid)
            {
                db.TeamDinners.Add(teamDinner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teamDinner);
        }

        // GET: TeamDinners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamDinner teamDinner = db.TeamDinners.Find(id);
            if (teamDinner == null)
            {
                return HttpNotFound();
            }
            return View(teamDinner);
        }

        // POST: TeamDinners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "teamDinnerId,teamDinnerTime,teamDinnerLocation")] TeamDinner teamDinner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teamDinner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teamDinner);
        }

        // GET: TeamDinners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamDinner teamDinner = db.TeamDinners.Find(id);
            if (teamDinner == null)
            {
                return HttpNotFound();
            }
            return View(teamDinner);
        }

        // POST: TeamDinners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeamDinner teamDinner = db.TeamDinners.Find(id);
            db.TeamDinners.Remove(teamDinner);
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
