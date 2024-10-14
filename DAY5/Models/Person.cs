using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace DAY5.Models
{
    public class Person
    {
        [Required(ErrorMessage = "enter your name")]
        public string PersonName { get; set; }
        
        [Required(ErrorMessage = "enter city name")]
        public int City { get; set; }
        [Required(ErrorMessage = "attending????")]
        public bool ? WillAttend { get; set; }


    }
}