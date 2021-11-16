using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Controllers
{
    [Authorize]
    public class AdminsController : Controller
    {
        
        private readonly IAdminServices services;

        public AdminsController(IAdminServices services1)
        {
            services = services1;
        }

        // GET: AdminsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Admin admin)
        {
            if (ModelState.IsValid)
            {
                services.CreateAdmin(admin);
            }
            return View(admin);
        }

        public ActionResult AdminList()
        {
            List<Admin> adminsList = services.GetAdmins().ToList();
            return View(adminsList);
        }

        public ActionResult Delete(int id)
        {

            if (id == null)
            {
                return NotFound();
            }
            services.DeleteAdmin(id);
            return RedirectToAction(nameof(AdminList));
        }

        public ActionResult CreateCustomer()
        {
            return View();
        }

        // POST: AdminsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer([Bind] Customer customer)
        {
            if (ModelState.IsValid)
            {
                services.CreateCustomer(customer);
            }
            return View(customer);
        }

        public ActionResult CustomerList()
        {
            List<Customer> customersList = services.GetCustomers().ToList();
            return View(customersList);
        }

        public ActionResult DeleteCustomer(int id)
        {

            if (id == null)
            {
                return NotFound();
            }
            services.DeleteCustomer(id);
            return RedirectToAction(nameof(CustomerList));
        }
    }
    }