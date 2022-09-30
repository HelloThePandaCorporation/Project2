using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.Models
{
    public class User
    {
        
        
        [Key]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public string Password { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
