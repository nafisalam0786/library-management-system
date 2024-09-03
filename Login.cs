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

namespace TjohnLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                  SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from login where username ='" + txtname.Text + "' and password ='" + txtpwd.Text + "' ";

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsb = new Dashboard();
                dsb.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            txtpwd.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
