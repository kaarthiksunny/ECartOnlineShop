using ECartOnlineShop.DataAccesLayer.Interfaces;
using ECartOnlineShop.Models;
using ECartOnlineShop.ServicesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.ServicesLayer.Services
{
    public class ProductTypesServices : IProductTypesServices
    {
        private readonly IProductTypesContext context;
        public ProductTypesServices(IProductTypesContext context1)
        {
            context = context1;
        }

        public void CreateProductType(ProductTypes productTypes)
        {
            context.CreateProductType(productTypes);
        }

        public void UpdateProductType(ProductTypes productTypes)
        {

            context.UpdateProductType(productTypes);
        }

        public void DeleteProductType(int Id)
        {
            context.DeleteProductType(Id);
        }

  
        public IEnumerable<ProductTypes> GetProductTypes()
        {
            List<ProductTypes> productTypesList = context.GetProductTypes().ToList();
            return productTypesList;
        }

        public ProductTypes GetProductType(int Id)
        {
            ProductTypes productType = context.GetProductType(Id);
            return productType;
        }
    }
}
