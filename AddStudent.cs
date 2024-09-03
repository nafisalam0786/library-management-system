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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit? ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textRoll.Clear();
            textDepartment.Clear();
            textSemester.Clear();
            textContact.Clear();
            textEmail.Clear();
        }

       

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (textName.Text != "" && textRoll.Text != "" && textDepartment.Text != "" && textSemester.Text != "" && textContact.Text != "" && textEmail.Text != "")
            {
                String stdName = textName.Text;
                String stdRoll = textRoll.Text;
                String stdDept = textDepartment.Text;
                String stdSem = textSemester.Text;
                Int64 stdCont = Int64.Parse(textContact.Text);
                String stdMail = textEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "Select * from NewStudent where StudentRoll ='" + stdRoll + "'";
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);


                if (textContact.Text.Length != 10)
                {
                    MessageBox.Show("Please Enter Valid 10 digit Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ds.Tables[0].Rows.Count != 0) {
                    MessageBox.Show("Already Student roll is present in Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    cmd.CommandText = "Insert into NewStudent (StudentName,StudentRoll,StudentDept,StudentSemester,StudentContact,StudentEmail) Values('" + stdName + "' ,'" + stdRoll + "', '" + stdDept + "','" + stdSem + "','" + stdCont + "','" + stdMail + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textName.Clear();
                    textRoll.Clear();
                    textDepartment.Clear();
                    textSemester.Clear();
                    textContact.Clear();
                    textEmail.Clear();

                }
            }
        }

    }
}
