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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

       
             
        

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            return_roll.Clear();
        }

        String bookName;
        String bookDate;
        Int64 rowId;
        String studentroll;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) 
            {
                rowId = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                studentroll = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                bookName = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bookDate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            return_BookName.Text = bookName;
            r_Issue_Date.Text = bookDate;

        }

        private void r_return_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IssueReturnBook Set Book_Return_Date = '" + dateTimePicker1.Text + "' where Std_Roll = '" + studentroll + "' and id = '"+rowId+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            UpdateBook();
            if (dateTimePicker1.Value.Date != DateTime.Now.Date)
            {
                MessageBox.Show("Books should be Return on current date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Book Returned Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnBook_Load(this, null);
                dataGridView1.Visible = false;
            }

        }
        private void UpdateBook()
        {
            Int64 bookQuantity, newqty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText ="select bookQuantity from Notebook where bookName='" + return_BookName.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter sdr1 = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sdr1.SelectCommand = cmd;
            sdr1.Fill(ds);
            bookQuantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            newqty = bookQuantity + 1;
            string query1 ="update NoteBook set bookQuantity=" + newqty + " where bookName='" + return_BookName.Text + "'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }


        private void return_roll_TextChanged(object sender, EventArgs e)
        {
            if (return_roll.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * from IssueReturnBook where Std_Roll like '" + return_roll.Text + "%' and Book_Return_Date is null";

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
          
        }

        
        private void return_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void r_cancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
