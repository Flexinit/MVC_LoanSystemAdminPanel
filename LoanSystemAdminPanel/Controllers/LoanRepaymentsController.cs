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
    public class LoanRepaymentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LoanRepayments
        public ActionResult Index()
        {
            return View(db.LoanRepayments.ToList());
        }

        // GET: LoanRepayments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanRepayment loanRepayment = db.LoanRepayments.Find(id);
            if (loanRepayment == null)
            {
                return HttpNotFound();
            }
            return View(loanRepayment);
        }

        // GET: LoanRepayments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanRepayments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IMEI,AmountRepaid,AmountRemaining,DateOfRepayment,TransactnID")] LoanRepayment loanRepayment)
        {
            if (ModelState.IsValid)
            {
                db.LoanRepayments.Add(loanRepayment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loanRepayment);
        }

        // GET: LoanRepayments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanRepayment loanRepayment = db.LoanRepayments.Find(id);
            if (loanRepayment == null)
            {
                return HttpNotFound();
            }
            return View(loanRepayment);
        }

        // POST: LoanRepayments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IMEI,AmountRepaid,AmountRemaining,DateOfRepayment,TransactnID")] LoanRepayment loanRepayment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanRepayment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loanRepayment);
        }

        // GET: LoanRepayments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanRepayment loanRepayment = db.LoanRepayments.Find(id);
            if (loanRepayment == null)
            {
                return HttpNotFound();
            }
            return View(loanRepayment);
        }

        // POST: LoanRepayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanRepayment loanRepayment = db.LoanRepayments.Find(id);
            db.LoanRepayments.Remove(loanRepayment);
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
