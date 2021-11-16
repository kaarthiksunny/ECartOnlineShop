using ECartOnlineShop.DataAccesLayer.Interfaces;
using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.ServicesLayer.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductContext context;
        public ProductServices(IProductContext context1)
        {
            context = context1;
        }
        public IEnumerable<Product> GetProducts()
        {
            List<Product> productsList = context.GetProducts().ToList();
            return productsList;
        }
        public void CreateProduct(Product product)
        {
            context.CreateProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            context.UpdateProduct(product);
        }
        public void DeleteProduct(int ProductId)
        {
            context.DeleteProduct(ProductId);
        }
        public Product GetProduct(int ProductId)
        {
            Product product = context.GetProduct(ProductId);
            return product;
        }

        


    }
}
