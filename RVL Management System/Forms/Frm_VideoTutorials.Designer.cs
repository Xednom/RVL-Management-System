namespace RVL_Management_System.Forms
{
    partial class Frm_VideoTutorials
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_process = new MetroFramework.Controls.MetroTextBox();
            this.txt_youtube = new MetroFramework.Controls.MetroTextBox();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(148, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Process";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(448, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Youtube Link";
            // 
            // txt_process
            // 
            // 
            // 
            // 
            this.txt_process.CustomButton.Image = null;
            this.txt_process.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.txt_process.CustomButton.Name = "";
            this.txt_process.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txt_process.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_process.CustomButton.TabIndex = 1;
            this.txt_process.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_process.CustomButton.UseSelectable = true;
            this.txt_process.CustomButton.Visible = false;
            this.txt_process.Lines = new string[0];
            this.txt_process.Location = new System.Drawing.Point(23, 99);
            this.txt_process.MaxLength = 32767;
            this.txt_process.Multiline = true;
            this.txt_process.Name = "txt_process";
            this.txt_process.PasswordChar = '\0';
            this.txt_process.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_process.SelectedText = "";
            this.txt_process.SelectionLength = 0;
            this.txt_process.SelectionStart = 0;
            this.txt_process.ShortcutsEnabled = true;
            this.txt_process.Size = new System.Drawing.Size(307, 50);
            this.txt_process.TabIndex = 2;
            this.txt_process.UseSelectable = true;
            this.txt_process.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_process.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_youtube
            // 
            // 
            // 
            // 
            this.txt_youtube.CustomButton.Image = null;
            this.txt_youtube.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.txt_youtube.CustomButton.Name = "";
            this.txt_youtube.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txt_youtube.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_youtube.CustomButton.TabIndex = 1;
            this.txt_youtube.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_youtube.CustomButton.UseSelectable = true;
            this.txt_youtube.CustomButton.Visible = false;
            this.txt_youtube.Lines = new string[0];
            this.txt_youtube.Location = new System.Drawing.Point(336, 99);
            this.txt_youtube.MaxLength = 32767;
            this.txt_youtube.Multiline = true;
            this.txt_youtube.Name = "txt_youtube";
            this.txt_youtube.PasswordChar = '\0';
            this.txt_youtube.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_youtube.SelectedText = "";
            this.txt_youtube.SelectionLength = 0;
            this.txt_youtube.SelectionStart = 0;
            this.txt_youtube.ShortcutsEnabled = true;
            this.txt_youtube.Size = new System.Drawing.Size(307, 50);
            this.txt_youtube.TabIndex = 3;
            this.txt_youtube.UseSelectable = true;
            this.txt_youtube.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_youtube.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(148, 183);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "&Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(401, 183);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseSelectable = true;
            // 
            // Frm_YoutubeTutorials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 241);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_youtube);
            this.Controls.Add(this.txt_process);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_YoutubeTutorials";
            this.Resizable = false;
            this.Text = "Add Youtube Link Tutorials";
            this.Load += new System.EventHandler(this.Frm_YoutubeTutorials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_process;
        private MetroFramework.Controls.MetroTextBox txt_youtube;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroButton btn_cancel;
    }
}