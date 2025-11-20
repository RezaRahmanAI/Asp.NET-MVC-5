using SMSLite.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSLite.Models.ViewModels
{
    public class EnrollViewModel
    {
        [Required]
        [Display(Name = "Student")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Course")]
        public int CourseId { get; set; }

        // For dropdown lists
        public IEnumerable<SelectListItem> Students { get; set; }
        public IEnumerable<SelectListItem> Courses { get; set; }
    }
}