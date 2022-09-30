using Microsoft.EntityFrameworkCore;
using P2_API_Perkantoran.Context;
using P2_API_Perkantoran.Models;
using P2_API_Perkantoran.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.Repositories.data
{
    public class AccountRepository
    {
        MyContext myContext;

        public AccountRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        
        public ResponseLogin Login(Login login)
        {
            var data = myContext.userRoles
                 .Include(x => x.role)
                 .Include(x => x.user)
                 .Include(x => x.user.Employee)
                 .FirstOrDefault(x =>
                     x.user.Employee.Email.Equals(login.Email) &&
                     x.user.Password.Equals(login.Password));

            
            if (data != null)
            {
                ResponseLogin responseLogin = new ResponseLogin()
                {
                    id = data.user.Employee.id,
                    Fullname = data.user.Employee.FullName,
                    Email = data.user.Employee.Email,
                    Role = data.role.Name
                };
                return responseLogin;
            }
            else
            return null;
        }

        public AdminView View(AdminView adminView)
        {
            var data = myContext.userRoles.Include(x => x.user).
                Include(x => x.user.Employee).Include(x => x.role).FirstOrDefault();
            AdminView adminView1 = new AdminView()
            {
                id = data.id,
                FullName = data.user.Employee.FullName,
                Email = data.user.Employee.Email,
                Role = data.RoleId,
                Name = data.role.Name,
                Userid = data.UserId,
                Alamat = data.user.Employee.Alamat,
                Gender = data.user.Employee.Gender
            };
                

                
            return adminView;
        }

        public ProposalProve proposal(ProposalProve proposal)
        {
            var data = myContext.proposalProves.Include(x => x.ApprovedProposal).FirstOrDefault();
            ProposalProve proposalProve = new ProposalProve
            {
                id = data.id,
                idemployee = data.idemployee,
                note_item = data.note_item

            };
            return proposalProve;
        }

        
    
    }
}
