namespace HotelManagementSystem
{
    partial class Customer_bookRoom
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
            panel7 = new Panel();
            bookRoom_regPrice = new Label();
            label3 = new Label();
            bookRoom_clearBtn = new Button();
            bookRoom_sheduleBtn = new Button();
            bookRoom_to = new DateTimePicker();
            label15 = new Label();
            bookRoom_from = new DateTimePicker();
            label14 = new Label();
            bookRoom_bookBtn = new Button();
            bookRoom_total = new Label();
            label9 = new Label();
            bookRoom_status = new Label();
            label13 = new Label();
            bookRoom_roomName = new Label();
            label11 = new Label();
            bookRoom_roomType = new Label();
            label7 = new Label();
            bookRoom_roomID = new Label();
            label4 = new Label();
            panel5 = new Panel();
            panel9 = new Panel();
            bookRoom_imageView = new PictureBox();
            panel6 = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel4 = new Panel();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookRoom_imageView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(bookRoom_regPrice);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(bookRoom_clearBtn);
            panel7.Controls.Add(bookRoom_sheduleBtn);
            panel7.Controls.Add(bookRoom_to);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(bookRoom_from);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(bookRoom_bookBtn);
            panel7.Controls.Add(bookRoom_total);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(bookRoom_status);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(bookRoom_roomName);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(bookRoom_roomType);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(bookRoom_roomID);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(577, 20);
            panel7.Name = "panel7";
            panel7.Size = new Size(321, 549);
            panel7.TabIndex = 11;
            // 
            // bookRoom_regPrice
            // 
            bookRoom_regPrice.AutoSize = true;
            bookRoom_regPrice.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_regPrice.Location = new Point(135, 196);
            bookRoom_regPrice.Name = "bookRoom_regPrice";
            bookRoom_regPrice.Size = new Size(40, 18);
            bookRoom_regPrice.TabIndex = 30;
            bookRoom_regPrice.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 196);
            label3.Name = "label3";
            label3.Size = new Size(123, 18);
            label3.TabIndex = 29;
            label3.Text = "Regular Price($) :";
            // 
            // bookRoom_clearBtn
            // 
            bookRoom_clearBtn.BackColor = Color.Teal;
            bookRoom_clearBtn.FlatAppearance.BorderSize = 0;
            bookRoom_clearBtn.ForeColor = Color.White;
            bookRoom_clearBtn.Location = new Point(31, 492);
            bookRoom_clearBtn.Name = "bookRoom_clearBtn";
            bookRoom_clearBtn.Size = new Size(271, 41);
            bookRoom_clearBtn.TabIndex = 28;
            bookRoom_clearBtn.Text = "Clear";
            bookRoom_clearBtn.UseVisualStyleBackColor = false;
            bookRoom_clearBtn.Click += bookRoom_clearBtn_Click;
            // 
            // bookRoom_sheduleBtn
            // 
            bookRoom_sheduleBtn.BackColor = Color.Teal;
            bookRoom_sheduleBtn.FlatAppearance.BorderSize = 0;
            bookRoom_sheduleBtn.ForeColor = Color.White;
            bookRoom_sheduleBtn.Location = new Point(31, 331);
            bookRoom_sheduleBtn.Name = "bookRoom_sheduleBtn";
            bookRoom_sheduleBtn.Size = new Size(272, 42);
            bookRoom_sheduleBtn.TabIndex = 26;
            bookRoom_sheduleBtn.Text = "Schedule Now";
            bookRoom_sheduleBtn.UseVisualStyleBackColor = false;
            bookRoom_sheduleBtn.Click += bookRoom_sheduleBtn_Click;
            // 
            // bookRoom_to
            // 
            bookRoom_to.Location = new Point(135, 286);
            bookRoom_to.Name = "bookRoom_to";
            bookRoom_to.Size = new Size(167, 27);
            bookRoom_to.TabIndex = 25;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(34, 292);
            label15.Name = "label15";
            label15.Size = new Size(95, 18);
            label15.TabIndex = 24;
            label15.Text = "To Schedule:";
            // 
            // bookRoom_from
            // 
            bookRoom_from.Location = new Point(135, 241);
            bookRoom_from.Name = "bookRoom_from";
            bookRoom_from.Size = new Size(167, 27);
            bookRoom_from.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 247);
            label14.Name = "label14";
            label14.Size = new Size(113, 18);
            label14.TabIndex = 22;
            label14.Text = "From Schedule:";
            // 
            // bookRoom_bookBtn
            // 
            bookRoom_bookBtn.BackColor = Color.Teal;
            bookRoom_bookBtn.FlatAppearance.BorderSize = 0;
            bookRoom_bookBtn.ForeColor = Color.White;
            bookRoom_bookBtn.Location = new Point(30, 433);
            bookRoom_bookBtn.Name = "bookRoom_bookBtn";
            bookRoom_bookBtn.Size = new Size(272, 41);
            bookRoom_bookBtn.TabIndex = 21;
            bookRoom_bookBtn.Text = "Book";
            bookRoom_bookBtn.UseVisualStyleBackColor = false;
            bookRoom_bookBtn.Click += bookRoom_bookBtn_Click;
            // 
            // bookRoom_total
            // 
            bookRoom_total.AutoSize = true;
            bookRoom_total.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_total.Location = new Point(193, 401);
            bookRoom_total.Name = "bookRoom_total";
            bookRoom_total.Size = new Size(44, 20);
            bookRoom_total.TabIndex = 20;
            bookRoom_total.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(71, 400);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 19;
            label9.Text = "Total Price($):";
            // 
            // bookRoom_status
            // 
            bookRoom_status.AutoSize = true;
            bookRoom_status.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_status.Location = new Point(134, 156);
            bookRoom_status.Name = "bookRoom_status";
            bookRoom_status.Size = new Size(74, 18);
            bookRoom_status.TabIndex = 18;
            bookRoom_status.Text = "-----------";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(70, 156);
            label13.Name = "label13";
            label13.Size = new Size(58, 18);
            label13.TabIndex = 17;
            label13.Text = "Status :";
            // 
            // bookRoom_roomName
            // 
            bookRoom_roomName.AutoSize = true;
            bookRoom_roomName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_roomName.Location = new Point(134, 112);
            bookRoom_roomName.Name = "bookRoom_roomName";
            bookRoom_roomName.Size = new Size(74, 18);
            bookRoom_roomName.TabIndex = 14;
            bookRoom_roomName.Text = "-----------";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(30, 112);
            label11.Name = "label11";
            label11.Size = new Size(98, 18);
            label11.TabIndex = 13;
            label11.Text = "Room Name:";
            // 
            // bookRoom_roomType
            // 
            bookRoom_roomType.AutoSize = true;
            bookRoom_roomType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_roomType.Location = new Point(134, 66);
            bookRoom_roomType.Name = "bookRoom_roomType";
            bookRoom_roomType.Size = new Size(74, 18);
            bookRoom_roomType.TabIndex = 12;
            bookRoom_roomType.Text = "-----------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 66);
            label7.Name = "label7";
            label7.Size = new Size(90, 18);
            label7.TabIndex = 11;
            label7.Text = "Room Type:";
            // 
            // bookRoom_roomID
            // 
            bookRoom_roomID.AutoSize = true;
            bookRoom_roomID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookRoom_roomID.Location = new Point(134, 18);
            bookRoom_roomID.Name = "bookRoom_roomID";
            bookRoom_roomID.Size = new Size(74, 18);
            bookRoom_roomID.TabIndex = 10;
            bookRoom_roomID.Text = "-----------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 18);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 9;
            label4.Text = "Room ID:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(25, 369);
            panel5.Name = "panel5";
            panel5.Size = new Size(531, 200);
            panel5.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.Controls.Add(bookRoom_imageView);
            panel9.Location = new Point(17, 12);
            panel9.Name = "panel9";
            panel9.Size = new Size(498, 172);
            panel9.TabIndex = 8;
            // 
            // bookRoom_imageView
            // 
            bookRoom_imageView.Location = new Point(0, 0);
            bookRoom_imageView.Name = "bookRoom_imageView";
            bookRoom_imageView.Size = new Size(498, 172);
            bookRoom_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            bookRoom_imageView.TabIndex = 0;
            bookRoom_imageView.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(3, 361);
            panel6.Name = "panel6";
            panel6.Size = new Size(515, 191);
            panel6.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(25, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 334);
            panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(501, 281);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 8;
            label1.Text = "Available Rooms";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(3, 361);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 191);
            panel4.TabIndex = 7;
            // 
            // Customer_bookRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "Customer_bookRoom";
            Size = new Size(922, 589);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookRoom_imageView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button bookRoom_clearBtn;
        private Button bookRoom_sheduleBtn;
        private DateTimePicker bookRoom_to;
        private Label label15;
        private DateTimePicker bookRoom_from;
        private Label label14;
        private Button bookRoom_bookBtn;
        private Label bookRoom_total;
        private Label label9;
        private Label bookRoom_status;
        private Label label13;
        private Label bookRoom_roomName;
        private Label label11;
        private Label bookRoom_roomType;
        private Label label7;
        private Label bookRoom_roomID;
        private Label label4;
        private Panel panel5;
        private Panel panel9;
        private PictureBox bookRoom_imageView;
        private Panel panel6;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel4;
        private PropertyGrid propertyGrid1;
        private Label bookRoom_regPrice;
        private Label label3;
    }
}
