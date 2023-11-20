using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SPA.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(150)]
        public string Name { get; set; }
        [Display(Name = "Family")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(150)]
        public string Family { get; set; }
        [Required(ErrorMessage = "Please enter {0}")]
        public int Age { get; set; }
    }
}