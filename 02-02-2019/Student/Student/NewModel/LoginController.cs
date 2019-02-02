using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student.NewModel;
using Student.Models;

namespace Student.NewModel
{
    public class LoginController : Controller
    {
        public UserContext db = new UserContext();
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(LoginViewModel lm)
        {
            var u = db.Registrations.Where(x => x.suname == lm.username & x.spword == lm.password).FirstOrDefault();
            if (u == null)
            {
                ModelState.AddModelError("", "Invalid username or Password");
                return View();
            }
            return View("Index", "Login");
        }
	}
}