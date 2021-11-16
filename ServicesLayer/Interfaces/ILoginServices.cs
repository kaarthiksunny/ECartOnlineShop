using ECartOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.ServicesLayer.Interfaces
{
    public interface ILoginServices
    {
        public int AdminLogic(Login login);
        public int CustomerLogin(CustomerLogin login);
    }
}
