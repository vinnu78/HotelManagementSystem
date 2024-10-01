using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class admin_dashboard : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";

        public admin_dashboard()
        {
            InitializeComponent();
            displayTotalcustomer();
            displayprofitToday();
            displaytotalProfit();
            displayAllRooms();
            displayAvailableRooms();  // Call to display available rooms
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalcustomer();
            displayprofitToday();
            displaytotalProfit();
            displayAllRooms();
            displayAvailableRooms();  // Refresh available rooms data
        }

        public void displayAllRooms()
        {
            roomsData rData = new roomsData();
            List<roomsData> listData = rData.roomsDataList();
            dataGridView1.DataSource = listData;
        }

        public void displayTotalcustomer()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT COUNT(id) FROM users WHERE role='customer'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalCustomer.Text = result.ToString();
                    }
                }
            }
        }

        public void displayAvailableRooms()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT COUNT(id) FROM rooms WHERE status='Active' OR status='Available'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        AvailableRooms.Text = result.ToString();
                    }
                }
            }
        }

        public void displayprofitToday()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT SUM(price) FROM customer WHERE date_book=@dbook";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@dbook", today);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        profitToday.Text = "$" + result.ToString() + ".00";
                    }
                }
            }
        }

        public void displaytotalProfit()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT SUM(price) FROM customer";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalProfit.Text = "$" + result.ToString() + ".00";
                    }
                }
            }
        }

        // Logout button click event
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        // Common logout method
        private void Logout()
        {
            // Create an instance of the login form
            Login loginForm = new Login();

            // Hide the current dashboard
            this.ParentForm.Hide();

            // Show the login form
            loginForm.ShowDialog();
        }
    }
}
