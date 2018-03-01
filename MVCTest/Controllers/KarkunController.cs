using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class KarkunController : Controller
    {
        // GET: Karkun
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int Id)
        {
            using (var karkunContexts = new KarkunContext())
            {
                var kr = karkunContexts.karkuns.Single(k => k.Id == Id);
                return View(kr);
            }
        }
    }
}