using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMSLite.Models.Domain
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string Name { get; set; }

        [Required,StringLength(10)]
        public string Code { get; set; }

        [Required,Range(0.5, 6)]
        public double Credit { get; set; }

        [Required,StringLength(20)]
        public string Semester { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }
    }
}