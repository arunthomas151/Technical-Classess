using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Student.Models;

namespace Student.Controllers
{
    public class StudController : Controller
    {
        private UserContext db = new UserContext();

        // GET: /Stud/
        public ActionResult Index()
        {
            var studs = db.Studs.Include(s => s.Dept).Include(s => s.Registration);
            return View(studs.ToList());
        }

        // GET: /Stud/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        // GET: /Stud/Create
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList(db.Depts, "DeptId", "dname");
            ViewBag.RegistrationId = new SelectList(db.Registrations, "RegistrationId", "sname");
            return View();
        }

        // POST: /Stud/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="StudId,DeptId,RegistrationId")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                db.Studs.Add(stud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DeptId = new SelectList(db.Depts, "DeptId", "dname", stud.DeptId);
            ViewBag.RegistrationId = new SelectList(db.Registrations, "RegistrationId", "sname", stud.RegistrationId);
            return View(stud);
        }

        // GET: /Stud/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeptId = new SelectList(db.Depts, "DeptId", "dname", stud.DeptId);
            ViewBag.RegistrationId = new SelectList(db.Registrations, "RegistrationId", "sname", stud.RegistrationId);
            return View(stud);
        }

        // POST: /Stud/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="StudId,DeptId,RegistrationId")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptId = new SelectList(db.Depts, "DeptId", "dname", stud.DeptId);
            ViewBag.RegistrationId = new SelectList(db.Registrations, "RegistrationId", "sname", stud.RegistrationId);
            return View(stud);
        }

        // GET: /Stud/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        // POST: /Stud/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stud stud = db.Studs.Find(id);
            db.Studs.Remove(stud);
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
