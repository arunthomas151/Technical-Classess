using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class UserdemoController : Controller
    {
        private UserContext db = new UserContext();

        // GET: /Userdemo/
        public ActionResult Index()
        {
            var userdemoes = db.Userdemoes.Include(u => u.User);
            return View(userdemoes.ToList());
        }

        // GET: /Userdemo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userdemo userdemo = db.Userdemoes.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            return View(userdemo);
        }

        // GET: /Userdemo/Create
        public ActionResult Create()
        {
            ViewBag.Userid = new SelectList(db.Users, "UserId", "ename");
            return View();
        }

        // POST: /Userdemo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="UserdemoId,Userid,sname,semail,Genderlist")] Userdemo userdemo)
        {
            if (ModelState.IsValid)
            {
                db.Userdemoes.Add(userdemo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Userid = new SelectList(db.Users, "UserId", "ename", userdemo.Userid);
            return View(userdemo);
        }

        // GET: /Userdemo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userdemo userdemo = db.Userdemoes.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            ViewBag.Userid = new SelectList(db.Users, "UserId", "ename", userdemo.Userid);
            return View(userdemo);
        }

        // POST: /Userdemo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="UserdemoId,Userid,sname,semail,Genderlist")] Userdemo userdemo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userdemo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Userid = new SelectList(db.Users, "UserId", "ename", userdemo.Userid);
            return View(userdemo);
        }

        // GET: /Userdemo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userdemo userdemo = db.Userdemoes.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            return View(userdemo);
        }

        // POST: /Userdemo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Userdemo userdemo = db.Userdemoes.Find(id);
            db.Userdemoes.Remove(userdemo);
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
