using ECartOnlineShop.DataAccesLayer.Interfaces;
using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.ServicesLayer.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly ILoginContext context;
        public LoginServices(ILoginContext context1)
        {
            context = context1;
        }
        public int AdminLogic(Login login)
        {
            int res = context.AdminLogin(login);
            return res;
        }

        public int CustomerLogin(CustomerLogin login)
        {
            int res = context.CustomerLogin(login);
            return res;
        }
    }
}
