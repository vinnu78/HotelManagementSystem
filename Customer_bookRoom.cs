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
    public partial class Customer_bookRoom : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelManagementSystem\HotelManagementSystem\hotels.mdf;Integrated Security=True;Connect Timeout=30";

        public Customer_bookRoom()
        {
            InitializeComponent();
            displayRooms();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker) refreshData);
                return;

            }
    displayRooms();
}
public void displayRooms()
        {
            roomsData rData = new roomsData();
            List<roomsData> listData = rData.roomsDataList();

            dataGridView1.DataSource = listData;
        }
        private int getID = 0;
        private decimal regprice = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                bookRoom_roomID.Text = row.Cells[1].Value.ToString();
                bookRoom_roomType.Text = row.Cells[2].Value.ToString();
                bookRoom_roomName.Text = row.Cells[3].Value.ToString();
                bookRoom_status.Text = row.Cells[6].Value.ToString();
                bookRoom_regPrice.Text = (Convert.ToInt32(row.Cells[4].Value)).ToString("0.00");



                regprice = Convert.ToDecimal(row.Cells[4].Value);

                bookRoom_imageView.ImageLocation = row.Cells[5].Value.ToString();
            }
        }

        private void bookRoom_sheduleBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = bookRoom_from.Value;
            DateTime toDate = bookRoom_to.Value;

            TimeSpan CountDays = toDate - fromDate;

            int days = (int)CountDays.Days;
            decimal totalprice = (days * regprice);
            if (totalprice < 0)
            {
                MessageBox.Show("Something went Wrong:3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookRoom_total.Text = "0.00";
            }
            else if (totalprice == 0)
            {
                bookRoom_total.Text = regprice.ToString("0.00");
            }
            else
            {
                bookRoom_total.Text = (days * regprice).ToString("0.00");
            }



        }

        private void bookRoom_bookBtn_Click(object sender, EventArgs e)
        {
            if (regprice == 0 || bookRoom_total.Text == "0'00")
            {
                MessageBox.Show("Please fill all info correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bookRoom_status.Text != "Active")
            {

                MessageBox.Show("The room is Unavailable", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hotelData.roomID = bookRoom_roomID.Text;
                hotelData.fromDate = bookRoom_from.Value;
                hotelData.toDate = bookRoom_to.Value;
                hotelData.price = bookRoom_total.Text;



                Form formbg = new Form();

                try
                {
                    using (clientinfo ciForm = new clientinfo())
                    {
                        //formbg.StartPosition = FormStartPosition.Manual;
                        //formbg.FormBorderStyle = FormBorderStyle.None;
                        //formbg.Opacity = .80d;
                        //formbg.BackColor = Color.Black;
                        //formbg.WindowState = FormWindowState.Normal;
                        //formbg.TopMost = true;
                        //formbg.Location = this.Location;
                        //formbg.ShowInTaskbar = false;
                        //formbg.Show();

                        ciForm.Owner = formbg;
                        ciForm.ShowDialog();

                        formbg.Dispose();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    formbg.Dispose();

                }

            }


        }
        public void clearFields()
        {
            bookRoom_roomID.Text = "---------";
            bookRoom_roomType.Text = "---------";
            bookRoom_roomName.Text = "---------";
            bookRoom_status.Text = "---------";
            bookRoom_roomID.Text = "---------";
            bookRoom_total.Text = "0.00";
            bookRoom_regPrice.Text = "0.00";

            bookRoom_imageView.Image = null;

        }
        private void bookRoom_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
