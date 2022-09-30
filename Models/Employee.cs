using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2_MVC_Perkantoran.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
