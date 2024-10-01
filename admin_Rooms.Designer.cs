namespace HotelManagementSystem
{
    partial class admin_Rooms
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            rooms_clearBtn = new Button();
            rooms_deleteBtn = new Button();
            rooms_updateBtn = new Button();
            rooms_addBtn = new Button();
            rooms_importBtn = new Button();
            panel4 = new Panel();
            rooms_picture = new PictureBox();
            rooms_status = new ComboBox();
            rooms_price = new TextBox();
            label5 = new Label();
            label6 = new Label();
            rooms__type = new ComboBox();
            rooms_roomName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            rooms_roomID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rooms_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(17, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 292);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "Room's Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(851, 230);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 238);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(rooms_clearBtn);
            panel3.Controls.Add(rooms_deleteBtn);
            panel3.Controls.Add(rooms_updateBtn);
            panel3.Controls.Add(rooms_addBtn);
            panel3.Controls.Add(rooms_importBtn);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(rooms_status);
            panel3.Controls.Add(rooms_price);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(rooms__type);
            panel3.Controls.Add(rooms_roomName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(rooms_roomID);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(17, 336);
            panel3.Name = "panel3";
            panel3.Size = new Size(889, 238);
            panel3.TabIndex = 1;
            // 
            // rooms_clearBtn
            // 
            rooms_clearBtn.BackColor = Color.Teal;
            rooms_clearBtn.FlatAppearance.BorderSize = 0;
            rooms_clearBtn.ForeColor = Color.White;
            rooms_clearBtn.Location = new Point(483, 176);
            rooms_clearBtn.Name = "rooms_clearBtn";
            rooms_clearBtn.Size = new Size(114, 39);
            rooms_clearBtn.TabIndex = 20;
            rooms_clearBtn.Text = "Clear";
            rooms_clearBtn.UseVisualStyleBackColor = false;
            rooms_clearBtn.Click += rooms_clearBtn_Click;
            // 
            // rooms_deleteBtn
            // 
            rooms_deleteBtn.BackColor = Color.Teal;
            rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            rooms_deleteBtn.ForeColor = Color.White;
            rooms_deleteBtn.Location = new Point(340, 176);
            rooms_deleteBtn.Name = "rooms_deleteBtn";
            rooms_deleteBtn.Size = new Size(114, 39);
            rooms_deleteBtn.TabIndex = 19;
            rooms_deleteBtn.Text = "Delete";
            rooms_deleteBtn.UseVisualStyleBackColor = false;
            rooms_deleteBtn.Click += rooms_deleteBtn_Click;
            // 
            // rooms_updateBtn
            // 
            rooms_updateBtn.BackColor = Color.Teal;
            rooms_updateBtn.FlatAppearance.BorderSize = 0;
            rooms_updateBtn.ForeColor = Color.White;
            rooms_updateBtn.Location = new Point(207, 176);
            rooms_updateBtn.Name = "rooms_updateBtn";
            rooms_updateBtn.Size = new Size(114, 39);
            rooms_updateBtn.TabIndex = 18;
            rooms_updateBtn.Text = "Update";
            rooms_updateBtn.UseVisualStyleBackColor = false;
            rooms_updateBtn.Click += rooms_updateBtn_Click;
            // 
            // rooms_addBtn
            // 
            rooms_addBtn.BackColor = Color.Teal;
            rooms_addBtn.FlatAppearance.BorderSize = 0;
            rooms_addBtn.ForeColor = Color.White;
            rooms_addBtn.Location = new Point(64, 176);
            rooms_addBtn.Name = "rooms_addBtn";
            rooms_addBtn.Size = new Size(114, 39);
            rooms_addBtn.TabIndex = 17;
            rooms_addBtn.Text = "Add";
            rooms_addBtn.UseVisualStyleBackColor = false;
            rooms_addBtn.Click += rooms_addBtn_Click;
            // 
            // rooms_importBtn
            // 
            rooms_importBtn.BackColor = Color.Teal;
            rooms_importBtn.FlatAppearance.BorderSize = 0;
            rooms_importBtn.ForeColor = Color.White;
            rooms_importBtn.Location = new Point(755, 150);
            rooms_importBtn.Name = "rooms_importBtn";
            rooms_importBtn.Size = new Size(114, 39);
            rooms_importBtn.TabIndex = 16;
            rooms_importBtn.Text = "Import";
            rooms_importBtn.UseVisualStyleBackColor = false;
            rooms_importBtn.Click += rooms_importBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(rooms_picture);
            panel4.Location = new Point(755, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(114, 125);
            panel4.TabIndex = 15;
            // 
            // rooms_picture
            // 
            rooms_picture.Location = new Point(0, 0);
            rooms_picture.Name = "rooms_picture";
            rooms_picture.Size = new Size(114, 125);
            rooms_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            rooms_picture.TabIndex = 0;
            rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            rooms_status.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_status.FormattingEnabled = true;
            rooms_status.Items.AddRange(new object[] { "Active", "Inactive", "Occupied" });
            rooms_status.Location = new Point(488, 66);
            rooms_status.Name = "rooms_status";
            rooms_status.Size = new Size(207, 28);
            rooms_status.TabIndex = 14;
            // 
            // rooms_price
            // 
            rooms_price.BorderStyle = BorderStyle.FixedSingle;
            rooms_price.Location = new Point(488, 28);
            rooms_price.Name = "rooms_price";
            rooms_price.Size = new Size(179, 25);
            rooms_price.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(403, 27);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 12;
            label5.Text = "Price($):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(416, 69);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Status:";
            // 
            // rooms__type
            // 
            rooms__type.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms__type.FormattingEnabled = true;
            rooms__type.Items.AddRange(new object[] { "Single Room", "Double Room" });
            rooms__type.Location = new Point(142, 71);
            rooms__type.Name = "rooms__type";
            rooms__type.Size = new Size(214, 28);
            rooms__type.TabIndex = 10;
            // 
            // rooms_roomName
            // 
            rooms_roomName.BorderStyle = BorderStyle.FixedSingle;
            rooms_roomName.Location = new Point(142, 119);
            rooms_roomName.Name = "rooms_roomName";
            rooms_roomName.Size = new Size(179, 25);
            rooms_roomName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 119);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 8;
            label4.Text = "Room Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 74);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Type:";
            // 
            // rooms_roomID
            // 
            rooms_roomID.BorderStyle = BorderStyle.FixedSingle;
            rooms_roomID.Location = new Point(142, 27);
            rooms_roomID.Name = "rooms_roomID";
            rooms_roomID.Size = new Size(179, 25);
            rooms_roomID.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 28);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Room ID:";
            // 
            // admin_Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "admin_Rooms";
            Size = new Size(922, 589);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rooms_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label1;
        private TextBox rooms_roomName;
        private Label label4;
        private Label label3;
        private TextBox rooms_roomID;
        private Label label2;
        private ComboBox rooms__type;
        private ComboBox rooms_status;
        private TextBox rooms_price;
        private Label label5;
        private Label label6;
        private Button rooms_importBtn;
        private Panel panel4;
        private PictureBox rooms_picture;
        private Button rooms_clearBtn;
        private Button rooms_deleteBtn;
        private Button rooms_updateBtn;
        private Button rooms_addBtn;
    }
}
