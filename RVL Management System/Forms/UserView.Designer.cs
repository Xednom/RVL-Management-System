namespace RVL_Management_System
{
    partial class Frm_UserView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.txt__search = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt__search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBoxSearchBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GridView);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBox1.Location = new System.Drawing.Point(23, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(499, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 49);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txt__search
            // 
            // 
            // 
            // 
            this.txt__search.CustomButton.Image = null;
            this.txt__search.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txt__search.CustomButton.Name = "";
            this.txt__search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt__search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt__search.CustomButton.TabIndex = 1;
            this.txt__search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt__search.CustomButton.UseSelectable = true;
            this.txt__search.CustomButton.Visible = false;
            this.txt__search.Lines = new string[0];
            this.txt__search.Location = new System.Drawing.Point(297, 28);
            this.txt__search.MaxLength = 32767;
            this.txt__search.Name = "txt__search";
            this.txt__search.PasswordChar = '\0';
            this.txt__search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt__search.SelectedText = "";
            this.txt__search.SelectionLength = 0;
            this.txt__search.SelectionStart = 0;
            this.txt__search.ShortcutsEnabled = true;
            this.txt__search.Size = new System.Drawing.Size(185, 23);
            this.txt__search.TabIndex = 4;
            this.txt__search.UseSelectable = true;
            this.txt__search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt__search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search:";
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "User ID",
            "Full name",
            "Username"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(94, 27);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(121, 29);
            this.cBoxSearchBy.TabIndex = 2;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.Location = new System.Drawing.Point(6, 114);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(654, 287);
            this.GridView.TabIndex = 0;
            // 
            // Frm_UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 507);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_UserView";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "View User Information";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_UserView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid GridView;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt__search;
        private MetroFramework.Controls.MetroButton btn_search;
    }
}