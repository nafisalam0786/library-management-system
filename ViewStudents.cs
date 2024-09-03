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
    public partial class ViewStudents : Form
    {
        
        public ViewStudents()
        {
            InitializeComponent();
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {

            panel5.Visible = false;
            pictureBox2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from NewStudent";

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        String studId;
        Int64 stdId;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studId = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            panel5.Visible = true;
            pictureBox2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from NewStudent where StuId=" + studId + "";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            stdId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            stName.Text = ds.Tables[0].Rows[0][1].ToString();
            stRoll.Text = ds.Tables[0].Rows[0][2].ToString();
            stDept.Text = ds.Tables[0].Rows[0][3].ToString();
            stSem.Text = ds.Tables[0].Rows[0][4].ToString();
            stContact.Text = ds.Tables[0].Rows[0][5].ToString();
            stEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void StudentRoll_TextChanged(object sender, EventArgs e)
        {
            if (StudentRoll.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from NewStudent where StudentRoll like '"+StudentRoll.Text+"%'";

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            else {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from NewStudent";

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
           
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            pictureBox2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from NewStudent";

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        
     

        private void update_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data Will be Updated,Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String stuName    = stName.Text;
                String stuRoll    = stRoll.Text;
                String stuDept    = stDept.Text;
                String stuSem     = stSem.Text;
                String stuContact = stContact.Text;
                String stuMail    = stEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewStudent Set StudentName = '" + stuName + "',StudentRoll='" + stuRoll + "',StudentDept='" + stuDept + "',StudentSemester='" + stuSem + "',StudentContact='" + stuContact + "',StudentEmail='" + stuMail + "' where StuId='" + stdId + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will be Deleted,Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from NewStudent where StuId='" + stdId + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            pictureBox2.Visible = false;
        }

      
    }
}
