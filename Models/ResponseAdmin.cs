using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.ViewModel
{
    public class ResponseAdmin
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int Userid { get; set; }
        public int Alamat { get; set; }
        public bool Gender { get; set; }
        public string Name { get; set; }
    }
}
