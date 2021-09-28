using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Controllers
{
    public class ProductTypesController : Controller
    {
        private readonly IProductTypesServices services;

        public ProductTypesController(IProductTypesServices services1)
        {
            services = services1;
        }

        public IActionResult ProductTypesList()
        {
            List<ProductTypes> productTypesList = services.GetProductTypes().ToList();
            return View(productTypesList);
        }

        // GET: ProductTypesController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductTypes productType = services.GetProductType(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }

        // GET: ProductTypesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductTypesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                services.CreateProductType(productTypes);
                return RedirectToAction(nameof(ProductTypesList));
            }
            return View(productTypes);
        }

        // GET: ProductTypesController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductTypes productType = services.GetProductType(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }

        // POST: ProductTypesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,[Bind] ProductTypes productTypes) {
            if (id == null) { return NotFound(); }
            if (ModelState.IsValid)
            {

                services.UpdateProductType(productTypes);
                return RedirectToAction(nameof(ProductTypesList));
            }
            return View(services);
        }

        // GET: ProductTypesController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductTypes productType = services.GetProductType(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }

        // POST: ProductTypesController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            services.DeleteProductType(id);
            return RedirectToAction(nameof(ProductTypesList));

        }

    }
}
