using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Viva_Project.Database;
using Viva_Project.Models;

namespace Viva_Project.Controllers
{
    public class HomeController : Controller
    {
        private DBContext db = new DBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignIn(UserModel us)
        {
            if(us != null)
            {
                var user = from u in db.users
                           where u.email.Equals(us.email) && u.password.Equals(us.password)
                           select u;

                if (user.ToArray().Length > 0)
                {
                    FormsAuthentication.SetAuthCookie(us.email,false);
                    return RedirectToAction("/");
                }
            } 
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserModel user)
        {
            db.users.Add(user);
            db.SaveChanges();
            return RedirectToAction("/");
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("/");
        }



    }
}