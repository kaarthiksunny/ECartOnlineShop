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
    }
}
