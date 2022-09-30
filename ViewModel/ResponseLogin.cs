using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.ViewModel
{
    public class ResponseLogin
    {
        public int id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
