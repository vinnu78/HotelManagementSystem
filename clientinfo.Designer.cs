namespace HotelManagementSystem
{
    partial class clientinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientinfo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            client_exitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            label3 = new Label();
            closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            label4 = new Label();
            client_bookID = new Label();
            label7 = new Label();
            label11 = new Label();
            label13 = new Label();
            panel1 = new Panel();
            client_clearBtn = new Button();
            client_bookBtn = new Button();
            client_address = new TextBox();
            label2 = new Label();
            client_gender = new ComboBox();
            client_contact = new TextBox();
            client_email = new TextBox();
            client_fullName = new TextBox();
            label1 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(client_exitBtn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(closeBtn);
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(849, 42);
            panel3.TabIndex = 6;
            // 
            // client_exitBtn
            // 
            client_exitBtn.BorderColor = Color.Teal;
            client_exitBtn.DisabledState.BorderColor = Color.DarkGray;
            client_exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            client_exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            client_exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            client_exitBtn.FillColor = Color.Teal;
            client_exitBtn.Font = new Font("Segoe UI", 9F);
            client_exitBtn.ForeColor = Color.White;
            client_exitBtn.Image = (Image)resources.GetObject("client_exitBtn.Image");
            client_exitBtn.Location = new Point(810, 3);
            client_exitBtn.Name = "client_exitBtn";
            client_exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            client_exitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            client_exitBtn.Size = new Size(36, 33);
            client_exitBtn.TabIndex = 5;
            client_exitBtn.Click += client_exitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 12);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 4;
            label3.Text = "Client's Information";
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
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            closeBtn.Size = new Size(36, 33);
            closeBtn.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 41);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 31;
            label4.Text = "Book ID:";
            // 
            // client_bookID
            // 
            client_bookID.AutoSize = true;
            client_bookID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            client_bookID.Location = new Point(198, 41);
            client_bookID.Name = "client_bookID";
            client_bookID.Size = new Size(74, 18);
            client_bookID.TabIndex = 32;
            client_bookID.Text = "-----------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(104, 89);
            label7.Name = "label7";
            label7.Size = new Size(89, 18);
            label7.TabIndex = 33;
            label7.Text = "Full Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(76, 141);
            label11.Name = "label11";
            label11.Size = new Size(121, 18);
            label11.TabIndex = 35;
            label11.Text = "Email Address:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(54, 200);
            label13.Name = "label13";
            label13.Size = new Size(141, 18);
            label13.TabIndex = 37;
            label13.Text = "Contact Number :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(client_clearBtn);
            panel1.Controls.Add(client_bookBtn);
            panel1.Controls.Add(client_address);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(client_gender);
            panel1.Controls.Add(client_contact);
            panel1.Controls.Add(client_email);
            panel1.Controls.Add(client_fullName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(client_bookID);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 464);
            panel1.TabIndex = 7;
            // 
            // client_clearBtn
            // 
            client_clearBtn.BackColor = Color.Teal;
            client_clearBtn.FlatAppearance.BorderSize = 0;
            client_clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            client_clearBtn.ForeColor = Color.White;
            client_clearBtn.Location = new Point(487, 364);
            client_clearBtn.Name = "client_clearBtn";
            client_clearBtn.Size = new Size(210, 50);
            client_clearBtn.TabIndex = 46;
            client_clearBtn.Text = "Clear";
            client_clearBtn.UseVisualStyleBackColor = false;
            client_clearBtn.Click += client_clearBtn_Click;
            // 
            // client_bookBtn
            // 
            client_bookBtn.BackColor = Color.Teal;
            client_bookBtn.FlatAppearance.BorderSize = 0;
            client_bookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            client_bookBtn.ForeColor = Color.White;
            client_bookBtn.Location = new Point(93, 364);
            client_bookBtn.Name = "client_bookBtn";
            client_bookBtn.Size = new Size(210, 50);
            client_bookBtn.TabIndex = 45;
            client_bookBtn.Text = "Book Now";
            client_bookBtn.UseVisualStyleBackColor = false;
            client_bookBtn.Click += client_bookBtn_Click;
            // 
            // client_address
            // 
            client_address.BorderStyle = BorderStyle.FixedSingle;
            client_address.Location = new Point(533, 138);
            client_address.Multiline = true;
            client_address.Name = "client_address";
            client_address.Size = new Size(185, 86);
            client_address.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(449, 141);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 43;
            label2.Text = "Address:";
            // 
            // client_gender
            // 
            client_gender.FormattingEnabled = true;
            client_gender.Items.AddRange(new object[] { "Male", "Female" });
            client_gender.Location = new Point(533, 85);
            client_gender.Name = "client_gender";
            client_gender.Size = new Size(185, 28);
            client_gender.TabIndex = 42;
            // 
            // client_contact
            // 
            client_contact.BorderStyle = BorderStyle.FixedSingle;
            client_contact.Location = new Point(198, 197);
            client_contact.Name = "client_contact";
            client_contact.Size = new Size(185, 27);
            client_contact.TabIndex = 41;
            // 
            // client_email
            // 
            client_email.BorderStyle = BorderStyle.FixedSingle;
            client_email.Location = new Point(198, 141);
            client_email.Name = "client_email";
            client_email.Size = new Size(185, 27);
            client_email.TabIndex = 40;
            // 
            // client_fullName
            // 
            client_fullName.BorderStyle = BorderStyle.FixedSingle;
            client_fullName.Location = new Point(198, 85);
            client_fullName.Name = "client_fullName";
            client_fullName.Size = new Size(185, 27);
            client_fullName.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 89);
            label1.Name = "label1";
            label1.Size = new Size(68, 18);
            label1.TabIndex = 38;
            label1.Text = "Gender:";
            // 
            // clientinfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 536);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientinfo";
            Text = "clintinfo";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private Label label4;
        private Label client_bookID;
        private Label label7;
        private Label label11;
        private Label label13;
        private Panel panel1;
        private ComboBox client_gender;
        private TextBox client_contact;
        private TextBox client_email;
        private TextBox client_fullName;
        private Label label1;
        private TextBox client_address;
        private Label label2;
        private Button client_clearBtn;
        private Button client_bookBtn;
        private Guna.UI2.WinForms.Guna2CircleButton client_exitBtn;
    }
}