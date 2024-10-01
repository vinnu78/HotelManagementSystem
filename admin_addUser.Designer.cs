namespace HotelManagementSystem
{
    partial class admin_addUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Clear_btn = new Button();
            Delete_btn = new Button();
            Update_btn = new Button();
            add_btn = new Button();
            addUser_Status = new ComboBox();
            label4 = new Label();
            addUser_Role = new ComboBox();
            label3 = new Label();
            addUser_Password = new TextBox();
            label2 = new Label();
            addUser_Username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Clear_btn);
            panel1.Controls.Add(Delete_btn);
            panel1.Controls.Add(Update_btn);
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(addUser_Status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addUser_Role);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUser_Password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addUser_Username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 548);
            panel1.TabIndex = 0;
            // 
            // Clear_btn
            // 
            Clear_btn.BackColor = Color.Teal;
            Clear_btn.FlatAppearance.BorderSize = 0;
            Clear_btn.ForeColor = Color.White;
            Clear_btn.Location = new Point(15, 464);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(232, 39);
            Clear_btn.TabIndex = 11;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = false;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.Teal;
            Delete_btn.FlatAppearance.BorderSize = 0;
            Delete_btn.ForeColor = Color.White;
            Delete_btn.Location = new Point(15, 419);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(232, 39);
            Delete_btn.TabIndex = 10;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.BackColor = Color.Teal;
            Update_btn.FlatAppearance.BorderSize = 0;
            Update_btn.ForeColor = Color.White;
            Update_btn.Location = new Point(15, 352);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(232, 39);
            Update_btn.TabIndex = 9;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Teal;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(15, 307);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(232, 39);
            add_btn.TabIndex = 8;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // addUser_Status
            // 
            addUser_Status.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_Status.FormattingEnabled = true;
            addUser_Status.Items.AddRange(new object[] { "Active", "Inactive" });
            addUser_Status.Location = new Point(15, 251);
            addUser_Status.Name = "addUser_Status";
            addUser_Status.Size = new Size(232, 28);
            addUser_Status.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 228);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // addUser_Role
            // 
            addUser_Role.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_Role.FormattingEnabled = true;
            addUser_Role.Items.AddRange(new object[] { "Admin", "Customer" });
            addUser_Role.Location = new Point(15, 181);
            addUser_Role.Name = "addUser_Role";
            addUser_Role.Size = new Size(232, 28);
            addUser_Role.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 158);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // addUser_Password
            // 
            addUser_Password.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_Password.Location = new Point(15, 115);
            addUser_Password.Name = "addUser_Password";
            addUser_Password.Size = new Size(232, 27);
            addUser_Password.TabIndex = 3;
            addUser_Password.TextChanged += addUser_Password_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 92);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addUser_Username
            // 
            addUser_Username.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_Username.Location = new Point(15, 52);
            addUser_Username.Name = "addUser_Username";
            addUser_Username.Size = new Size(232, 27);
            addUser_Username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(297, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 548);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 14);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 1;
            label5.Text = "User's Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(15, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(587, 470);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // admin_addUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admin_addUser";
            Size = new Size(922, 589);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox addUser_Password;
        private Label label2;
        private TextBox addUser_Username;
        private Button add_btn;
        private ComboBox addUser_Status;
        private Label label4;
        private ComboBox addUser_Role;
        private Button Clear_btn;
        private Button Delete_btn;
        private Button Update_btn;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
