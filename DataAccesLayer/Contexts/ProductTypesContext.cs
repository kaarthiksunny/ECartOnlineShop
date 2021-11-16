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
    public class ProductTypesContext : IProductTypesContext
    {
        readonly string connectionString = "Data Source = DESKTOP-O9F92PP\\SQLEXPRESS; Initial Catalog = EcartDb; Integrated Security = true;";

        public void CreateProductType(ProductTypes productTypes)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Create_ProductType", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductType", productTypes.ProductType);
                cmd.Parameters.AddWithValue("@ProductTypeImage", productTypes.ProductTypeImage);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public void UpdateProductType(ProductTypes productTypes)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Update_ProductType", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", productTypes.Id);
                cmd.Parameters.AddWithValue("@ProductType", productTypes.ProductType);
                cmd.Parameters.AddWithValue("@ProductTypeImage", productTypes.ProductTypeImage);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<ProductTypes> GetProductTypes()
        {
            var productTypesList = new List<ProductTypes>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Select_ProductType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var productTypes = new ProductTypes();
                    productTypes.Id = Convert.ToInt32(dr["Id"].ToString());
                    productTypes.ProductType = dr["ProductType"].ToString();
                    productTypes.ProductTypeImage = dr["ProductTypeImage"].ToString();
                    productTypesList.Add(productTypes);
                }
                con.Close();

            }
            return productTypesList;
        }

        public void DeleteProductType(int Id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_ProductType", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public ProductTypes GetProductType(int Id)
        {
            var productTypes = new ProductTypes();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_SelectById_ProductType", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    productTypes.Id = Convert.ToInt32(dr["Id"].ToString());
                    productTypes.ProductType = dr["ProductType"].ToString();
                    productTypes.ProductTypeImage = dr["ProductTypeImage"].ToString();
                }
                con.Close();
            }
            return productTypes;
        }

        
    }
}
