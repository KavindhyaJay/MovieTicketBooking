using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketBooking
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email, password;

            email = txtEmail.Text;
            password = txtPassword.Text;

            try
            {
                String querry = "SELECT *  FROM login  WHERE Email = '"+txtEmail.Text+"' AND Password = '"+txtPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    email = txtEmail.Text;
                    password = txtPassword.Text;

                    //page that needed to be load next
                    this.Hide();
                    menu f2 = new menu();
                    f2.ShowDialog();
                    
                }
                else 
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtPassword.Clear();

                    //to focus username
                    txtEmail.Focus();
                }
                 
            }
            catch(Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
                
        }
    }
}
