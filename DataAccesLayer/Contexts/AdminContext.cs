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

    }
}
