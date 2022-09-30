using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P2_API_Perkantoran.Models;
using P2_API_Perkantoran.Repositories.data;
using P2_API_Perkantoran.Repositories.Interface;
using P2_API_Perkantoran.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private AccountRepository accountRepository;

        public AccountController(AccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }


        [HttpPost("Login")]
        public IActionResult Login(Login login)
        {
            var data = accountRepository.Login(login);
            if (data != null)
            {
                return Ok(new { message = "Berhasil Login", StatusCode = 200, data = data });
            }
            else
            {
                return BadRequest(new { message = "Gagal Login", StatusCode = 400 });
            } 
                
        }

        [HttpPost("View")]
        public IActionResult View(AdminView adminView)
        {
            var data = accountRepository.View(adminView);
            if (data != null)
            {
                return Ok(new { message = "Berhasil Mengambil data admin", StatusCode = 200, data = data });
            }
            else
            {
                return BadRequest(new { message = "Gagal Mengambil data Admin", StatusCode = 400 });
            }

        }

        [HttpPost("ProposalProve")]
        public IActionResult Proposal(ProposalProve proposalProve)
        {
            var data = accountRepository.proposal(proposalProve);
            if (data != null)
            {
                return Ok(new { message = "Berhasil Mengambil data admin", StatusCode = 200, data = data });
            }
            else
            {
                return BadRequest(new { message = "Gagal Mengambil data Admin", StatusCode = 400 });
            }

        }

        [HttpGet("ProposalProve")]
        public IActionResult Proposals(ProposalProve proposalProve)
        {
            var data = accountRepository.proposal(proposalProve);
            if (data != null)
            {
                return Ok(new { message = "Berhasil Mengambil data admin", StatusCode = 200, data = data });
            }
            else
            {
                return BadRequest(new { message = "Gagal Mengambil data Admin", StatusCode = 400 });
            }

        }


    }
}
