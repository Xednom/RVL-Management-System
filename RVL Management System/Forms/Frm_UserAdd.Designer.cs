namespace RVL_Management_System
{
    partial class Frm_UserAdd
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
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_level = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxRole = new System.Windows.Forms.ComboBox();
            this.txt_confirmPw = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txt_un = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txt_mi = new System.Windows.Forms.TextBox();
            this.txt_fn = new System.Windows.Forms.TextBox();
            this.txt_ln = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.Color.White;
            this.txt_userID.Enabled = false;
            this.txt_userID.Location = new System.Drawing.Point(101, 14);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(165, 21);
            this.txt_userID.TabIndex = 10;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txt_level);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.cBoxRole);
            this.GroupBox3.Controls.Add(this.txt_confirmPw);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Controls.Add(this.txt_pw);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.txt_un);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(23, 217);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(635, 136);
            this.GroupBox3.TabIndex = 9;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "User Information";
            // 
            // txt_level
            // 
            this.txt_level.BackColor = System.Drawing.Color.White;
            this.txt_level.Enabled = false;
            this.txt_level.Location = new System.Drawing.Point(110, 82);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(25, 21);
            this.txt_level.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Privilege level:";
            // 
            // cBoxRole
            // 
            this.cBoxRole.FormattingEnabled = true;
            this.cBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cBoxRole.Location = new System.Drawing.Point(110, 55);
            this.cBoxRole.Name = "cBoxRole";
            this.cBoxRole.Size = new System.Drawing.Size(165, 21);
            this.cBoxRole.TabIndex = 10;
            this.cBoxRole.SelectedIndexChanged += new System.EventHandler(this.cBoxRole_SelectedIndexChanged);
            // 
            // txt_confirmPw
            // 
            this.txt_confirmPw.BackColor = System.Drawing.Color.White;
            this.txt_confirmPw.Location = new System.Drawing.Point(444, 55);
            this.txt_confirmPw.Name = "txt_confirmPw";
            this.txt_confirmPw.PasswordChar = '*';
            this.txt_confirmPw.Size = new System.Drawing.Size(165, 21);
            this.txt_confirmPw.TabIndex = 3;
            this.txt_confirmPw.TextChanged += new System.EventHandler(this.txt_confirmPw_TextChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(324, 58);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(120, 13);
            this.Label9.TabIndex = 12;
            this.Label9.Text = "Confirm Password :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(51, 58);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(41, 13);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Role :";
            // 
            // txt_pw
            // 
            this.txt_pw.BackColor = System.Drawing.Color.White;
            this.txt_pw.Location = new System.Drawing.Point(444, 27);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(165, 21);
            this.txt_pw.TabIndex = 9;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(324, 30);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(70, 13);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Password :";
            // 
            // txt_un
            // 
            this.txt_un.BackColor = System.Drawing.Color.White;
            this.txt_un.Location = new System.Drawing.Point(110, 27);
            this.txt_un.Name = "txt_un";
            this.txt_un.Size = new System.Drawing.Size(165, 21);
            this.txt_un.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(18, 30);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(74, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Username :";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(443, 42);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(19, 12);
            this.Label12.TabIndex = 8;
            this.Label12.Text = "MI";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(270, 42);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(55, 12);
            this.Label11.TabIndex = 8;
            this.Label11.Text = "Firstname";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(99, 42);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(54, 12);
            this.Label10.TabIndex = 8;
            this.Label10.Text = "Lastname";
            // 
            // txt_mi
            // 
            this.txt_mi.BackColor = System.Drawing.Color.White;
            this.txt_mi.Location = new System.Drawing.Point(443, 57);
            this.txt_mi.Name = "txt_mi";
            this.txt_mi.Size = new System.Drawing.Size(39, 21);
            this.txt_mi.TabIndex = 2;
            // 
            // txt_fn
            // 
            this.txt_fn.BackColor = System.Drawing.Color.White;
            this.txt_fn.Location = new System.Drawing.Point(272, 57);
            this.txt_fn.Name = "txt_fn";
            this.txt_fn.Size = new System.Drawing.Size(165, 21);
            this.txt_fn.TabIndex = 1;
            // 
            // txt_ln
            // 
            this.txt_ln.BackColor = System.Drawing.Color.White;
            this.txt_ln.Location = new System.Drawing.Point(101, 57);
            this.txt_ln.Name = "txt_ln";
            this.txt_ln.Size = new System.Drawing.Size(165, 21);
            this.txt_ln.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(43, 60);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Name :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(36, 17);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(56, 13);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "User ID:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.txt_email);
            this.GroupBox1.Controls.Add(this.txt_userID);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.txt_mi);
            this.GroupBox1.Controls.Add(this.txt_fn);
            this.GroupBox1.Controls.Add(this.txt_ln);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(23, 75);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(637, 136);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Staff Information";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(566, 359);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(92, 55);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(468, 359);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(92, 55);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(49, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(101, 96);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(165, 21);
            this.txt_email.TabIndex = 11;
            // 
            // Frm_UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 437);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.GroupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_UserAdd";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add User Information";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_UserAdd_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txt_userID;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ComboBox cBoxRole;
        internal System.Windows.Forms.TextBox txt_confirmPw;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txt_pw;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txt_un;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txt_mi;
        internal System.Windows.Forms.TextBox txt_fn;
        internal System.Windows.Forms.TextBox txt_ln;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        internal System.Windows.Forms.TextBox txt_level;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txt_email;
    }
}