using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string Name)
        {
            return "Hello to MVC world! " + Name;
        }

        public ViewResult Countries()
        {
            ViewBag.Countries = new List<string>()
            {
                "Pakistan",
                "China",
                "Turkey",
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult AboutMe()
        {
            ViewBag.MyMessage = "I am a SOftware Engineer.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}