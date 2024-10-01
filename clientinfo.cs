using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class clientinfo : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";

        public clientinfo()
        {
            InitializeComponent();
            displayBookID();
        }

        private void client_exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void displayBookID()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                int getBookID = 0;
                string selectBID = "SELECT COUNT(id) FROM customer";
                using (SqlCommand cmd = new SqlCommand(selectBID, connect))
                {
                    getBookID = Convert.ToInt32(cmd.ExecuteScalar());
                    getBookID += 1; // Increment to get new Booking ID
                }
                client_bookID.Text = $"BID.{getBookID}";
            }
        }

        private void client_bookBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to book now?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(client_fullName.Text) || client_gender.SelectedIndex == -1 || string.IsNullOrWhiteSpace(client_address.Text)
                    || string.IsNullOrWhiteSpace(client_email.Text) || string.IsNullOrWhiteSpace(client_contact.Text) || string.IsNullOrWhiteSpace(hotelData.roomID))
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();
                            string insertData = "INSERT INTO customer(book_id, full_name, email, contact, gender, address, room_id, price, status_payment, status, date_from, date_to, date_book) " +
                                                "VALUES (@book_ID, @full_name, @email, @contact, @gender, @address, @roomID, @price, @statusP, @status, @dateFrom, @dateTo, @dateBook)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@book_ID", client_bookID.Text);
                                cmd.Parameters.AddWithValue("@full_name", client_fullName.Text); // Use .Text here
                                cmd.Parameters.AddWithValue("@email", client_email.Text);
                                cmd.Parameters.AddWithValue("@contact", client_contact.Text);
                                cmd.Parameters.AddWithValue("@gender", client_gender.Text);
                                cmd.Parameters.AddWithValue("@address", client_address.Text);
                                cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);
                                cmd.Parameters.AddWithValue("@price", hotelData.price);
                                cmd.Parameters.AddWithValue("@statusP", "paid");
                                cmd.Parameters.AddWithValue("@status", "Checked In");
                                cmd.Parameters.AddWithValue("@dateFrom", hotelData.fromDate);
                                cmd.Parameters.AddWithValue("@dateTo", hotelData.toDate);

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@dateBook", today);

                                cmd.ExecuteNonQuery();
                                updateRoomsStatus();

                                MessageBox.Show("Booked Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void updateRoomsStatus()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string updateStatus = "UPDATE rooms SET status = @status WHERE room_id = @roomID";
                using (SqlCommand cmd = new SqlCommand(updateStatus, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Unavailable");
                    cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void client_clearBtn_Click(object sender, EventArgs e)
        {
            client_fullName.Text = "";
            client_email.Text = "";
            client_contact.Text = "";
            client_gender.SelectedIndex = -1;
            client_address.Text = "";
        }
    }
}
