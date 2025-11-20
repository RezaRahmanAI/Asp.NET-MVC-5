using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SMSLite.Models.Domain
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; } // Foreign key to Student
        [Required]
        public int CourseId { get; set; } // Foreign key to Course


        // Navigation properties
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        // Navigation properties
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}