namespace HotelManagementSystem
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            logout_btn = new Button();
            rooms_btn = new Button();
            customers_btn = new Button();
            adduser_btn = new Button();
            dashboard_btn = new Button();
            label2 = new Label();
            admin_customers1 = new admin_customers();
            admin_Rooms1 = new admin_Rooms();
            admin_addUser1 = new admin_addUser();
            admin_dashboard1 = new admin_dashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 39);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(246, 21);
            label1.TabIndex = 4;
            label1.Text = "Hotel Management System";
            label1.Click += label1_Click;
            // 
            // btnExit
            // 
            btnExit.BorderColor = Color.Teal;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Teal;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1128, 1);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(36, 33);
            btnExit.TabIndex = 3;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(rooms_btn);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(adduser_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-2, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 589);
            panel2.TabIndex = 1;
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
            // rooms_btn
            // 
            rooms_btn.FlatAppearance.BorderSize = 0;
            rooms_btn.FlatStyle = FlatStyle.Flat;
            rooms_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_btn.ForeColor = Color.White;
            rooms_btn.Location = new Point(33, 343);
            rooms_btn.Name = "rooms_btn";
            rooms_btn.Size = new Size(152, 29);
            rooms_btn.TabIndex = 4;
            rooms_btn.Text = "Rooms";
            rooms_btn.UseVisualStyleBackColor = true;
            rooms_btn.Click += rooms_btn_Click;
            // 
            // customers_btn
            // 
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(33, 400);
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
            adduser_btn.Text = "Add User";
            adduser_btn.UseVisualStyleBackColor = true;
            adduser_btn.Click += adduser_btn_Click;
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
            label2.Size = new Size(126, 17);
            label2.TabIndex = 0;
            label2.Text = "Welcome,Admin";
            label2.Click += label2_Click;
            // 
            // admin_customers1
            // 
            admin_customers1.Location = new Point(241, 38);
            admin_customers1.Name = "admin_customers1";
            admin_customers1.Size = new Size(921, 586);
            admin_customers1.TabIndex = 2;
            admin_customers1.Load += admin_customers1_Load;
            // 
            // admin_Rooms1
            // 
            admin_Rooms1.Location = new Point(241, 33);
            admin_Rooms1.Name = "admin_Rooms1";
            admin_Rooms1.Size = new Size(924, 591);
            admin_Rooms1.TabIndex = 7;
            // 
            // admin_addUser1
            // 
            admin_addUser1.Location = new Point(241, 33);
            admin_addUser1.Name = "admin_addUser1";
            admin_addUser1.Size = new Size(921, 591);
            admin_addUser1.TabIndex = 8;
            // 
            // admin_dashboard1
            // 
            admin_dashboard1.BackColor = Color.LightGray;
            admin_dashboard1.Location = new Point(241, 33);
            admin_dashboard1.Name = "admin_dashboard1";
            admin_dashboard1.Size = new Size(924, 591);
            admin_dashboard1.TabIndex = 7;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1163, 623);
            Controls.Add(admin_dashboard1);
            Controls.Add(admin_addUser1);
            Controls.Add(admin_Rooms1);
            Controls.Add(admin_customers1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMain";
            Text = "AdminMain";
            Load += AdminMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Panel panel2;
        private Label label2;
        private Button dashboard_btn;
        private Button logout_btn;
        private Button rooms_btn;
        private Button customers_btn;
        private Button adduser_btn;
        private PictureBox pictureBox1;
        private admin_customers admin_customers1;
        private admin_Rooms admin_Rooms1;
        private admin_addUser admin_addUser1;
        private admin_dashboard admin_dashboard1;
    }
}