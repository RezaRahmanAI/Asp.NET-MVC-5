using SMSLite.Data;
using SMSLite.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSLite.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            var totalStudents = db.Students.Count();

            var perDept = db.Students
                .GroupBy(d => d.Department)
                .Select(g => new StudentPerDept
                {
                    Department = g.Key,
                    StudentCount = g.Count()
                }).ToList();

            var model = new StudentDashboardViewModel
            {
                TotalStudents = totalStudents,
                StudentCountsPerDept = perDept
            };

            return View(model);
        }

        
    }
}