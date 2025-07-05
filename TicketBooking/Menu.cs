using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBooking
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void movie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie f3 = new Movie();
            f3.ShowDialog();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking f3 = new Booking();
            f3.ShowDialog();
        }

        private void myBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            myBooking f4 = new myBooking();
            f4.ShowDialog();
        }

        private void userReview_Click(object sender, EventArgs e)
        {
            this.Hide();
            userReview f5 = new userReview();
            f5.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f6 = new Login();
            f6.ShowDialog();
        }

        private void movie_MouseHover(object sender, EventArgs e)
        {
            movie.BackColor = Color.Maroon;
        }

        private void movie_MouseLeave(object sender, EventArgs e)
        {
            movie.BackColor = Color.Black;
        }

        private void Booking_MouseHover(object sender, EventArgs e)
        {
            Booking.BackColor = Color.Maroon;
        }

        private void Booking_MouseLeave(object sender, EventArgs e)
        {
            Booking.BackColor = Color.Black;
        }

        private void myBooking_MouseHover(object sender, EventArgs e)
        {
            myBooking.BackColor = Color.Maroon;
        }

        private void myBooking_MouseLeave(object sender, EventArgs e)
        {
            myBooking.BackColor = Color.Black;
        }

        private void userReview_MouseHover(object sender, EventArgs e)
        {
            userReview.BackColor = Color.Maroon;
        }

        private void userReview_MouseLeave(object sender, EventArgs e)
        {
            userReview.BackColor = Color.Black;
        }

        private void logOut_MouseHover(object sender, EventArgs e)
        {
            logOut.BackColor = Color.Maroon;
        }

        private void logOut_MouseLeave(object sender, EventArgs e)
        {
            logOut.BackColor = Color.Black;
        }
    }
}
