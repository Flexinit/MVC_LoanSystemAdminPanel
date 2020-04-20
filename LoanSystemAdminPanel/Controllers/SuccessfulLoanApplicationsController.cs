using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LoanSystemAdminPanel.Models;

namespace LoanSystemAdminPanel.Controllers
{
    public class SuccessfulLoanApplicationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SuccessfulLoanApplications
        public ActionResult Index()
        {
            return View(db.SuccessfulLoanApplications.ToList());
        }

        // GET: SuccessfulLoanApplications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuccessfulLoanApplications successfulLoanApplications = db.SuccessfulLoanApplications.Find(id);
            if (successfulLoanApplications == null)
            {
                return HttpNotFound();
            }
            return View(successfulLoanApplications);
        }

        // GET: SuccessfulLoanApplications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuccessfulLoanApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DeviceIMEI,Amount,Interest,Disbursed,DateOfLoanApplication,PeriodOfDays")] SuccessfulLoanApplications successfulLoanApplications)
        {
            if (ModelState.IsValid)
            {
                db.SuccessfulLoanApplications.Add(successfulLoanApplications);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(successfulLoanApplications);
        }

        // GET: SuccessfulLoanApplications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuccessfulLoanApplications successfulLoanApplications = db.SuccessfulLoanApplications.Find(id);
            if (successfulLoanApplications == null)
            {
                return HttpNotFound();
            }
            return View(successfulLoanApplications);
        }

        // POST: SuccessfulLoanApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DeviceIMEI,Amount,Interest,Disbursed,DateOfLoanApplication,PeriodOfDays")] SuccessfulLoanApplications successfulLoanApplications)
        {
            if (ModelState.IsValid)
            {
                db.Entry(successfulLoanApplications).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(successfulLoanApplications);
        }

        // GET: SuccessfulLoanApplications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuccessfulLoanApplications successfulLoanApplications = db.SuccessfulLoanApplications.Find(id);
            if (successfulLoanApplications == null)
            {
                return HttpNotFound();
            }
            return View(successfulLoanApplications);
        }

        // POST: SuccessfulLoanApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuccessfulLoanApplications successfulLoanApplications = db.SuccessfulLoanApplications.Find(id);
            db.SuccessfulLoanApplications.Remove(successfulLoanApplications);
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
