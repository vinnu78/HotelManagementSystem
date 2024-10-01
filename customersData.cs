using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    class customersData
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { get; set; }
        public string BookID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNum { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string RoomID { get; set; }
        public string Price { get; set; }
        public string StatusPayment { get; set; }
        public string Status { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string BookDate { get; set; }

        public List<customersData> customerListData()
        {
            List<customersData> listData = new List<customersData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT * FROM customer ";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customersData cData = new customersData();
                        {
                            cData.ID = (int)reader["id"];
                            cData.BookID = reader["book_id"].ToString();
                            cData.FullName = reader["full_name"].ToString();
                            cData.Email = reader["email"].ToString();
                            cData.ContactNum = reader["contact"].ToString();
                            cData.Gender = reader["gender"].ToString();
                            cData.Address = reader["address"].ToString();
                            cData.RoomID = reader["room_id"].ToString();
                            cData.Price = reader["price"].ToString();
                            cData.StatusPayment = reader["status_payment"].ToString();
                            cData.Status = reader["status"].ToString();
                            cData.CheckIn = reader["date_from"].ToString();
                            cData.CheckOut = reader["date_to"].ToString();
                            cData.BookDate = reader["date_book"].ToString();

                            listData.Add(cData);
                        }

                    }
                }
                return listData;
            }
        }
    }
}
