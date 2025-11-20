using SMSLite.Models;
using SMSLite.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SMSLite.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext() : base("SmsConnection")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}