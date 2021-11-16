using ECartOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.DataAccesLayer.Interfaces
{
    public interface IAdminContext
    {
        public void CreateAdmin(Admin admin);

        public IEnumerable<Admin> GetAdmins();

        public void DeleteAdmin(int AdminId);
        public void CreateCustomer(Customer customer);

        public IEnumerable<Customer> GetCustomers();

        public void DeleteCustomer(int UserId);
    }
}
