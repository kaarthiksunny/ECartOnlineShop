using ECartOnlineShop.DataAccesLayer.Interfaces;
using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ECartOnlineShop.Controllers
{
    
    public class LoginController : Controller
    {
        private readonly ILoginServices services;
        public LoginController(ILoginServices services1)
        {
            services = services1;
        }
        [HttpGet("index")]
        public IActionResult Index(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }


        [HttpPost("index")]
        public async Task<IActionResult> Index([Bind] Login login, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var returnUrl1 = returnUrl;
            int res = services.AdminLogic(login);
            if (res == 1)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("AdminName", login.AdminName));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, login.AdminName));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                return Redirect(returnUrl1);
            }
            TempData["Error"] = "Invalid Admin Name or password";
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        //customer Login

       
        
    }
}
