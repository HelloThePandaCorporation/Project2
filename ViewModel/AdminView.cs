using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.ViewModel
{
    public class AdminView
    {
        [Key]
        public int id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        [Key]
        public int Userid { get; set; }
        public string Alamat { get; set; }
        public bool Gender { get; set; }
        public string Name { get; set; }
    }
}
