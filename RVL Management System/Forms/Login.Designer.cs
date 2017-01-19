namespace RVL_Management_System
{
    partial class Frm_Login
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_un = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pw = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.cBoxUsertype = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_un
            // 
            // 
            // 
            // 
            this.txt_un.CustomButton.Image = null;
            this.txt_un.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txt_un.CustomButton.Name = "";
            this.txt_un.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_un.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_un.CustomButton.TabIndex = 1;
            this.txt_un.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_un.CustomButton.UseSelectable = true;
            this.txt_un.CustomButton.Visible = false;
            this.txt_un.Lines = new string[0];
            this.txt_un.Location = new System.Drawing.Point(140, 170);
            this.txt_un.MaxLength = 32767;
            this.txt_un.Name = "txt_un";
            this.txt_un.PasswordChar = '\0';
            this.txt_un.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_un.SelectedText = "";
            this.txt_un.SelectionLength = 0;
            this.txt_un.SelectionStart = 0;
            this.txt_un.ShortcutsEnabled = true;
            this.txt_un.Size = new System.Drawing.Size(166, 23);
            this.txt_un.TabIndex = 0;
            this.txt_un.UseSelectable = true;
            this.txt_un.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_un.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_un.TextChanged += new System.EventHandler(this.txt_un_TextChanged);
            this.txt_un.Click += new System.EventHandler(this.txt_un_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "RVL Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // txt_pw
            // 
            // 
            // 
            // 
            this.txt_pw.CustomButton.Image = null;
            this.txt_pw.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txt_pw.CustomButton.Name = "";
            this.txt_pw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pw.CustomButton.TabIndex = 1;
            this.txt_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pw.CustomButton.UseSelectable = true;
            this.txt_pw.CustomButton.Visible = false;
            this.txt_pw.Lines = new string[0];
            this.txt_pw.Location = new System.Drawing.Point(140, 199);
            this.txt_pw.MaxLength = 32767;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pw.SelectedText = "";
            this.txt_pw.SelectionLength = 0;
            this.txt_pw.SelectionStart = 0;
            this.txt_pw.ShortcutsEnabled = true;
            this.txt_pw.Size = new System.Drawing.Size(166, 23);
            this.txt_pw.TabIndex = 3;
            this.txt_pw.UseSelectable = true;
            this.txt_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(144, 257);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(225, 257);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cBoxUsertype
            // 
            this.cBoxUsertype.FormattingEnabled = true;
            this.cBoxUsertype.ItemHeight = 23;
            this.cBoxUsertype.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cBoxUsertype.Location = new System.Drawing.Point(140, 135);
            this.cBoxUsertype.Name = "cBoxUsertype";
            this.cBoxUsertype.Size = new System.Drawing.Size(166, 29);
            this.cBoxUsertype.TabIndex = 8;
            this.cBoxUsertype.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "User Type:";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Enabled = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(520, 201);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(166, 23);
            this.txt_name.TabIndex = 10;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.Location = new System.Drawing.Point(480, 32);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(240, 150);
            this.GridView.TabIndex = 12;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 296);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxUsertype);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_un);
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_un;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txt_pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroComboBox cBoxUsertype;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroGrid GridView;
    }
}

