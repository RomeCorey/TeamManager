using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using TeamManager.Models;

namespace TeamManager.Controllers
{
    [Authorize]
    public class CoachPaymentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CoachPayments
        public ActionResult Index()
        {
            return View(db.CoachPayments.ToList());
        }

        // GET: CoachPayments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoachPayment coachPayment = db.CoachPayments.Find(id);
            if (coachPayment == null)
            {
                return HttpNotFound();
            }
            return View(coachPayment);
        }

        // GET: CoachPayments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoachPayments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "coachPaymentId,amountProOwes,amountD2Owes")] CoachPayment coachPayment)
        {
            if (ModelState.IsValid)
            {
                db.CoachPayments.Add(coachPayment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coachPayment);
        }

        // GET: CoachPayments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoachPayment coachPayment = db.CoachPayments.Find(id);
            if (coachPayment == null)
            {
                return HttpNotFound();
            }
            return View(coachPayment);
        }

        // POST: CoachPayments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "coachPaymentId,amountProOwes,amountD2Owes")] CoachPayment coachPayment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coachPayment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coachPayment);
        }

        // GET: CoachPayments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoachPayment coachPayment = db.CoachPayments.Find(id);
            if (coachPayment == null)
            {
                return HttpNotFound();
            }
            return View(coachPayment);
        }

        // POST: CoachPayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CoachPayment coachPayment = db.CoachPayments.Find(id);
            db.CoachPayments.Remove(coachPayment);
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
