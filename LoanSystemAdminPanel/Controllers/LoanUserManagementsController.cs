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
    public class LoanUserManagementsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LoanUserManagements
        public ActionResult Index()
        {
            return View(db.LoanUserManagements.ToList());
        }

        // GET: LoanUserManagements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanUserManagement loanUserManagement = db.LoanUserManagements.Find(id);
            if (loanUserManagement == null)
            {
                return HttpNotFound();
            }
            return View(loanUserManagement);
        }

        // GET: LoanUserManagements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanUserManagements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,username,password")] LoanUserManagement loanUserManagement)
        {
            if (ModelState.IsValid)
            {
                db.LoanUserManagements.Add(loanUserManagement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loanUserManagement);
        }

        // GET: LoanUserManagements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanUserManagement loanUserManagement = db.LoanUserManagements.Find(id);
            if (loanUserManagement == null)
            {
                return HttpNotFound();
            }
            return View(loanUserManagement);
        }

        // POST: LoanUserManagements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,username,password")] LoanUserManagement loanUserManagement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanUserManagement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loanUserManagement);
        }

        // GET: LoanUserManagements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanUserManagement loanUserManagement = db.LoanUserManagements.Find(id);
            if (loanUserManagement == null)
            {
                return HttpNotFound();
            }
            return View(loanUserManagement);
        }

        // POST: LoanUserManagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanUserManagement loanUserManagement = db.LoanUserManagements.Find(id);
            db.LoanUserManagements.Remove(loanUserManagement);
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
