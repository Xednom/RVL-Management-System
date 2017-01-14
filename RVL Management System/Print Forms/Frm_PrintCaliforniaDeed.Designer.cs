namespace RVL_Management_System.Forms
{
    partial class Frm_PrintCaliforniaDeed
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.printCaliforniaGrantDeed = new RVL_Management_System.Print.PrintCaliforniaGrantDeed();
            this.printCaliforniaGrantDeedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCaliforniaDeedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.printCaliforniaGrantDeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCaliforniaGrantDeedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCaliforniaDeedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Location = new System.Drawing.Point(23, 101);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(121, 29);
            this.cBoxSearchBy.TabIndex = 0;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = null;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.Visible = false;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(160, 107);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(148, 23);
            this.txt_search.TabIndex = 1;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(314, 107);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Print";
            this.btn_print.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Search By:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(160, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Search:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PrintCaliforniaGrantDeed";
            reportDataSource1.Value = this.tblCaliforniaDeedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RVL_Management_System.Print.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 233);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(630, 401);
            this.reportViewer1.TabIndex = 5;
            // 
            // printCaliforniaGrantDeed
            // 
            this.printCaliforniaGrantDeed.DataSetName = "PrintCaliforniaGrantDeed";
            this.printCaliforniaGrantDeed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printCaliforniaGrantDeedBindingSource
            // 
            this.printCaliforniaGrantDeedBindingSource.DataSource = this.printCaliforniaGrantDeed;
            this.printCaliforniaGrantDeedBindingSource.Position = 0;
            // 
            // tblCaliforniaDeedBindingSource
            // 
            this.tblCaliforniaDeedBindingSource.DataMember = "tblCaliforniaDeed";
            this.tblCaliforniaDeedBindingSource.DataSource = this.printCaliforniaGrantDeed;
            // 
            // Frm_PrintCaliforniaDeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 657);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cBoxSearchBy);
            this.MaximizeBox = false;
            this.Name = "Frm_PrintCaliforniaDeed";
            this.Resizable = false;
            this.Text = "Print California Deed";
            this.Load += new System.EventHandler(this.Frm_PrintCaliforniaDeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printCaliforniaGrantDeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCaliforniaGrantDeedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCaliforniaDeedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroButton btn_print;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource printCaliforniaGrantDeedBindingSource;
        private Print.PrintCaliforniaGrantDeed printCaliforniaGrantDeed;
        private System.Windows.Forms.BindingSource tblCaliforniaDeedBindingSource;
    }
}