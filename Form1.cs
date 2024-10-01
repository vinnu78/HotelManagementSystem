using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";
        public Login()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    // Corrected SQL query
                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass AND status = @status";


                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Login successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            string selectRole = "SELECT role FROM users WHERE username=@usern AND password=@pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());

                                getRole.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                if (userRole == "Admin")
                                {

                                    AdminMain AdminForm = new AdminMain();
                                    AdminForm.Show();

                                    this.Hide();
                                }
                                else if (userRole == "Customer")
                                {
                                    CustomerMain CustomerForm = new CustomerMain();
                                    CustomerForm.Show();

                                    this.Hide();

                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration RegForm = new Registration();
            RegForm.Show();
            this.Hide();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

