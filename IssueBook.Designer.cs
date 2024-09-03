
namespace TjohnLibrary
{
    partial class IssueBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.S_roll_num = new System.Windows.Forms.ComboBox();
            this.S_exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.S_issue_btn = new System.Windows.Forms.Button();
            this.S_issue_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.S_book = new System.Windows.Forms.ComboBox();
            this.S_dept = new System.Windows.Forms.TextBox();
            this.S_sem = new System.Windows.Forms.TextBox();
            this.S_cont = new System.Windows.Forms.TextBox();
            this.S_email = new System.Windows.Forms.TextBox();
            this.S_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(416, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.S_roll_num);
            this.panel2.Controls.Add(this.S_exit);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 388);
            this.panel2.TabIndex = 1;
            // 
            // S_roll_num
            // 
            this.S_roll_num.FormattingEnabled = true;
            this.S_roll_num.Location = new System.Drawing.Point(32, 172);
            this.S_roll_num.Name = "S_roll_num";
            this.S_roll_num.Size = new System.Drawing.Size(121, 21);
            this.S_roll_num.TabIndex = 16;
            this.S_roll_num.SelectedIndexChanged += new System.EventHandler(this.S_roll_num_SelectedIndexChanged);
            // 
            // S_exit
            // 
            this.S_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.S_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_exit.Location = new System.Drawing.Point(42, 218);
            this.S_exit.Name = "S_exit";
            this.S_exit.Size = new System.Drawing.Size(102, 39);
            this.S_exit.TabIndex = 2;
            this.S_exit.Text = "Exit";
            this.S_exit.UseVisualStyleBackColor = false;
            this.S_exit.Click += new System.EventHandler(this.S_exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Roll Number";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Controls.Add(this.refresh_btn);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.S_issue_btn);
            this.panel3.Controls.Add(this.S_issue_date);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.S_book);
            this.panel3.Controls.Add(this.S_dept);
            this.panel3.Controls.Add(this.S_sem);
            this.panel3.Controls.Add(this.S_cont);
            this.panel3.Controls.Add(this.S_email);
            this.panel3.Controls.Add(this.S_name);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(242, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 388);
            this.panel3.TabIndex = 2;
            // 
            // refresh_btn
            // 
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(146, 316);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(100, 33);
            this.refresh_btn.TabIndex = 16;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(126, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Maximum 3 Book Can be Issued To 1 Student";
            // 
            // S_issue_btn
            // 
            this.S_issue_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.S_issue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_issue_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_issue_btn.Location = new System.Drawing.Point(281, 317);
            this.S_issue_btn.Name = "S_issue_btn";
            this.S_issue_btn.Size = new System.Drawing.Size(108, 33);
            this.S_issue_btn.TabIndex = 3;
            this.S_issue_btn.Text = "Issue Book";
            this.S_issue_btn.UseVisualStyleBackColor = false;
            this.S_issue_btn.Click += new System.EventHandler(this.S_issue_btn_Click);
            // 
            // S_issue_date
            // 
            this.S_issue_date.Location = new System.Drawing.Point(179, 278);
            this.S_issue_date.Name = "S_issue_date";
            this.S_issue_date.Size = new System.Drawing.Size(199, 20);
            this.S_issue_date.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Book Issue Date";
            // 
            // S_book
            // 
            this.S_book.FormattingEnabled = true;
            this.S_book.Location = new System.Drawing.Point(179, 236);
            this.S_book.Name = "S_book";
            this.S_book.Size = new System.Drawing.Size(199, 21);
            this.S_book.TabIndex = 12;
            // 
            // S_dept
            // 
            this.S_dept.Location = new System.Drawing.Point(179, 67);
            this.S_dept.Name = "S_dept";
            this.S_dept.ReadOnly = true;
            this.S_dept.Size = new System.Drawing.Size(199, 20);
            this.S_dept.TabIndex = 11;
            // 
            // S_sem
            // 
            this.S_sem.Location = new System.Drawing.Point(179, 105);
            this.S_sem.Name = "S_sem";
            this.S_sem.ReadOnly = true;
            this.S_sem.Size = new System.Drawing.Size(199, 20);
            this.S_sem.TabIndex = 10;
            // 
            // S_cont
            // 
            this.S_cont.Location = new System.Drawing.Point(179, 151);
            this.S_cont.Name = "S_cont";
            this.S_cont.ReadOnly = true;
            this.S_cont.Size = new System.Drawing.Size(199, 20);
            this.S_cont.TabIndex = 9;
            // 
            // S_email
            // 
            this.S_email.Location = new System.Drawing.Point(179, 191);
            this.S_email.Name = "S_email";
            this.S_email.ReadOnly = true;
            this.S_email.Size = new System.Drawing.Size(199, 20);
            this.S_email.TabIndex = 7;
            // 
            // S_name
            // 
            this.S_name.Location = new System.Drawing.Point(179, 23);
            this.S_name.Name = "S_name";
            this.S_name.ReadOnly = true;
            this.S_name.Size = new System.Drawing.Size(199, 20);
            this.S_name.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Book Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Student Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Student Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Name";
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(707, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button S_exit;
        private System.Windows.Forms.TextBox S_dept;
        private System.Windows.Forms.TextBox S_sem;
        private System.Windows.Forms.TextBox S_cont;
        private System.Windows.Forms.TextBox S_email;
        private System.Windows.Forms.TextBox S_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker S_issue_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox S_book;
        private System.Windows.Forms.Button S_issue_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox S_roll_num;
        private System.Windows.Forms.Button refresh_btn;
    }
}