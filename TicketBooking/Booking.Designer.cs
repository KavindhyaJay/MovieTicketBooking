namespace TicketBooking
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            book = new Label();
            txtticketNo = new TextBox();
            pictureBox1 = new PictureBox();
            panelHeader = new Panel();
            label10 = new Label();
            txtMovie = new ComboBox();
            txtdate = new DateTimePicker();
            txttime = new DateTimePicker();
            txtseat = new TextBox();
            button1 = new Button();
            txtPrice = new TextBox();
            confirm = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            txtNIC = new TextBox();
            label9 = new Label();
            txtPNo = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(798, 128);
            label1.Name = "label1";
            label1.Size = new Size(423, 78);
            label1.TabIndex = 0;
            label1.Text = "New Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(882, 305);
            label2.Name = "label2";
            label2.Size = new Size(114, 45);
            label2.TabIndex = 1;
            label2.Text = "Movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(886, 432);
            label3.Name = "label3";
            label3.Size = new Size(90, 45);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(892, 554);
            label4.Name = "label4";
            label4.Size = new Size(94, 45);
            label4.TabIndex = 3;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(892, 675);
            label5.Name = "label5";
            label5.Size = new Size(84, 45);
            label5.TabIndex = 4;
            label5.Text = "Seat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(892, 805);
            label6.Name = "label6";
            label6.Size = new Size(228, 45);
            label6.TabIndex = 5;
            label6.Text = "No. of Tickets\r\n";
            // 
            // book
            // 
            book.AutoSize = true;
            book.BackColor = Color.Transparent;
            book.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            book.ForeColor = Color.WhiteSmoke;
            book.Location = new Point(892, 936);
            book.Name = "book";
            book.Size = new Size(177, 45);
            book.TabIndex = 6;
            book.Text = "Total Price";
            // 
            // txtticketNo
            // 
            txtticketNo.Location = new Point(1195, 813);
            txtticketNo.Multiline = true;
            txtticketNo.Name = "txtticketNo";
            txtticketNo.Size = new Size(228, 37);
            txtticketNo.TabIndex = 12;
            txtticketNo.TextChanged += txtticketNo_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1943, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkRed;
            panelHeader.Controls.Add(label10);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2014, 74);
            panelHeader.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkRed;
            label10.Font = new Font("Lucida Bright", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SandyBrown;
            label10.Location = new Point(849, 12);
            label10.Name = "label10";
            label10.Size = new Size(247, 42);
            label10.TabIndex = 2;
            label10.Text = "MOVIEMINT";
            // 
            // txtMovie
            // 
            txtMovie.FormattingEnabled = true;
            txtMovie.Items.AddRange(new object[] { "Select a Movie:", "Dark Knight Rises", "Inception", "Intestellar", "Openheimer", "Tenet", "The Prestige - Part II" });
            txtMovie.Location = new Point(1195, 305);
            txtMovie.Name = "txtMovie";
            txtMovie.Size = new Size(228, 40);
            txtMovie.TabIndex = 15;
            // 
            // txtdate
            // 
            txtdate.CustomFormat = "yyyy.MM.dd";
            txtdate.Format = DateTimePickerFormat.Custom;
            txtdate.Location = new Point(1195, 432);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(228, 39);
            txtdate.TabIndex = 16;
            // 
            // txttime
            // 
            txttime.CustomFormat = "hh:mm";
            txttime.Format = DateTimePickerFormat.Time;
            txttime.Location = new Point(1195, 560);
            txttime.Name = "txttime";
            txttime.ShowUpDown = true;
            txttime.Size = new Size(228, 39);
            txttime.TabIndex = 17;
            txttime.Value = new DateTime(2025, 6, 29, 16, 53, 0, 0);
            // 
            // txtseat
            // 
            txtseat.Location = new Point(1195, 675);
            txtseat.Multiline = true;
            txtseat.Name = "txtseat";
            txtseat.Size = new Size(102, 45);
            txtseat.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(1306, 675);
            button1.Name = "button1";
            button1.Size = new Size(117, 45);
            button1.TabIndex = 19;
            button1.Text = "Seatings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1195, 943);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(228, 37);
            txtPrice.TabIndex = 13;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // confirm
            // 
            confirm.BackColor = Color.Maroon;
            confirm.BackgroundImageLayout = ImageLayout.None;
            confirm.FlatStyle = FlatStyle.Popup;
            confirm.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm.ForeColor = Color.White;
            confirm.Location = new Point(886, 1088);
            confirm.Margin = new Padding(0);
            confirm.Name = "confirm";
            confirm.Size = new Size(283, 77);
            confirm.TabIndex = 20;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = false;
            confirm.Click += confirm_Click;
            confirm.MouseLeave += confirm_MouseLeave;
            confirm.MouseHover += confirm_MouseHover;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1572, 406);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(327, 481);
            dataGridView1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(206, 298);
            label7.Name = "label7";
            label7.Size = new Size(108, 45);
            label7.TabIndex = 22;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(206, 426);
            label8.Name = "label8";
            label8.Size = new Size(129, 45);
            label8.TabIndex = 23;
            label8.Text = "NIC No";
            // 
            // txtName
            // 
            txtName.Location = new Point(431, 305);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 38);
            txtName.TabIndex = 24;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(431, 434);
            txtNIC.Multiline = true;
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(282, 37);
            txtNIC.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(206, 553);
            label9.Name = "label9";
            label9.Size = new Size(169, 45);
            label9.TabIndex = 26;
            label9.Text = "Phone No";
            // 
            // txtPNo
            // 
            txtPNo.Location = new Point(431, 561);
            txtPNo.Multiline = true;
            txtPNo.Name = "txtPNo";
            txtPNo.Size = new Size(282, 37);
            txtPNo.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1883;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2014, 1389);
            Controls.Add(pictureBox2);
            Controls.Add(txtPNo);
            Controls.Add(label9);
            Controls.Add(txtNIC);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(confirm);
            Controls.Add(button1);
            Controls.Add(txtseat);
            Controls.Add(txttime);
            Controls.Add(txtdate);
            Controls.Add(txtMovie);
            Controls.Add(panelHeader);
            Controls.Add(txtPrice);
            Controls.Add(txtticketNo);
            Controls.Add(book);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label book;
        private TextBox txtticketNo;
        private PictureBox pictureBox1;
        private Panel panelHeader;
        private ComboBox txtMovie;
        private DateTimePicker txtdate;
        private DateTimePicker txttime;
        private TextBox txtseat;
        private Button button1;
        private TextBox txtPrice;
        private Button confirm;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private TextBox txtNIC;
        private Label label9;
        private TextBox txtPNo;
        private PictureBox pictureBox2;
        private Label label10;
    }
}