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
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            pictureBox3.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from NoteBook";

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int bookId;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bookId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel4.Visible = true;
            pictureBox3.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from NoteBook where bookId="+bookId+"";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            bname.Text = ds.Tables[0].Rows[0][1].ToString();
            bauthor.Text = ds.Tables[0].Rows[0][2].ToString();
            bPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            bookdateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            bookPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            bookQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            pictureBox3.Visible = false;
        }

        private void bokname_TextChanged(object sender, EventArgs e)
        {
            if (bokname.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from NoteBook where bookName like '"+bokname.Text+"%'";

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from NoteBook where bookId=" + bookId + "";

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            bokname.Clear();
            panel4.Visible = false;
            pictureBox3.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from NoteBook";

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will be Updated,Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bookname = bname.Text;
                String bookAuthor = bauthor.Text;
                String bookPub = bPublication.Text;
                String bookPurDate = bookdateTimePicker1.Text;
                Int64 bookprice = Int64.Parse(bookPrice.Text);
                Int64 bookQuan = Int64.Parse(bookQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NoteBook Set bookName = '" + bookname + "',bookAuthor='" + bookAuthor + "',bookPublication='" + bookPub + "',bookPurchaseDate='" +bookPurDate + "',bookPrice='" + bookprice + "',bookQuantity='" + bookQuan + "' where bookId='" + rowId + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
               
            
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will be Deleted,Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from NoteBook where bookId='"+rowId+"'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
