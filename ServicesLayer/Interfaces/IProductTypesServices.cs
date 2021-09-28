using ECartOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.ServicesLayer.Interfaces
{
    public interface IProductTypesServices
    {
        public void CreateProductType(ProductTypes productTypes);

        public void UpdateProductType(ProductTypes productTypes);

        public void DeleteProductType(int Id);

        public ProductTypes GetProductType(int Id);
        public IEnumerable<ProductTypes> GetProductTypes();
    }
}
