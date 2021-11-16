using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using ECartOnlineShop.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Controllers
{
    public class UserProductTypesController : Controller
    {
        private readonly IProductTypesServices services;
        private readonly IProductServices productServices;
        private readonly IUserProductServices userProductServices;

        public UserProductTypesController(IProductTypesServices services1, IProductServices productServices1,IUserProductServices userProductServices1)
        {
            services = services1;
            productServices = productServices1;
            userProductServices = userProductServices1;
        }
        // GET: UserProductTypesController
        public ActionResult Index()
        {
            List<ProductTypes> productTypesList = services.GetProductTypes().ToList();
            return View(productTypesList);
        }

        
        public ActionResult UserProductsList()
        {
            List<Product> productsList = productServices.GetProducts().ToList();
            return View(productsList);
        }
        [HttpPost]
        public ActionResult UserProductsList(decimal least, decimal highest)
        {
            List<Product> productsList = productServices.GetProducts()
                .Where(c => c.ProductPrice >= least && c.ProductPrice <= highest).ToList();
            if (least == 0 || highest == 0)
            {
                productsList = productServices.GetProducts().ToList();

            }
            return View(productsList);
        }



        public ActionResult UserProduct(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = productServices.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost, ActionName("UserProduct")]
        public ActionResult UserProductDetail(int id)
        {
            List<Product> products = new List<Product>();
            if (id == null)
            {
                return NotFound();
            }
            var product = productServices.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }

            products = HttpContext.Session.Get<List<Product>>("products");
            if (products == null)
            {
                products = new List<Product>();
            }
            products.Add(product);
            HttpContext.Session.Set("products", products);
            return RedirectToAction(nameof(UserProduct));
        }
        //Remove in product page
        [HttpPost]
        public IActionResult Remove(int id)
        {
            List<Product> products = HttpContext.Session.Get<List<Product>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(c => c.ProductId == id);
                if (product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction(nameof(UserProductsList));
        }
        //Remove in Cart page
        [ActionName("Remove")]
        public IActionResult RemoveFromCart(int id)
        {
            List<Product> products = HttpContext.Session.Get<List<Product>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(c => c.ProductId == id);
                if (product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction(nameof(Cart));
        }
       
        //Get Cart
        public IActionResult Cart()
        {
            List<Product> products = HttpContext.Session.Get<List<Product>>("products");
            if (products == null)
            {
                products = new List<Product>();
            }
            return View(products);
        }

        
    }
}
