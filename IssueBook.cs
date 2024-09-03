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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bookName from Notebook", con);
            SqlDataReader sdr1 = cmd.ExecuteReader();

            while (sdr1.Read()) { 
                for(int i=0;i<sdr1.FieldCount;i++)
                {
                    S_book.Items.Add(sdr1.GetString(i));

                }
            }
            sdr1.Close();
            cmd = new SqlCommand("select StudentRoll from NewStudent", con);
            SqlDataReader sdr2 = cmd.ExecuteReader();
            while (sdr2.Read())
            {
                for (int i = 0; i < sdr2.FieldCount; i++)
                {
                    S_roll_num.Items.Add(sdr2.GetString(i));

                }
            }
            sdr2.Close();
            con.Close();
        }

        

        private void S_issue_btn_Click(object sender, EventArgs e)
        {
            if (S_name.Text != "")
            {
                if (S_book.SelectedIndex != -1 && count <= 2)
                {
                    String Stu_Roll = S_roll_num.Text;
                    String Stu_name = S_name.Text;
                    String Stu_Dept = S_dept.Text;
                    String Stu_Sem = S_sem.Text;
                    String Stu_Con = S_cont.Text;
                    String Stu_Email = S_email.Text;
                    String Stu_Book = S_book.Text;
                    String Issue_Date = S_issue_date.Text;


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    if (S_issue_date.Value.Date != DateTime.Now.Date)
                    {
                        MessageBox.Show("Books should be issued on current date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (getBookCount() > 0)
                    {
                        cmd.CommandText = "Insert into IssueReturnBook (Std_Roll,Std_Name,Std_Dept,Std_Sem,Std_Contact,Std_Email,Book_name,Book_Issue_Date) Values('" + Stu_Roll + "','" + Stu_name + "','" + Stu_Dept + "','" + Stu_Sem + "','" + Stu_Con + "','" + Stu_Email + "','" + Stu_Book + "','" + Issue_Date + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Book Issued Sucessfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateBook();
                    }
                    else {
                        MessageBox.Show("Book is not available in Library!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("Select Book Or You have Issued Maximum Book", "Book is not allocated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Roll Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Int64 getBookCount()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "select bookQuantity from Notebook where bookName='" + S_book.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter sdr1 = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sdr1.SelectCommand = cmd;
            sdr1.Fill(ds);

            Int64 bookQuantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            return bookQuantity;
            con.Close();
        }
        private void UpdateBook()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            Int64 bookQuantity, newqty;
            bookQuantity=getBookCount();
             if (bookQuantity!=0)
            { 
            newqty = bookQuantity - 1;
            string query1="update NoteBook set bookQuantity="+newqty+" where bookName='"+S_book.Text+"'";
            SqlCommand cmd1 = new SqlCommand(query1,con);
            cmd1.ExecuteNonQuery();
            con.Close();
                }
            else
            {
                
                MessageBox.Show("Book is not there", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }


        private void S_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        int count;
        private void S_roll_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String rollNum = S_roll_num.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent where StudentRoll='" + rollNum + "'";

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);

            //Code to Count how many Books has been Issued
            cmd.CommandText = "select count(Std_Roll) from IssueReturnBook where Std_Roll='" + rollNum + "' and Book_Return_Date is null";
            SqlDataAdapter da1 = new SqlDataAdapter();
            DataSet ds1 = new DataSet();
            da1.SelectCommand = cmd;
            da1.Fill(ds1);
            count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());


            if (ds.Tables[0].Rows.Count != 0)
            {
                S_name.Text = ds.Tables[0].Rows[0][1].ToString();
                S_dept.Text = ds.Tables[0].Rows[0][3].ToString();
                S_sem.Text = ds.Tables[0].Rows[0][4].ToString();
                S_cont.Text = ds.Tables[0].Rows[0][5].ToString();
                S_email.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                S_name.Clear();
                S_dept.Clear();
                S_sem.Clear();
                S_cont.Clear();
                S_email.Clear();
                MessageBox.Show("Incorrect ROll Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            S_name.Clear();
            S_dept.Clear();
            S_sem.Clear();
            S_cont.Clear();
            S_email.Clear();
            
        }
    }
}
