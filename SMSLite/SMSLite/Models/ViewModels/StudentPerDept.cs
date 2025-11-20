using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSLite.Models.ViewModels
{
    public class StudentPerDept
    {
        public string Department { get; set; }
        public int StudentCount { get; set; }
    }


    public class StudentDashboardViewModel
    {
        public int TotalStudents { get; set; }
        public int TotalDepartments
        {
            get
            {
                return StudentCountsPerDept?.Count ?? 0;
            }
        }
        
        public List<StudentPerDept> StudentCountsPerDept { get; set; }
        public List<string> DepartmentNames
        {
            get
            {
                return StudentCountsPerDept?.Select(d => d.Department).ToList() ?? new List<string>();
            }
        }
    }
}