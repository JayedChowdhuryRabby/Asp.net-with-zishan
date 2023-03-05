using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Reg
    {

      
        public string Name { get; set; }
       
        public string Id { get; set; }
        
        public string Gender { get; set; }
        
        public string Profession { get; set; }
       
        public string[] Hobbies { get; set; }
        public DateTime Dob { get; set; }
    }
}