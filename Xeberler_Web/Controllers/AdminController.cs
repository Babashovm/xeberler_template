using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xeberler_Web.Models;

namespace Xeberler_Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            if (Session["UserName"] != null)
            {
                return RedirectToAction("Home");
            }
            else
            {
                return View();
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User userLogin)
        {
            if (ModelState.IsValid)
            {
                using(xeberlerEntities db = new xeberlerEntities())
                {
                    var obj = db.Users.Where(a => a.user_name.Equals(userLogin.user_name) && a.user_password.Equals(userLogin.user_password)).FirstOrDefault();
                    
                    if(obj != null)
                    {
                        Session["UserId"] = obj.id.ToString();
                        Session["UserName"] = obj.user_name;
                        return RedirectToAction("Home");
                    }
                }
            }
            return View(userLogin);
        }

        public ActionResult Home()
        {
            if(Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

        public ActionResult AddNews()
        {
            if(Session["UserName"] != null)
            {
                return View();
            }
            else
            {
               return RedirectToAction("Login");
            }
            
        }
    }
}