using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLCoffee.Models;

namespace QLCoffee.Controllers
{
    public class EmploymentController : Controller
    {
        private QLCoffeeDbContext db = new QLCoffeeDbContext();

        // GET: Employment
        public ActionResult Index()
        {
            return View(db.Employments.ToList());
        }

        // GET: Employment/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employment employment = db.Employments.Find(id);
            if (employment == null)
            {
                return HttpNotFound();
            }
            return View(employment);
        }

        // GET: Employment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmploymentID,EmploymentName,Address")] Employment employment)
        {
            if (ModelState.IsValid)
            {
                db.Employments.Add(employment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employment);
        }

        // GET: Employment/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employment employment = db.Employments.Find(id);
            if (employment == null)
            {
                return HttpNotFound();
            }
            return View(employment);
        }

        // POST: Employment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmploymentID,EmploymentName,Address")] Employment employment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employment);
        }

        // GET: Employment/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employment employment = db.Employments.Find(id);
            if (employment == null)
            {
                return HttpNotFound();
            }
            return View(employment);
        }

        // POST: Employment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Employment employment = db.Employments.Find(id);
            db.Employments.Remove(employment);
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
