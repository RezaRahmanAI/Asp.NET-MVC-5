using MvcHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {           

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(User user)
        {
            TempData["Message"] = "User saved successfully!";

            // save user to database (not implemented)

            return RedirectToAction("About");
        }

        
    }
}