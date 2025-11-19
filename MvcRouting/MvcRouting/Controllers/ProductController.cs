using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRouting.Controllers
{
    [RoutePrefix("product")]
    public class ProductController : Controller
    {
        // GET: Product

        [Route("")]
        public ActionResult Index()
        {
            ViewBag.Message = "Product Index";
            return View();
        }

        [Route("details/{id:int}")]
        public ActionResult Details(int id)
        {
            ViewBag.Message = $"Product Details for ID: {id}";
            return View();
        }
    }
}