using SMSLite.Data;
using SMSLite.Models.Domain;
using SMSLite.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSLite.Controllers
{
    public class EnrollmentsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Enrollments
        [HttpGet]
        public ActionResult Enroll()
        {
            var vm = new EnrollViewModel();
            PopulateDropdowns(vm);

            return View(vm);
        }


        // POST: Enrollments
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Enroll(EnrollViewModel model)
        {
            if(!ModelState.IsValid)
            {
                PopulateDropdowns(model);
                return View(model);
            }

            bool alreadyEnrolled = db.Enrollments.Any(e => e.StudentId == model.StudentId && e.CourseId == model.CourseId);

            if (alreadyEnrolled)
            {
                ModelState.AddModelError("", "The student is already enrolled in the selected course.");
                PopulateDropdowns(model);
                return View(model);
            }

            var enrollment = new Enrollment
            {
                StudentId = model.StudentId,
                CourseId = model.CourseId
            };

            db.Enrollments.Add(enrollment);
            db.SaveChanges();

            return RedirectToAction("Enroll");
        }


        private void PopulateDropdowns(EnrollViewModel vm)
        {
            vm.Students = db.Students.OrderBy(s => s.Name)
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();

            vm.Courses = db.Courses.OrderBy(c => c.Name).Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
        }
    }
}