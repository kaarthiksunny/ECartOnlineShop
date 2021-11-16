using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using ECartOnlineShop.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Controllers
{
    public class UserProductsController : Controller
    {
        private readonly IUserProductServices services;
        public UserProductsController(IUserProductServices services1)
        {
            services = services1;
        }

   
        public ActionResult UserProductsByCategory(int id)
        {
          //  if (ProductCategory == null)
            //{
              //  return NotFound();
            //}
            List<Product> products = services.GetProductsByCategory(id).ToList();
            if (products == null)
            {
                return NotFound();
            }
            return View(products);

        }
        [HttpPost]
        public ActionResult UserProductsByCategory(decimal least, decimal highest,int id)
        {
            List<Product> productsList = services.GetProductsByCategory(id)
                .Where(c => c.ProductPrice >= least && c.ProductPrice <= highest).ToList();
            if (least == 0 || highest == 0)
            {
                productsList = services.GetProductsByCategory(id).ToList();

            }
            return View(productsList);
        }

        
    }
}
