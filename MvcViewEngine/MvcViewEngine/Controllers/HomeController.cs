using MvcViewEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 999.99m },
                new Product { Name = "Smartphone", Price = 499.99m },
                new Product { Name = "Tablet", Price = 299.99m }
            };

            return View(products);
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
    }
}