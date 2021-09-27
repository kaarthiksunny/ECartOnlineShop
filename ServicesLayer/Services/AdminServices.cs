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
    }
}
