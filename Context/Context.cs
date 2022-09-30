using Microsoft.EntityFrameworkCore;
using P2_API_Perkantoran.Models;
using P2_MVC_Perkantoran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_MVC_Perkantoran.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> dbContext) : base(dbContext)
        {

        }

        //public DbSet<Employee> employees { get; set; }
        public DbSet<ApprovedProposalW> approvedProposals { get; set; }
        public DbSet<ProposalProveW> proposalProves { get; set; }
        //public DbSet<Role> roles { get; set; }

        //public DbSet<User> users { get; set; }
        //public DbSet<UserRolecs> userRoles { get; set; }
        //public DbSet<AdminView> adminViews { get; set; }
    }
}
