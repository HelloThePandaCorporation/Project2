using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.ViewModel
{
    public class ResponseClient
    {
        public string message { get; set; }
        public int statuscode { get; set; }
        public ResponseLogin data { get; set; }
    }
}
