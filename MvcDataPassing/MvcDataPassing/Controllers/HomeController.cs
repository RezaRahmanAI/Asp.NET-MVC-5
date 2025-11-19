using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDataPassing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SaveWithParms(string name, int age)
        {
            ViewBag.Message = $"Name: {name}, Age: {age}";
            return View("Result");
        }

        [HttpPost]
        public ActionResult SaveWithReq()
        {
            string name = Request.Form["name"];
            string age = Request.Form["age"];

            ViewBag.Message = $"Name: {name}, Age: {age}";
            return View("Result");
        }
    }
}