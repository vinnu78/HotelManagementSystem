using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

        private void admin_dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();
            }
        }

        private void admin_dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void admin_Rooms1_Load(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = false;
            admin_Rooms1.Visible = true;
            admin_customers1.Visible = false;

            admin_Rooms adrooms = admin_Rooms1 as admin_Rooms;

            if (adrooms != null)
            {
                adrooms.refreshData();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            admin_addUser1.Visible = false;
            admin_Rooms1.Visible = false;
            admin_customers1.Visible = false;

            admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;
            if(adDashboard!=null)
            {
                adDashboard.refreshData();
            }

        }

        private void admin_customers1_Load(object sender, EventArgs e)
        {

        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = false;
            admin_Rooms1.Visible = true;
            admin_customers1.Visible = false;
            
            admin_Rooms adrooms = admin_Rooms1 as admin_Rooms;

            if (adrooms != null)
            {
                adrooms.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = false;
            admin_Rooms1.Visible = false;
            admin_customers1.Visible = true;

            admin_customers adcustomer = admin_customers1 as admin_customers;
            if (adcustomer != null)
            {
                adcustomer.refreshData();
            }

        }

        private void adduser_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = true;
            admin_Rooms1.Visible = false;
            admin_customers1.Visible = false;

            admin_addUser adUser = admin_addUser1 as admin_addUser;
            if (adUser != null)
            {
                adUser.refreshData();
            }
        }
    }
}
