using ECartOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.ServicesLayer.Interfaces
{
    public interface IAdminServices
    {
        public void CreateAdmin(Admin admin);

        public IEnumerable<Admin> GetAdmins();

        public void DeleteAdmin(int AdminId);
        public void CreateCustomer(Customer customer);

        public IEnumerable<Customer> GetCustomers();

        public void DeleteCustomer(int UserId);
    }
}
