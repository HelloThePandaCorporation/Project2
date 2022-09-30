using Microsoft.EntityFrameworkCore;
using P2_API_Perkantoran.Models;
using P2_API_Perkantoran.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<ApprovedProposal> approvedProposals { get; set; }
        public DbSet<ProposalProve> proposalProves { get; set; }
        public DbSet<Role> roles { get; set; }
        
        public DbSet<User> users { get; set; }
        public DbSet<UserRolecs> userRoles { get; set; }
        public DbSet<AdminView> adminViews { get; set; }
    }
}
