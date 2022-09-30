using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.Models
{
    public class ProposalProve
    {
        [Key]
        public int id { get; set; }
        public Employee employee { get; set; }
        [ForeignKey("employee")]
        public int idemployee { get; set; }
        public string note_item { get; set; }

        public virtual ApprovedProposal ApprovedProposal { get; set; }

    }
}
