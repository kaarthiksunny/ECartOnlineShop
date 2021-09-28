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
    public class ProductContext : IProductContext
    {
        readonly string connectionString = "Data Source = DESKTOP-O9F92PP\\SQLEXPRESS; Initial Catalog = EcartDb; Integrated Security = true;";

        public IEnumerable<Product> GetProducts()
        {
            var productsList = new List<Product>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Select_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
//                    product.IsAvailable = (bool)dr["IsAvailable"];
                    product.ProductCategory = dr["ProductCategory"].ToString();

                    productsList.Add(product);
                }
                con.Close();

            }
            return productsList;
        }

        public void CreateProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
                cmd.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                cmd.Parameters.AddWithValue("@ProductRating", product.ProductRating);
                cmd.Parameters.AddWithValue("@ProductImage", product.ProductImage);
                cmd.Parameters.AddWithValue("IsAvailable", product.IsAvailable);
                cmd.Parameters.AddWithValue("@ProductCategory", product.ProductCategory);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        
        public void UpdateProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Update_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
                cmd.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                cmd.Parameters.AddWithValue("@ProductRating", product.ProductRating);
                cmd.Parameters.AddWithValue("@ProductImage", product.ProductImage);
                cmd.Parameters.AddWithValue("@IsAvailable", product.IsAvailable);
                cmd.Parameters.AddWithValue("@ProductCategory", product.ProductCategory);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteProduct(int? ProductId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", ProductId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Product GetProduct(int? ProductId)
        {
            var product = new Product();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_SelectById_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", ProductId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    product.ProductId = Convert.ToInt32(dr["ProductId"].ToString());
                    product.ProductName = dr["ProductName"].ToString();
                    product.ProductPrice = Convert.ToDecimal(dr["ProductPrice"].ToString());
                    product.ProductDescription = dr["ProductDescription"].ToString();
                    product.ProductRating = dr["ProductRating"].ToString();
                    product.ProductImage = dr["ProductImage"].ToString();
  //                  product.IsAvailable = (bool)dr["IsAvailable"];
                    product.ProductCategory = dr["ProductCategory"].ToString();

                }
                con.Close();
            }
            return product;
        }

    }
}
