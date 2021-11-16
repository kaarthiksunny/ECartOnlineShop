using ECartOnlineShop.DataAccesLayer.Interfaces;
using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.ServicesLayer.Services
{
    public class UserProductServices : IUserProductServices
    {
        private readonly IUserProductContext context;
        public UserProductServices(IUserProductContext context1)
        {
            context = context1;
        }
        public IEnumerable<Product> GetProductsByCategory(int ProductCategoryId)
        {
            List<Product> productsList1 = context.GetProductsByCategory(ProductCategoryId).ToList();
            return productsList1;
        }
    }
}
