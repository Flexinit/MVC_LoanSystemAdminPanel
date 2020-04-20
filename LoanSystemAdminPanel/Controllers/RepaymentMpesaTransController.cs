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
    public class RepaymentMpesaTransController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RepaymentMpesaTrans
        public ActionResult Index()
        {
            return View(db.RepaymentMpesaTrans.ToList());
        }

        // GET: RepaymentMpesaTrans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepaymentMpesaTrans repaymentMpesaTrans = db.RepaymentMpesaTrans.Find(id);
            if (repaymentMpesaTrans == null)
            {
                return HttpNotFound();
            }
            return View(repaymentMpesaTrans);
        }

        // GET: RepaymentMpesaTrans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RepaymentMpesaTrans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DeviceIMEI,TransactionID,Amount,MpesaReceiptNumber,TransactionDate,PhoneNumber")] RepaymentMpesaTrans repaymentMpesaTrans)
        {
            if (ModelState.IsValid)
            {
                db.RepaymentMpesaTrans.Add(repaymentMpesaTrans);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(repaymentMpesaTrans);
        }

        // GET: RepaymentMpesaTrans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepaymentMpesaTrans repaymentMpesaTrans = db.RepaymentMpesaTrans.Find(id);
            if (repaymentMpesaTrans == null)
            {
                return HttpNotFound();
            }
            return View(repaymentMpesaTrans);
        }

        // POST: RepaymentMpesaTrans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DeviceIMEI,TransactionID,Amount,MpesaReceiptNumber,TransactionDate,PhoneNumber")] RepaymentMpesaTrans repaymentMpesaTrans)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repaymentMpesaTrans).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(repaymentMpesaTrans);
        }

        // GET: RepaymentMpesaTrans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepaymentMpesaTrans repaymentMpesaTrans = db.RepaymentMpesaTrans.Find(id);
            if (repaymentMpesaTrans == null)
            {
                return HttpNotFound();
            }
            return View(repaymentMpesaTrans);
        }

        // POST: RepaymentMpesaTrans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RepaymentMpesaTrans repaymentMpesaTrans = db.RepaymentMpesaTrans.Find(id);
            db.RepaymentMpesaTrans.Remove(repaymentMpesaTrans);
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
