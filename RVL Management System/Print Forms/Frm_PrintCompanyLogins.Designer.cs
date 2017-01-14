namespace RVL_Management_System.Print_Forms
{
    partial class Frm_PrintCompanyLogins
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.printCompanyLogins = new RVL_Management_System.Print.PrintCompanyLogins();
            this.printCompanyLoginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.printCompanyLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCompanyLoginsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PrintCompanyLogins";
            reportDataSource1.Value = this.printCompanyLoginsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RVL_Management_System.Print.rptCompangLogins.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(599, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // printCompanyLogins
            // 
            this.printCompanyLogins.DataSetName = "PrintCompanyLogins";
            this.printCompanyLogins.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printCompanyLoginsBindingSource
            // 
            this.printCompanyLoginsBindingSource.DataSource = this.printCompanyLogins;
            this.printCompanyLoginsBindingSource.Position = 0;
            // 
            // Frm_PrintCompanyLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 492);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PrintCompanyLogins";
            this.Resizable = false;
            this.Text = "Print Company Logins";
            this.Load += new System.EventHandler(this.Frm_PrintCompanyLogins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printCompanyLogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCompanyLoginsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource printCompanyLoginsBindingSource;
        private Print.PrintCompanyLogins printCompanyLogins;
    }
}