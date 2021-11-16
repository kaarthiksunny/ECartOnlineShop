using ECartOnlineShop.DataAccesLayer.Interfaces;
using ECartOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.DataAccesLayer.Contexts
{
    public class UserProductContext : IUserProductContext
    {
        readonly string connectionString = "Data Source = DESKTOP-O9F92PP\\SQLEXPRESS; Initial Catalog = EcartDb; Integrated Security = true;";

        public IEnumerable<Product> GetProductsByCategory(int ProductCategoryId)
        {
            var productsList = new List<Product>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_SelectByCategory_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductCategoryId", ProductCategoryId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var product = new Product();
                    product.ProductId = Convert.ToInt32(dr["ProductId"].ToString());
                    product.ProductName = dr["ProductName"].ToString();
                    product.ProductPrice = Convert.ToDecimal(dr["ProductPrice"].ToString());
                    product.ProductDescription = dr["ProductDescription"].ToString();
                    product.ProductRating = dr["ProductRating"].ToString();
                    product.ProductImage = dr["ProductImage"].ToString();

                    product.ProductCategory = dr["ProductCategory"].ToString();

                    productsList.Add(product);
                }
                con.Close();

            }
            return productsList;
        }
    }
}
