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
    public class AdminContext : IAdminContext
    {
        readonly string connectionString = "Data Source = DESKTOP-O9F92PP\\SQLEXPRESS; Initial Catalog = EcartDb; Integrated Security = true;";

        public void CreateAdmin(Admin admin)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Admin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AdminName", admin.AdminName);
                cmd.Parameters.AddWithValue("@DOJ", admin.DOJ);
                cmd.Parameters.AddWithValue("@Mobile", admin.Mobile);
                cmd.Parameters.AddWithValue("@Address", admin.Address);
                cmd.Parameters.AddWithValue("@Password", admin.Password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Admin> GetAdmins()
        {
            var adminsList = new List<Admin>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Select_Admin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var admins = new Admin();
                    admins.AdminId = Convert.ToInt32(dr["AdminId"].ToString());
                    admins.AdminName = dr["AdminName"].ToString();
                    admins.DOJ = dr["DOJ"].ToString();
                    admins.Mobile = dr["Mobile"].ToString();
                    admins.Address = dr["Address"].ToString();
                    adminsList.Add(admins);
                }
                con.Close();

            }
            return adminsList;
        }

        public void DeleteAdmin(int AdminId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Admin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AdminId", AdminId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Customer

        public void CreateCustomer(Customer customer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", customer.UserName);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Mobile", customer.Mobile);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@Password", customer.Password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customersList = new List<Customer>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Select_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var customers = new Customer();
                    customers.UserId = Convert.ToInt32(dr["UserId"].ToString());
                    customers.UserName = dr["UserName"].ToString();
                    customers.Email = dr["Email"].ToString();
                    customers.Mobile = dr["Mobile"].ToString();
                    customers.Address = dr["Address"].ToString();
                    customersList.Add(customers);
                }
                con.Close();

            }
            return customersList;
        }

        public void DeleteCustomer(int UserId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", UserId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
