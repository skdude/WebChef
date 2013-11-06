using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

        public ActionResult Recepten()
        {
            ViewBag.Title = "Recepten";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login";
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Title = "Register";
            return View();
        }

        public ActionResult Sterrengerechten()
        {
            ViewBag.Title = "Sterrengerechten";
            return View();
        }
    }
}
