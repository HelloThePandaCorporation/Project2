using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Alamat { get; set; }
        public bool Gender { get; set; }

        public virtual User User { get; set; }
    }
}
