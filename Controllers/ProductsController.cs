using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductServices services;
        private readonly IHostingEnvironment he;
        public ProductsController(IProductServices services1, IHostingEnvironment he1)
        {
            services = services1;
            he = he1;
        }

        // GET: ProductsController
        public ActionResult ProductsList()
        {
            List<Product> productsList = services.GetProducts().ToList();
            return View(productsList);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = services.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Product product , IFormFile image)
        {
            if(ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    image.CopyTo(new FileStream(name, FileMode.Create));
                    product.ProductImage = "Images/" + image.FileName; 
                }
                if(image == null)
                {
                    product.ProductImage = "Images/noImage.png";
                }
                services.CreateProduct(product);
                return RedirectToAction(nameof(ProductsList));
            }
            return View(product);
        }


        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = services.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind] Product product)
        {
            if (id == null) { return NotFound(); }
            if (ModelState.IsValid)
            {

                services.UpdateProduct(product);
                return RedirectToAction(nameof(ProductsList));
            }
            return View(services);
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = services.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            services.DeleteProduct(id);
            return RedirectToAction(nameof(ProductsList));

        }
    }
}
