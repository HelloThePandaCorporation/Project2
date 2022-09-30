using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using P2_API_Perkantoran.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace P2_MVC_Perkantoran.Controllers
{
    public class AccountController : Controller
    {
        HttpClient httpClinet;

        string address;

        public AccountController()
        {
            this.address = "https://localhost:44329/api/Account/Login";
            httpClinet = new HttpClient
            {
                BaseAddress = new Uri(address)
            };
        }
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
            var result = httpClinet.PostAsync(address, content).Result;
            if (result.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<ResponseClient>(await result.Content.ReadAsStringAsync());
                HttpContext.Session.SetString("Role", data.data.Role);
                HttpContext.Session.SetString("id", Convert.ToString(data.data.id));
                Debug.WriteLine(data);
                return RedirectToAction("index", "AdminPanel", data.data);
            }
            return View();
        }

        public async Task<IActionResult> View(AdminView adminView)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(adminView), Encoding.UTF8, "application/json");
            var result = httpClinet.PostAsync(address, content).Result;
            if (result.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<ResponseClient>(await result.Content.ReadAsStringAsync());
                
                return RedirectToAction("index1", "AdminPanel",data.data);
            }
            return View();
        }

        
    }
}
