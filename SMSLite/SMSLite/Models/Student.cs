using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMSLite.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(100)]
        public string Name { get; set; }

        [Required,DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required,EmailAddress, StringLength(30)]
        public string Email { get; set; }

        [Required,Phone, StringLength(15)]
        public string PhoneNumber { get; set; }

        [Required, StringLength(200)]
        public string Address { get; set; }

        [Required, StringLength(100)]
        public string Department { get; set; }
    }
}