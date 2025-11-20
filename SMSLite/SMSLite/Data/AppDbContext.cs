using SMSLite.Models;
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
    }
}