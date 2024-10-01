using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Registration : Form
    {
        // Corrected connection string
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";

        public Registration()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtCPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    // Query to check if the username already exists
                    string checkUsern = "SELECT username FROM users WHERE username = @usern";

                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string tempEmail = txtUsername.Text.Substring(0, 1).ToUpper() + txtUsername.Text.Substring(1);
                            MessageBox.Show($"{tempEmail} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtPassword.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password, must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtPassword.Text != txtCPassword.Text)
                        {
                            MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Correct SQL query without parameter duplication
                            string query = "INSERT INTO users (username, password, role, status, date_register) " +
                                           "VALUES (@usern, @pass, @role, @status, @regDate)";

                            // Debugging Output to verify the query structure
                            Console.WriteLine("Query: " + query);
                            Console.WriteLine($"Username: {txtUsername.Text.Trim()}");
                            Console.WriteLine($"Password: {txtPassword.Text.Trim()}");

                            using (SqlCommand cmd = new SqlCommand(query, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Customer");
                                cmd.Parameters.AddWithValue("@status", "Active");

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@regDate", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Redirect to login form after successful registration
                                Login loginForm = new Login();
                                loginForm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckedChanged triggered!");
            txtPassword.PasswordChar = ShowPass.Checked ? '\0' : '*';
            txtCPassword.PasswordChar = ShowPass.Checked ? '\0' : '*';
        }
    }
}
