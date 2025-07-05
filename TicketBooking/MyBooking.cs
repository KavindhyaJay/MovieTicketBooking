using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace TicketBooking
{
    public partial class myBooking : Form
    {
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
        private void ApplyCreativeStyle()
        {
            // General settings
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Column width and row height
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 35;

            // Header styling
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 0, 0); // Dark maroon
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;

            // Cell style
            dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 51, 51); // Lighter maroon for selection
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternate row color for better readability
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;

            // Grid line styling
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;

            // Remove row headers (the small empty column on the left)
            dataGridView1.RowHeadersVisible = false;
        }



        public myBooking()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            var nic = Convert.ToInt32(textBox1.Text);
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            string query = "SELECT * FROM Booking WHERE NIC_NO = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", nic);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fetches data
                    dataGridView1.DataSource = table; // Binds to grid view
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            ApplyCreativeStyle();
        }


        private void myBooking_Load(object sender, EventArgs e)
        {
            search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, search.Width, search.Height, 50, 50));
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = Color.Green;
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = Color.Maroon;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.ShowDialog();
        }
    }
}
