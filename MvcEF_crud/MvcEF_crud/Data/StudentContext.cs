using MvcEF_crud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcEF_crud.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}