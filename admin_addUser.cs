using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class admin_addUser : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";
        private int id; // Store the user ID for updating

        public admin_addUser()
        {
            InitializeComponent();
            displayData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;

            }
            displayData();
        }

        public void displayData()
        {
            userData uData = new userData();
            dataGridView1.DataSource = uData.listuserData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
                    if (e.RowIndex != -1 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        id = Convert.ToInt32(row.Cells[0].Value); // Ensure ID is being captured

                        addUser_Username.Text = row.Cells[1].Value?.ToString();
                        addUser_Password.Text = row.Cells[2].Value?.ToString();
                        addUser_Role.SelectedItem = row.Cells[3].Value?.ToString();
                        addUser_Status.SelectedItem = row.Cells[4].Value?.ToString();
                    }
                }

            

            private void add_btn_Click(object sender, EventArgs e)
        {
            if (addUser_Username.Text == "" || addUser_Password.Text == "" || addUser_Role.SelectedIndex == -1 || addUser_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkUsern = "SELECT username FROM users WHERE username = @usern";
                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", addUser_Username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show($"{addUser_Username.Text} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (addUser_Username.Text.Length < 8)
                        {
                            MessageBox.Show("Username must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string InsertData = "INSERT INTO users (username, password, role, status, date_register) " +
                                                "VALUES (@usern, @pass, @role, @status, @regDate)";
                            using (SqlCommand cmd = new SqlCommand(InsertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", addUser_Username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", addUser_Password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", addUser_Role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addUser_Status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@regDate", DateTime.Today);

                                cmd.ExecuteNonQuery();
                                clearFields();
                                displayData();
                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }


        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (addUser_Username.Text == "" || addUser_Password.Text == "" || addUser_Role.SelectedIndex == -1 || addUser_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (id == 0)
            {
                MessageBox.Show("Please select a user to update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userData uData = new userData();
                uData.UpdateUser(id, addUser_Username.Text.Trim(), addUser_Password.Text.Trim(), addUser_Role.SelectedItem.ToString(), addUser_Status.SelectedItem.ToString());
                clearFields();
                displayData();
                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select a user to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    userData uData = new userData();
                    uData.DeleteUser(id);
                    clearFields();
                    displayData();
                    MessageBox.Show("User deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            addUser_Username.Text = "";
            addUser_Password.Text = "";
            addUser_Role.SelectedItem = null;
            addUser_Status.SelectedItem = null;
            id = 0; // Reset the ID to ensure no user is selected
        }

        private void addUser_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
