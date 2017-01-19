namespace RVL_Management_System.Forms
{
    partial class VideoTutorialsUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.txt_youtube = new MetroFramework.Controls.MetroTextBox();
            this.txt_process = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.txt_vid = new MetroFramework.Controls.MetroTextBox();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(429, 234);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseSelectable = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(176, 234);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "&Update";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            this.txt_youtube.Location = new System.Drawing.Point(364, 150);
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
            this.txt_youtube.TabIndex = 9;
            this.txt_youtube.UseSelectable = true;
            this.txt_youtube.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_youtube.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_process.Location = new System.Drawing.Point(51, 150);
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
            this.txt_process.TabIndex = 8;
            this.txt_process.UseSelectable = true;
            this.txt_process.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_process.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(476, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Youtube Link";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(176, 128);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Process";
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "VID",
            "Process"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(51, 86);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(200, 29);
            this.cBoxSearchBy.TabIndex = 12;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(51, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Search By:";
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = null;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.Visible = false;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(270, 86);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(195, 23);
            this.txt_search.TabIndex = 14;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(270, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Search:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(471, 86);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "&Search";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_vid
            // 
            // 
            // 
            // 
            this.txt_vid.CustomButton.Image = null;
            this.txt_vid.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txt_vid.CustomButton.Name = "";
            this.txt_vid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_vid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_vid.CustomButton.TabIndex = 1;
            this.txt_vid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_vid.CustomButton.UseSelectable = true;
            this.txt_vid.CustomButton.Visible = false;
            this.txt_vid.Lines = new string[0];
            this.txt_vid.Location = new System.Drawing.Point(23, 316);
            this.txt_vid.MaxLength = 32767;
            this.txt_vid.Name = "txt_vid";
            this.txt_vid.PasswordChar = '\0';
            this.txt_vid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_vid.SelectedText = "";
            this.txt_vid.SelectionLength = 0;
            this.txt_vid.SelectionStart = 0;
            this.txt_vid.ShortcutsEnabled = true;
            this.txt_vid.Size = new System.Drawing.Size(195, 23);
            this.txt_vid.TabIndex = 17;
            this.txt_vid.UseSelectable = true;
            this.txt_vid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_vid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.Location = new System.Drawing.Point(23, 345);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(663, 150);
            this.GridView.TabIndex = 18;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 294);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Video ID";
            // 
            // Frm_VideoTutorialsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 518);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.txt_vid);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cBoxSearchBy);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_youtube);
            this.Controls.Add(this.txt_process);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_VideoTutorialsUpdate";
            this.Resizable = false;
            this.Text = "Video Tutorials Update";
            this.Load += new System.EventHandler(this.Frm_VideoTutorialsUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroTextBox txt_youtube;
        private MetroFramework.Controls.MetroTextBox txt_process;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroTextBox txt_vid;
        private MetroFramework.Controls.MetroGrid GridView;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}