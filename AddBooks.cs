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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Entered Data Will be Deleted ", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (texBookName.Text != "" && textAuthorName.Text != "" && textPublication.Text != "" && textPrice.Text != "" && textQuantity.Text != "")
            {
                String bookName = texBookName.Text;
                String bookAuthName = textAuthorName.Text;
                String bookPublication = textPublication.Text;
                String bookPurchasDate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(textPrice.Text);
                Int64 quantity = Int64.Parse(textQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-00QRI8V;Integrated Security=True;database=BookLibrary";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                if (dateTimePicker1.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Books should be added in the past date and present date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.CommandText = "Insert into NoteBook (bookName,bookAuthor,bookPublication,bookPurchaseDate,bookPrice,bookQuantity) Values('" + bookName + "' ,'" + bookAuthName + "', '" + bookPublication + "','" + bookPurchasDate + "','" + price + "','" + quantity + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    texBookName.Clear();
                    textAuthorName.Clear();
                    textPublication.Clear();
                    textPrice.Clear();
                    textQuantity.Clear();
                }
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
