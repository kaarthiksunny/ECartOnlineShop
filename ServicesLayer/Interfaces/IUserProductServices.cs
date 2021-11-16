using ECartOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.ServicesLayer.Interfaces
{
    public interface IUserProductServices
    {
        public IEnumerable<Product> GetProductsByCategory(int ProductCategoryId);
    }
}
