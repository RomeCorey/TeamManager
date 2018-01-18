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
    public class TeamPracticesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TeamPractices
        public ActionResult Index()
        {
            return View(db.TeamPractices.ToList());
        }

        // GET: TeamPractices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamPractice teamPractice = db.TeamPractices.Find(id);
            if (teamPractice == null)
            {
                return HttpNotFound();
            }
            return View(teamPractice);
        }

        // GET: TeamPractices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamPractices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "teamPracticeId,practiceLocation,practicePrice,indoor,outdoor,practiceTime")] TeamPractice teamPractice)
        {
            
            if (ModelState.IsValid)
            {

                LatLong latlong = APIController.GoogleCall(teamPractice.practiceLocation);
                teamPractice.lat = latlong.lat;
                teamPractice.lng = latlong.lng;
                db.TeamPractices.Add(teamPractice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teamPractice);
        }

        // GET: TeamPractices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamPractice teamPractice = db.TeamPractices.Find(id);
            if (teamPractice == null)
            {
                return HttpNotFound();
            }
            return View(teamPractice);
        }

        // POST: TeamPractices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "teamPracticeId,practiceLocation,practicePrice,practiceIndoor,practiceOutdoor,practiceTime, practiceDate")] TeamPractice teamPractice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teamPractice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teamPractice);
        }

        // GET: TeamPractices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamPractice teamPractice = db.TeamPractices.Find(id);
            if (teamPractice == null)
            {
                return HttpNotFound();
            }
            return View(teamPractice);
        }

        // POST: TeamPractices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeamPractice teamPractice = db.TeamPractices.Find(id);
            db.TeamPractices.Remove(teamPractice);
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

        //public ActionResult Weather(int id)
        //{
        //    WeatherViewModel model = new WeatherViewModel();
        //    TeamPractice practice = (from x in db.TeamPractices where x.teamPracticeId == id select x).FirstOrDefault();
        //    WeatherData data = APIController.GetWeather(practice.lat, practice.lng);
            

        //    foreach (var thing in data.List)
        //    {

        //        //parse
        //        if(thing.Dt == practice.practiceDate)
        //        {
        //            model.Main = thing.Main;
        //            model.Rain = thing.Rain;
        //        }
        //    }
        //    return View(model);
        //}
    }
}
