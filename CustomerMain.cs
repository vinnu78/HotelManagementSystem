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
    public partial class CustomerMain : Form
    {


        public CustomerMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CustomerMain));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            logout_btn = new Button();
            customers_btn = new Button();
            adduser_btn = new Button();
            dashboard_btn = new Button();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            admin_customers1 = new admin_customers();
            customer_bookRoom2 = new Customer_bookRoom();
            admin_dashboard2 = new admin_dashboard();
            panel2.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(adduser_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 586);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // logout_btn
            // 
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(33, 537);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(152, 39);
            logout_btn.TabIndex = 5;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // customers_btn
            // 
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(33, 341);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(152, 29);
            customers_btn.TabIndex = 3;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = true;
            customers_btn.Click += customers_btn_Click;
            // 
            // adduser_btn
            // 
            adduser_btn.FlatAppearance.BorderSize = 0;
            adduser_btn.FlatStyle = FlatStyle.Flat;
            adduser_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adduser_btn.ForeColor = Color.White;
            adduser_btn.Location = new Point(33, 279);
            adduser_btn.Name = "adduser_btn";
            adduser_btn.Size = new Size(152, 29);
            adduser_btn.TabIndex = 2;
            adduser_btn.Text = "Book Rooms";
            adduser_btn.UseVisualStyleBackColor = true;
            adduser_btn.Click += adduser_btn_Click_1;
            // 
            // dashboard_btn
            // 
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(33, 225);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(152, 29);
            dashboard_btn.TabIndex = 1;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 155);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 0;
            label2.Text = "Welcome,User";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(closeBtn);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 41);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 12);
            label3.Name = "label3";
            label3.Size = new Size(246, 21);
            label3.TabIndex = 4;
            label3.Text = "Hotel Management System";
            // 
            // closeBtn
            // 
            closeBtn.BorderColor = Color.Teal;
            closeBtn.DisabledState.BorderColor = Color.DarkGray;
            closeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            closeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeBtn.FillColor = Color.Teal;
            closeBtn.Font = new Font("Segoe UI", 9F);
            closeBtn.ForeColor = Color.White;
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(1128, 1);
            closeBtn.Name = "closeBtn";
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            closeBtn.Size = new Size(36, 33);
            closeBtn.TabIndex = 3;
            closeBtn.Click += closeBtn_Click_1;
            // 
            // admin_customers1
            // 
            admin_customers1.Location = new Point(246, 39);
            admin_customers1.Name = "admin_customers1";
            admin_customers1.Size = new Size(919, 583);
            admin_customers1.TabIndex = 6;
            // 
            // customer_bookRoom2
            // 
            customer_bookRoom2.Location = new Point(246, 40);
            customer_bookRoom2.Name = "customer_bookRoom2";
            customer_bookRoom2.Size = new Size(922, 582);
            customer_bookRoom2.TabIndex = 7;
            // 
            // admin_dashboard2
            // 
            admin_dashboard2.BackColor = Color.LightGray;
            admin_dashboard2.Location = new Point(246, 39);
            admin_dashboard2.Name = "admin_dashboard2";
            admin_dashboard2.Size = new Size(919, 583);
            admin_dashboard2.TabIndex = 8;
            // 
            // CustomerMain
            // 
            ClientSize = new Size(1163, 623);
            Controls.Add(admin_dashboard2);
            Controls.Add(customer_bookRoom2);
            Controls.Add(admin_customers1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerMain";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button logout_btn;
        private Button customers_btn;
        private Button adduser_btn;
        private Button dashboard_btn;
        private Panel panel3;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private admin_customers admin_customers1;
        private Label label2;
        // private admin_dashboard admin_dashboard1;
        private Customer_bookRoom customer_bookRoom2;
        private admin_dashboard admin_dashboard2;
        // private Customer_bookRoom Customer_bookRoom1;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customer_bookRoom1_Load(object sender, EventArgs e)
        {

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

        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void closeBtn_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {

            admin_dashboard2.Visible = true;
            customer_bookRoom2.Visible = false;
            admin_customers1.Visible = false;
            admin_dashboard adDashboard = admin_dashboard2 as admin_dashboard;
            if (adDashboard != null)
            {
                adDashboard.refreshData();
            }

        }

        private void adduser_btn_Click_1(object sender, EventArgs e)
        {
            admin_dashboard2.Visible = false;
            customer_bookRoom2.Visible = true;
            admin_customers1.Visible = false;
            Customer_bookRoom adbookRoom = customer_bookRoom2 as Customer_bookRoom;

            if (adbookRoom != null)
            {
                adbookRoom.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard2.Visible = false;
            customer_bookRoom2.Visible = false;
            admin_customers1.Visible = true;

            admin_customers adcustomers = admin_customers1 as admin_customers;

            if (adcustomers != null)
            {
                adcustomers.refreshData();
            }
        }
    }
}


