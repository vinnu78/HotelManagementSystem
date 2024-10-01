using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    class userData
    {
        // Database connection string
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";

        // Properties
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DateReg { get; set; }

        // Method to retrieve user data
        public List<userData> listuserData()
        {
            List<userData> listData = new List<userData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        userData uData = new userData
                        {
                            ID = (int)Reader["id"],
                            Username = Reader["username"].ToString(),
                            Role = Reader["role"].ToString(),
                            Status = Reader["status"].ToString(),
                            DateReg = Reader["date_register"].ToString()
                        };

                        listData.Add(uData);
                    }
                }
            }

            return listData;
        }

        // Method to update user data
        public void UpdateUser(int id, string username, string password, string role, string status)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@usern", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to delete user
        public void DeleteUser(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string deleteData = "DELETE FROM users WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
