using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P2_API_Perkantoran.Models;
using P2_API_Perkantoran.Context;

namespace P2_MVC_Perkantoran.Controllers
{
    public class AdminPanelController : Controller
    {
        
        AccountController accountController;
        MyContext myContext;
        public AdminPanelController(AccountController accountController,  MyContext myContext)
        {
            this.accountController = accountController;
            this.myContext = myContext;
        }
        
        /*ResponseLogin responseLogin;

        public AdminPanelController(ResponseLogin responseLogin)
        {
            this.responseLogin = responseLogin;
        }*/
        public AdminPanelController()
        {

        }
        public IActionResult Index1()
        {
            var data = accountController.View();
            return View(data);
        }
        public IActionResult Index()
        {
           
            var role = HttpContext.Session.GetString("Role");
            if (role.Equals("Admin"))
            {
                var data = accountController.Login();
                
                return View(data);
            }
            else
            {
                return RedirectToAction("Unauthorized", "ErrorPage");
            }
            
        }
        
       
        
    }
}
