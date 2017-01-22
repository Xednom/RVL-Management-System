namespace RVL_Management_System.Forms
{
    partial class EmailCredential
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
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_pw = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(114, 99);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(196, 23);
            this.txt_email.TabIndex = 0;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pw
            // 
            // 
            // 
            // 
            this.txt_pw.CustomButton.Image = null;
            this.txt_pw.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txt_pw.CustomButton.Name = "";
            this.txt_pw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pw.CustomButton.TabIndex = 1;
            this.txt_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pw.CustomButton.UseSelectable = true;
            this.txt_pw.CustomButton.Visible = false;
            this.txt_pw.Lines = new string[0];
            this.txt_pw.Location = new System.Drawing.Point(114, 128);
            this.txt_pw.MaxLength = 32767;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pw.SelectedText = "";
            this.txt_pw.SelectionLength = 0;
            this.txt_pw.SelectionStart = 0;
            this.txt_pw.ShortcutsEnabled = true;
            this.txt_pw.Size = new System.Drawing.Size(196, 23);
            this.txt_pw.TabIndex = 1;
            this.txt_pw.UseSelectable = true;
            this.txt_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(64, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Email:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(127, 202);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 29);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "&Save Credentials";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(229, 202);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(72, 29);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(60, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Name:";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(114, 157);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(196, 23);
            this.txt_name.TabIndex = 7;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmailCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 239);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_email);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailCredential";
            this.Resizable = false;
            this.Text = "Email Credentials";
            this.Load += new System.EventHandler(this.EmailCredential_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_pw;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_name;
    }
}