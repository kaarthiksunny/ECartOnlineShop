using ECartOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.DataAccesLayer.Interfaces
{
     public interface IProductContext
    {
        public IEnumerable<Product> GetProducts();
        public void CreateProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int? ProductId);
        public Product GetProduct(int? ProductId);

       
    }
}
