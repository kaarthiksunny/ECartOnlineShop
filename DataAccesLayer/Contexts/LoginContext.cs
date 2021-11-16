using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ECartOnlineShop.Models;
using ECartOnlineShop.DataAccesLayer.Interfaces;

namespace ECartOnlineShop.DataAccesLayer.Contexts
{
    public class LoginContext : ILoginContext
    {
        readonly string connectionString = "Data Source = DESKTOP-O9F92PP\\SQLEXPRESS; Initial Catalog = EcartDb; Integrated Security = true;";

        public int AdminLogin(Login login)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Admin_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AdminName", login.AdminName);
                cmd.Parameters.AddWithValue("@Password", login.Password);
                SqlParameter par = new SqlParameter();
                par.ParameterName = "@IsValid";
                par.SqlDbType = SqlDbType.Bit;
                par.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par);

                con.Open();
                cmd.ExecuteNonQuery();
                int res = Convert.ToInt32(par.Value);
                return res;

            }
        }

        public int CustomerLogin(CustomerLogin login)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Customer_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", login.UserName);
                cmd.Parameters.AddWithValue("@Password", login.Password);
                SqlParameter par = new SqlParameter();
                par.ParameterName = "@IsValid";
                par.SqlDbType = SqlDbType.Bit;
                par.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(par);

                con.Open();
                cmd.ExecuteNonQuery();
                int res = Convert.ToInt32(par.Value);
                return res;

            }
        }

    }
}
