using ECartOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.DataAccesLayer.Interfaces
{
    public interface ILoginContext
    {
        public int AdminLogin(Login login);

        public int CustomerLogin(CustomerLogin login);
    }
}
