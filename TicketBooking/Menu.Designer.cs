namespace TicketBooking
{
    partial class menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            movie = new Button();
            Booking = new Button();
            myBooking = new Button();
            userReview = new Button();
            logOut = new Button();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "film.jpg");
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkRed;
            panelHeader.Controls.Add(label10);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(panel2);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2157, 74);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2086, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Location = new Point(453, 77);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1399, 897);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(movie);
            flowLayoutPanel1.Controls.Add(Booking);
            flowLayoutPanel1.Controls.Add(myBooking);
            flowLayoutPanel1.Controls.Add(userReview);
            flowLayoutPanel1.Controls.Add(logOut);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 1104);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 77);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 16);
            label1.Margin = new Padding(20, 0, 20, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 55);
            label1.TabIndex = 4;
            label1.Text = "Menu";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(3, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(406, 75);
            panel3.TabIndex = 6;
            // 
            // movie
            // 
            movie.BackColor = Color.Black;
            movie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movie.ForeColor = Color.White;
            movie.Location = new Point(0, 164);
            movie.Margin = new Padding(0);
            movie.Name = "movie";
            movie.Size = new Size(400, 120);
            movie.TabIndex = 3;
            movie.Text = "Movies";
            movie.UseVisualStyleBackColor = false;
            movie.Click += movie_Click;
            movie.MouseLeave += movie_MouseLeave;
            movie.MouseHover += movie_MouseHover;
            // 
            // Booking
            // 
            Booking.BackColor = Color.Black;
            Booking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Booking.ForeColor = Color.White;
            Booking.Location = new Point(0, 284);
            Booking.Margin = new Padding(0);
            Booking.Name = "Booking";
            Booking.Size = new Size(400, 120);
            Booking.TabIndex = 2;
            Booking.Text = "Book Now";
            Booking.UseVisualStyleBackColor = false;
            Booking.Click += Booking_Click;
            Booking.MouseLeave += Booking_MouseLeave;
            Booking.MouseHover += Booking_MouseHover;
            // 
            // myBooking
            // 
            myBooking.BackColor = Color.Black;
            myBooking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myBooking.ForeColor = Color.White;
            myBooking.Location = new Point(0, 404);
            myBooking.Margin = new Padding(0);
            myBooking.Name = "myBooking";
            myBooking.Size = new Size(400, 120);
            myBooking.TabIndex = 4;
            myBooking.Text = "My Bookings";
            myBooking.UseVisualStyleBackColor = false;
            myBooking.Click += myBooking_Click;
            myBooking.MouseLeave += myBooking_MouseLeave;
            myBooking.MouseHover += myBooking_MouseHover;
            // 
            // userReview
            // 
            userReview.BackColor = Color.Black;
            userReview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userReview.ForeColor = Color.White;
            userReview.Location = new Point(0, 524);
            userReview.Margin = new Padding(0);
            userReview.Name = "userReview";
            userReview.Size = new Size(400, 120);
            userReview.TabIndex = 8;
            userReview.Text = "User Reviews";
            userReview.UseVisualStyleBackColor = false;
            userReview.Click += userReview_Click;
            userReview.MouseLeave += userReview_MouseLeave;
            userReview.MouseHover += userReview_MouseHover;
            // 
            // logOut
            // 
            logOut.BackColor = Color.Black;
            logOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOut.ForeColor = Color.White;
            logOut.Location = new Point(0, 644);
            logOut.Margin = new Padding(0);
            logOut.Name = "logOut";
            logOut.Size = new Size(400, 120);
            logOut.TabIndex = 9;
            logOut.Text = "Log Out";
            logOut.UseVisualStyleBackColor = false;
            logOut.Click += logOut_Click;
            logOut.MouseLeave += logOut_MouseLeave;
            logOut.MouseHover += logOut_MouseHover;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(3, 767);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 350);
            panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 182);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(161, 143);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-5, 168);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(402, 199);
            button1.TabIndex = 0;
            button1.Text = "                   User";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(380, 59);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1797, 1129);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkRed;
            label10.Font = new Font("Lucida Bright", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SandyBrown;
            label10.Location = new Point(955, 16);
            label10.Name = "label10";
            label10.Size = new Size(247, 42);
            label10.TabIndex = 3;
            label10.Text = "MOVIEMINT";
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2157, 1178);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelHeader);
            Controls.Add(pictureBox4);
            Name = "menu";
            Text = "Menu";
            Load += menu_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private ImageList imageList2;
        private Panel panelHeader;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button Booking;
        private Label label1;
        private Button movie;
        private Panel panel3;
        private PageSetupDialog pageSetupDialog1;
        private Button myBooking;
        private Button userReview;
        private Button logOut;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button button1;
        private PictureBox pictureBox4;
        private Label label10;
    }
}