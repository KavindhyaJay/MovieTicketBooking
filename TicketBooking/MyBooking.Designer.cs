namespace TicketBooking
{
    partial class myBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myBooking));
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panelHeader = new Panel();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(919, 272);
            label1.Name = "label1";
            label1.Size = new Size(418, 50);
            label1.TabIndex = 0;
            label1.Text = "Search Your Bookings";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1095, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 39);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2037, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkRed;
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Controls.Add(label10);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2109, 74);
            panelHeader.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Asset_1;
            pictureBox2.Location = new Point(3, -6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkRed;
            label10.Font = new Font("Lucida Bright", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SandyBrown;
            label10.Location = new Point(976, 13);
            label10.Name = "label10";
            label10.Size = new Size(247, 42);
            label10.TabIndex = 3;
            label10.Text = "MOVIEMINT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(878, 397);
            label8.Name = "label8";
            label8.Size = new Size(129, 45);
            label8.TabIndex = 24;
            label8.Text = "NIC No";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 677);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2084, 153);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // search
            // 
            search.BackColor = Color.Maroon;
            search.BackgroundImageLayout = ImageLayout.None;
            search.FlatStyle = FlatStyle.Popup;
            search.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.ForeColor = Color.White;
            search.Location = new Point(998, 510);
            search.Margin = new Padding(0);
            search.Name = "search";
            search.Size = new Size(211, 54);
            search.TabIndex = 26;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += confirm_Click;
            search.MouseLeave += search_MouseLeave;
            search.MouseHover += search_MouseHover;
            // 
            // myBooking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1883;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2109, 1039);
            Controls.Add(search);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(panelHeader);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "myBooking";
            Text = "My Booking";
            Load += myBooking_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panelHeader;
        private Label label10;
        private Label label8;
        private DataGridView dataGridView1;
        private Button search;
        private PictureBox pictureBox2;
    }
}