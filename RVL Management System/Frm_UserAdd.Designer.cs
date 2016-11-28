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
            this.txt_employeeID = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxRole = new System.Windows.Forms.ComboBox();
            this.txt_confirmPw = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txt_un = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_mi = new System.Windows.Forms.TextBox();
            this.txt_brgy = new System.Windows.Forms.TextBox();
            this.txt_province = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_fn = new System.Windows.Forms.TextBox();
            this.txt_ln = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_employeeID
            // 
            this.txt_employeeID.BackColor = System.Drawing.Color.White;
            this.txt_employeeID.Location = new System.Drawing.Point(111, 41);
            this.txt_employeeID.Name = "txt_employeeID";
            this.txt_employeeID.Size = new System.Drawing.Size(165, 21);
            this.txt_employeeID.TabIndex = 10;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.cBoxRole);
            this.GroupBox3.Controls.Add(this.txt_confirmPw);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Controls.Add(this.txt_pw);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.txt_un);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(0, 237);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(635, 90);
            this.GroupBox3.TabIndex = 9;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "User Information";
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
            // 
            // txt_confirmPw
            // 
            this.txt_confirmPw.BackColor = System.Drawing.Color.White;
            this.txt_confirmPw.Location = new System.Drawing.Point(444, 55);
            this.txt_confirmPw.Name = "txt_confirmPw";
            this.txt_confirmPw.PasswordChar = '*';
            this.txt_confirmPw.Size = new System.Drawing.Size(165, 21);
            this.txt_confirmPw.TabIndex = 3;
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
            this.Label7.Location = new System.Drawing.Point(25, 58);
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
            this.Label5.Location = new System.Drawing.Point(25, 30);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(74, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Username :";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(443, 112);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(26, 12);
            this.Label15.TabIndex = 8;
            this.Label15.Text = "City";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(443, 71);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(19, 12);
            this.Label12.TabIndex = 8;
            this.Label12.Text = "MI";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(270, 112);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(52, 12);
            this.Label14.TabIndex = 8;
            this.Label14.Text = "Barangay";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(270, 71);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(55, 12);
            this.Label11.TabIndex = 8;
            this.Label11.Text = "Firstname";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(99, 151);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(49, 12);
            this.Label16.TabIndex = 8;
            this.Label16.Text = "Province";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(99, 112);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(36, 12);
            this.Label13.TabIndex = 8;
            this.Label13.Text = "Street";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(99, 71);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(54, 12);
            this.Label10.TabIndex = 8;
            this.Label10.Text = "Lastname";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 130);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Address :";
            // 
            // txt_contact
            // 
            this.txt_contact.BackColor = System.Drawing.Color.White;
            this.txt_contact.Location = new System.Drawing.Point(101, 195);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(165, 21);
            this.txt_contact.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(16, 198);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(83, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Contact No. :";
            // 
            // txt_city
            // 
            this.txt_city.BackColor = System.Drawing.Color.White;
            this.txt_city.Location = new System.Drawing.Point(443, 127);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(157, 21);
            this.txt_city.TabIndex = 5;
            // 
            // txt_mi
            // 
            this.txt_mi.BackColor = System.Drawing.Color.White;
            this.txt_mi.Location = new System.Drawing.Point(443, 86);
            this.txt_mi.Name = "txt_mi";
            this.txt_mi.Size = new System.Drawing.Size(39, 21);
            this.txt_mi.TabIndex = 2;
            // 
            // txt_brgy
            // 
            this.txt_brgy.BackColor = System.Drawing.Color.White;
            this.txt_brgy.Location = new System.Drawing.Point(272, 127);
            this.txt_brgy.Name = "txt_brgy";
            this.txt_brgy.Size = new System.Drawing.Size(165, 21);
            this.txt_brgy.TabIndex = 4;
            // 
            // txt_province
            // 
            this.txt_province.BackColor = System.Drawing.Color.White;
            this.txt_province.Location = new System.Drawing.Point(101, 166);
            this.txt_province.Name = "txt_province";
            this.txt_province.Size = new System.Drawing.Size(499, 21);
            this.txt_province.TabIndex = 6;
            // 
            // txt_street
            // 
            this.txt_street.BackColor = System.Drawing.Color.White;
            this.txt_street.Location = new System.Drawing.Point(101, 127);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(165, 21);
            this.txt_street.TabIndex = 3;
            // 
            // txt_fn
            // 
            this.txt_fn.BackColor = System.Drawing.Color.White;
            this.txt_fn.Location = new System.Drawing.Point(272, 86);
            this.txt_fn.Name = "txt_fn";
            this.txt_fn.Size = new System.Drawing.Size(165, 21);
            this.txt_fn.TabIndex = 1;
            // 
            // txt_ln
            // 
            this.txt_ln.BackColor = System.Drawing.Color.White;
            this.txt_ln.Location = new System.Drawing.Point(101, 86);
            this.txt_ln.Name = "txt_ln";
            this.txt_ln.Size = new System.Drawing.Size(165, 21);
            this.txt_ln.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 89);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Name :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(16, 44);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(95, 13);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Employee No. :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.metroButton2);
            this.GroupBox1.Controls.Add(this.metroButton1);
            this.GroupBox1.Controls.Add(this.txt_employeeID);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.Label15);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label16);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txt_contact);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txt_city);
            this.GroupBox1.Controls.Add(this.txt_mi);
            this.GroupBox1.Controls.Add(this.txt_brgy);
            this.GroupBox1.Controls.Add(this.txt_province);
            this.GroupBox1.Controls.Add(this.txt_street);
            this.GroupBox1.Controls.Add(this.txt_fn);
            this.GroupBox1.Controls.Add(this.txt_ln);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(51, 56);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(637, 430);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Staff Information";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(433, 350);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(92, 55);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(531, 350);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(92, 55);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Frm_UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 507);
            this.Controls.Add(this.GroupBox1);
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

        internal System.Windows.Forms.TextBox txt_employeeID;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ComboBox cBoxRole;
        internal System.Windows.Forms.TextBox txt_confirmPw;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txt_pw;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txt_un;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_contact;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txt_city;
        internal System.Windows.Forms.TextBox txt_mi;
        internal System.Windows.Forms.TextBox txt_brgy;
        internal System.Windows.Forms.TextBox txt_province;
        internal System.Windows.Forms.TextBox txt_street;
        internal System.Windows.Forms.TextBox txt_fn;
        internal System.Windows.Forms.TextBox txt_ln;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}