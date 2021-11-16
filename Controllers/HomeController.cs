using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ECartOnlineShop.Controllers
{
    
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductTypesServices services;

        public HomeController(ILogger<HomeController> logger, IProductTypesServices services1)
        {
            services = services1;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ProductTypes> productTypesList = services.GetProductTypes().ToList();
            return View(productTypesList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
