using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TicketBooking
{
    public partial class Booking : Form
    {
        private void ClearFields()
        {
            txtName.Text = "";
            txtNIC.Text = "";
            txtMovie.Text = "";
            txtPNo.Text = "";
            txtPrice.Text = "";
            txtseat.Text = "";
            txtticketNo.Text = "";
            txttime.Text = "";
            txtdate.Text = "";
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]



        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );
        bool expand = false;
        public Booking()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seat f3 = new Seat();
            //this.Hide();
            //Seat f1 = new Seat();
            f3.ShowDialog();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            


        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = @"INSERT INTO Booking ( Name, NIC_No, [Phone No], Movie, Date, Time, Seat, [No of Tickets],[Total Price]) VALUES (@Name, @NIC, @PNo, @Movie, @date, @time, @seat, @ticketNo, @Price)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
            cmd.Parameters.AddWithValue("@PNo", txtPNo.Text);
            cmd.Parameters.AddWithValue("@Movie", txtMovie.Text);
            cmd.Parameters.AddWithValue("@date", txtdate.Text);
            cmd.Parameters.AddWithValue("@time", txttime.Text);
            cmd.Parameters.AddWithValue("@Seat", txtseat.Text);
            cmd.Parameters.AddWithValue("@ticketNo", txtticketNo.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            conn.Open();
            cmd.ExecuteNonQuery();

            ClearFields();
            //this.Hide();
            success f1 = new success();
            f1.ShowDialog();





        }

        private void Booking_Load(object sender, EventArgs e)
        {
            confirm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, confirm.Width, confirm.Height, 50, 50));

        }

        private void confirm_MouseHover(object sender, EventArgs e)
        {
            confirm.BackColor = Color.Green;
        }

        private void confirm_MouseLeave(object sender, EventArgs e)
        {
            confirm.BackColor = Color.Maroon;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtticketNo_TextChanged(object sender, EventArgs e)
        {
            int a;
            int b = 1000;
            if (int.TryParse(txtticketNo.Text, out a))
            {
                int t = b * a;
                txtPrice.Text = "Rs:" + t.ToString();
            }
            else
            {
                txtPrice.Text = "Rs: 0";
            }

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
