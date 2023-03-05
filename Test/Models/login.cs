using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class login
    {
        [Required(ErrorMessage = "Please provide name of zishan")]
        public string Uname { get; set; }
        [Required]
        public string Pass { get; set; }
    }
}