using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcEF_crud.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(1, 3)]
        public int Credits { get; set; }
    }
}