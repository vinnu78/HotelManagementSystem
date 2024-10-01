using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class admin_Rooms : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";

        public admin_Rooms()
        {
            InitializeComponent();
            displayRoomsData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;

            }
            displayRoomsData();
        }
        public void displayRoomsData()
        {
            roomsData rData = new roomsData();
            List<roomsData> listD = rData.roomsDataList();

            dataGridView1.DataSource = listD;

        }

        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(rooms_roomID.Text) ||
    string.IsNullOrEmpty(rooms_roomName.Text) ||
    rooms__type.SelectedIndex == -1 ||
    rooms_status.SelectedIndex == -1 ||
    string.IsNullOrEmpty(rooms_price.Text) ||
    rooms_picture.Image == null) // Checks if an image is uploaded
            {
                return true;
            }
            return false;
        }

        private void rooms_addBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill in all the blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
                // Step 2: Database connection setup (replace 'conn' with your connection string variable)
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    // Step 3: Check if the Room ID already exists in the database
                    string checkRoomID = "SELECT room_id FROM rooms WHERE room_id = @roomID";
                    using (SqlCommand checkRID = new SqlCommand(checkRoomID, connect))
                    {
                        checkRID.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkRID);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0) // Room ID already exists
                        {
                            MessageBox.Show(rooms_roomID.Text.Trim() + " already exists.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Step 4: Insert new room data into the database
                            string insertData = "INSERT INTO rooms (room_id, type, room_name, price, image_path, status, date_register) " +
                                                "VALUES (@roomID, @type, @name, @price, @path, @status, @date_reg)";
                            string path = Path.Combine(@"D:\HotelManagementSystem\HotelManagementSystem\assets\", rooms_roomID.Text.Trim());

                            // Extract directory from the path
                            string directoryPath = Path.GetDirectoryName(path);

                            // Check if the directory exists, if not, create it
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            // Copy the selected image to the defined directory
                            File.Copy(rooms_picture.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());
                                cmd.Parameters.AddWithValue("@type", rooms__type.SelectedItem.ToString()); // Selected room type
                                cmd.Parameters.AddWithValue("@name", rooms_roomName.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@path", rooms_picture.ImageLocation); // Assuming ImageLocation holds the file path of the image
                                cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString()); // Selected room status

                                DateTime today = DateTime.Today; // Today's date
                                cmd.Parameters.AddWithValue("@date_reg", today);
                                cmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }

                    }
                }
        }

        private void rooms_updateBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please Select Item First.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to UPDATE ID:" + id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();

                            string updateData = "UPDATE rooms SET room_id=@roomID, type=@type, room_name=@name, price=@price, image_path=@path, status=@status, date_update=@update WHERE id=@id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());
                                cmd.Parameters.AddWithValue("@type", rooms__type.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@name", rooms_roomName.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@path", rooms_picture.ImageLocation);
                                cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@update", today);
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                                clearFields();
                                displayRoomsData();

                                MessageBox.Show("Update Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rooms_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                 OpenFileDialog file = new OpenFileDialog();
                    string imagePath = "";

                    // Filter to include only JPEG and PNG image formats
                    file.Filter = "Image Files (*.jpeg; *.jpg; *.png)|*.jpeg;*.jpg;*.png";

                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        imagePath = file.FileName;
                        rooms_picture.ImageLocation = imagePath;
                    }
                }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;

                rooms_roomID.Text = row.Cells[1].Value.ToString();
                rooms_roomName.Text = row.Cells[3].Value.ToString();
                rooms__type.Text = row.Cells[2].Value.ToString();
                rooms_status.Text = row.Cells[6].Value.ToString();
                rooms_price.Text = row.Cells[4].Value.ToString();
                rooms_picture.ImageLocation = row.Cells[5].Value.ToString();


            }
        }
        public void clearFields()
        {
            rooms_roomID.Text = "";
            rooms_roomName.Text = "";
            rooms__type.SelectedIndex = -1;
            rooms_status.SelectedIndex = -1;
            rooms_price.Text = "";
            rooms_picture.Text = null;




        }
        private void rooms_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void rooms_deleteBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please Select Item First.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    // Log the current id value
                    MessageBox.Show("Current ID: " + id);

                    // Check if id has been properly assigned
                    if (id == 0)
                    {
                        MessageBox.Show("No valid ID selected for deletion.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show("Are you sure you want to DELETE ID: " + id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();

                            string updateData = "UPDATE rooms SET date_delete=@delete WHERE id=@id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@delete", today);
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                                clearFields();
                                displayRoomsData();

                                MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show detailed error message with stack trace
                    MessageBox.Show("Something went wrong: " + ex.Message + "\n" + ex.StackTrace, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}







