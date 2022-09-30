using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.Models
{
    public class ApprovedProposalW
    {
       
        [Key]
        [ForeignKey("ProposalProve")]
        public int id { get; set; }
        public bool prove { get; set; }
        public virtual ProposalProve ProposalProve { get; set; }
    }
    
}
