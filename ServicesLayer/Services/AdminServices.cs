using ECartOnlineShop.DataAccesLayer.Interfaces;
using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ECartOnlineShop.ServicesLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IAdminContext dbContext;

        public AdminServices(IAdminContext dbContext1)
        {
            dbContext = dbContext1;
        }

        public void CreateAdmin(Admin admin)
        {
            dbContext.CreateAdmin(admin);
        }

        public IEnumerable<Admin> GetAdmins()
        {
            List<Admin> adminsList = dbContext.GetAdmins().ToList();
            return adminsList;
        }

        public void DeleteAdmin(int AdminId)
        {
            dbContext.DeleteAdmin(AdminId);
        }

        public void CreateCustomer(Customer customer)
        {
            dbContext.CreateCustomer(customer);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            List<Customer> customersList = dbContext.GetCustomers().ToList();
            return customersList;
        }

        public void DeleteCustomer(int UserId)
        {
            dbContext.DeleteCustomer(UserId);
        }

    }
}
