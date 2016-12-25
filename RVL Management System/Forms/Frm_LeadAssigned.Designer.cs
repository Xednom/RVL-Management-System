namespace RVL_Management_System.Forms
{
    partial class Frm_LeadAssigned
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
            this.GridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxLeadAssesment = new System.Windows.Forms.ComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.cBoxLeadAssigned = new System.Windows.Forms.ComboBox();
            this.cBoxPriority = new System.Windows.Forms.ComboBox();
            this.cBoxLeadFollowUp = new System.Windows.Forms.ComboBox();
            this.txt_others = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cBoxLeadStats = new System.Windows.Forms.ComboBox();
            this.cBoxLeadSource = new System.Windows.Forms.ComboBox();
            this.txt_memo = new MetroFramework.Controls.MetroTextBox();
            this.txt_IssueDes = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_pnum = new MetroFramework.Controls.MetroTextBox();
            this.txt_mn = new MetroFramework.Controls.MetroTextBox();
            this.txt_fn = new MetroFramework.Controls.MetroTextBox();
            this.txt_ln = new MetroFramework.Controls.MetroTextBox();
            this.dtLeadReceived = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.GridView.Location = new System.Drawing.Point(9, 473);
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
            this.GridView.Size = new System.Drawing.Size(936, 150);
            this.GridView.TabIndex = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxLeadAssesment);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.cBoxLeadAssigned);
            this.groupBox1.Controls.Add(this.cBoxPriority);
            this.groupBox1.Controls.Add(this.cBoxLeadFollowUp);
            this.groupBox1.Controls.Add(this.txt_others);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.cBoxLeadStats);
            this.groupBox1.Controls.Add(this.cBoxLeadSource);
            this.groupBox1.Controls.Add(this.txt_memo);
            this.groupBox1.Controls.Add(this.txt_IssueDes);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_pnum);
            this.groupBox1.Controls.Add(this.txt_mn);
            this.groupBox1.Controls.Add(this.txt_fn);
            this.groupBox1.Controls.Add(this.txt_ln);
            this.groupBox1.Controls.Add(this.dtLeadReceived);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 394);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marketing Information";
            // 
            // cBoxLeadAssesment
            // 
            this.cBoxLeadAssesment.FormattingEnabled = true;
            this.cBoxLeadAssesment.Items.AddRange(new object[] {
            "Passed",
            "Failed"});
            this.cBoxLeadAssesment.Location = new System.Drawing.Point(239, 312);
            this.cBoxLeadAssesment.Name = "cBoxLeadAssesment";
            this.cBoxLeadAssesment.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadAssesment.TabIndex = 91;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(239, 284);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(102, 19);
            this.metroLabel15.TabIndex = 90;
            this.metroLabel15.Text = "Lead Assesment";
            // 
            // cBoxLeadAssigned
            // 
            this.cBoxLeadAssigned.FormattingEnabled = true;
            this.cBoxLeadAssigned.Location = new System.Drawing.Point(18, 363);
            this.cBoxLeadAssigned.Name = "cBoxLeadAssigned";
            this.cBoxLeadAssigned.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadAssigned.TabIndex = 89;
            // 
            // cBoxPriority
            // 
            this.cBoxPriority.FormattingEnabled = true;
            this.cBoxPriority.Items.AddRange(new object[] {
            "Low Priority",
            "Medium Priority",
            "High Priority"});
            this.cBoxPriority.Location = new System.Drawing.Point(239, 260);
            this.cBoxPriority.Name = "cBoxPriority";
            this.cBoxPriority.Size = new System.Drawing.Size(187, 21);
            this.cBoxPriority.TabIndex = 88;
            // 
            // cBoxLeadFollowUp
            // 
            this.cBoxLeadFollowUp.FormattingEnabled = true;
            this.cBoxLeadFollowUp.Items.AddRange(new object[] {
            "Texted",
            "Emailed",
            "Called",
            "Called-Left Voicemail",
            "Wrong Number",
            "Completed Follow-up",
            "Lead - Positive Buyer"});
            this.cBoxLeadFollowUp.Location = new System.Drawing.Point(18, 312);
            this.cBoxLeadFollowUp.Name = "cBoxLeadFollowUp";
            this.cBoxLeadFollowUp.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadFollowUp.TabIndex = 87;
            // 
            // txt_others
            // 
            // 
            // 
            // 
            this.txt_others.CustomButton.Image = null;
            this.txt_others.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_others.CustomButton.Name = "";
            this.txt_others.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_others.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_others.CustomButton.TabIndex = 1;
            this.txt_others.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_others.CustomButton.UseSelectable = true;
            this.txt_others.CustomButton.Visible = false;
            this.txt_others.Enabled = false;
            this.txt_others.Lines = new string[0];
            this.txt_others.Location = new System.Drawing.Point(18, 258);
            this.txt_others.MaxLength = 32767;
            this.txt_others.Name = "txt_others";
            this.txt_others.PasswordChar = '\0';
            this.txt_others.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_others.SelectedText = "";
            this.txt_others.SelectionLength = 0;
            this.txt_others.SelectionStart = 0;
            this.txt_others.ShortcutsEnabled = true;
            this.txt_others.Size = new System.Drawing.Size(187, 23);
            this.txt_others.TabIndex = 86;
            this.txt_others.UseSelectable = true;
            this.txt_others.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_others.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(18, 236);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(48, 19);
            this.metroLabel14.TabIndex = 85;
            this.metroLabel14.Text = "Others";
            // 
            // cBoxLeadStats
            // 
            this.cBoxLeadStats.FormattingEnabled = true;
            this.cBoxLeadStats.Location = new System.Drawing.Point(239, 209);
            this.cBoxLeadStats.Name = "cBoxLeadStats";
            this.cBoxLeadStats.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadStats.TabIndex = 84;
            // 
            // cBoxLeadSource
            // 
            this.cBoxLeadSource.AutoCompleteCustomSource.AddRange(new string[] {
            "Others"});
            this.cBoxLeadSource.FormattingEnabled = true;
            this.cBoxLeadSource.Location = new System.Drawing.Point(18, 209);
            this.cBoxLeadSource.Name = "cBoxLeadSource";
            this.cBoxLeadSource.Size = new System.Drawing.Size(187, 21);
            this.cBoxLeadSource.TabIndex = 83;
            // 
            // txt_memo
            // 
            // 
            // 
            // 
            this.txt_memo.CustomButton.Image = null;
            this.txt_memo.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_memo.CustomButton.Name = "";
            this.txt_memo.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txt_memo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_memo.CustomButton.TabIndex = 1;
            this.txt_memo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_memo.CustomButton.UseSelectable = true;
            this.txt_memo.CustomButton.Visible = false;
            this.txt_memo.Lines = new string[0];
            this.txt_memo.Location = new System.Drawing.Point(440, 280);
            this.txt_memo.MaxLength = 32767;
            this.txt_memo.Multiline = true;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.PasswordChar = '\0';
            this.txt_memo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memo.SelectedText = "";
            this.txt_memo.SelectionLength = 0;
            this.txt_memo.SelectionStart = 0;
            this.txt_memo.ShortcutsEnabled = true;
            this.txt_memo.Size = new System.Drawing.Size(329, 91);
            this.txt_memo.TabIndex = 78;
            this.txt_memo.UseSelectable = true;
            this.txt_memo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_memo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_IssueDes
            // 
            // 
            // 
            // 
            this.txt_IssueDes.CustomButton.Image = null;
            this.txt_IssueDes.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_IssueDes.CustomButton.Name = "";
            this.txt_IssueDes.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txt_IssueDes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_IssueDes.CustomButton.TabIndex = 1;
            this.txt_IssueDes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_IssueDes.CustomButton.UseSelectable = true;
            this.txt_IssueDes.CustomButton.Visible = false;
            this.txt_IssueDes.Lines = new string[0];
            this.txt_IssueDes.Location = new System.Drawing.Point(440, 153);
            this.txt_IssueDes.MaxLength = 32767;
            this.txt_IssueDes.Multiline = true;
            this.txt_IssueDes.Name = "txt_IssueDes";
            this.txt_IssueDes.PasswordChar = '\0';
            this.txt_IssueDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_IssueDes.SelectedText = "";
            this.txt_IssueDes.SelectionLength = 0;
            this.txt_IssueDes.SelectionStart = 0;
            this.txt_IssueDes.ShortcutsEnabled = true;
            this.txt_IssueDes.Size = new System.Drawing.Size(329, 91);
            this.txt_IssueDes.TabIndex = 73;
            this.txt_IssueDes.UseSelectable = true;
            this.txt_IssueDes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_IssueDes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(239, 153);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(187, 23);
            this.txt_email.TabIndex = 72;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pnum
            // 
            // 
            // 
            // 
            this.txt_pnum.CustomButton.Image = null;
            this.txt_pnum.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_pnum.CustomButton.Name = "";
            this.txt_pnum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pnum.CustomButton.TabIndex = 1;
            this.txt_pnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pnum.CustomButton.UseSelectable = true;
            this.txt_pnum.CustomButton.Visible = false;
            this.txt_pnum.Lines = new string[0];
            this.txt_pnum.Location = new System.Drawing.Point(18, 153);
            this.txt_pnum.MaxLength = 32767;
            this.txt_pnum.Name = "txt_pnum";
            this.txt_pnum.PasswordChar = '\0';
            this.txt_pnum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pnum.SelectedText = "";
            this.txt_pnum.SelectionLength = 0;
            this.txt_pnum.SelectionStart = 0;
            this.txt_pnum.ShortcutsEnabled = true;
            this.txt_pnum.Size = new System.Drawing.Size(187, 23);
            this.txt_pnum.TabIndex = 71;
            this.txt_pnum.UseSelectable = true;
            this.txt_pnum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pnum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_mn
            // 
            // 
            // 
            // 
            this.txt_mn.CustomButton.Image = null;
            this.txt_mn.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_mn.CustomButton.Name = "";
            this.txt_mn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_mn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mn.CustomButton.TabIndex = 1;
            this.txt_mn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mn.CustomButton.UseSelectable = true;
            this.txt_mn.CustomButton.Visible = false;
            this.txt_mn.Lines = new string[0];
            this.txt_mn.Location = new System.Drawing.Point(440, 103);
            this.txt_mn.MaxLength = 32767;
            this.txt_mn.Name = "txt_mn";
            this.txt_mn.PasswordChar = '\0';
            this.txt_mn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mn.SelectedText = "";
            this.txt_mn.SelectionLength = 0;
            this.txt_mn.SelectionStart = 0;
            this.txt_mn.ShortcutsEnabled = true;
            this.txt_mn.Size = new System.Drawing.Size(187, 23);
            this.txt_mn.TabIndex = 70;
            this.txt_mn.UseSelectable = true;
            this.txt_mn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_fn
            // 
            // 
            // 
            // 
            this.txt_fn.CustomButton.Image = null;
            this.txt_fn.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_fn.CustomButton.Name = "";
            this.txt_fn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fn.CustomButton.TabIndex = 1;
            this.txt_fn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fn.CustomButton.UseSelectable = true;
            this.txt_fn.CustomButton.Visible = false;
            this.txt_fn.Lines = new string[0];
            this.txt_fn.Location = new System.Drawing.Point(239, 103);
            this.txt_fn.MaxLength = 32767;
            this.txt_fn.Name = "txt_fn";
            this.txt_fn.PasswordChar = '\0';
            this.txt_fn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fn.SelectedText = "";
            this.txt_fn.SelectionLength = 0;
            this.txt_fn.SelectionStart = 0;
            this.txt_fn.ShortcutsEnabled = true;
            this.txt_fn.Size = new System.Drawing.Size(187, 23);
            this.txt_fn.TabIndex = 69;
            this.txt_fn.UseSelectable = true;
            this.txt_fn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ln
            // 
            // 
            // 
            // 
            this.txt_ln.CustomButton.Image = null;
            this.txt_ln.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_ln.CustomButton.Name = "";
            this.txt_ln.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ln.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ln.CustomButton.TabIndex = 1;
            this.txt_ln.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ln.CustomButton.UseSelectable = true;
            this.txt_ln.CustomButton.Visible = false;
            this.txt_ln.Lines = new string[0];
            this.txt_ln.Location = new System.Drawing.Point(18, 103);
            this.txt_ln.MaxLength = 32767;
            this.txt_ln.Name = "txt_ln";
            this.txt_ln.PasswordChar = '\0';
            this.txt_ln.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ln.SelectedText = "";
            this.txt_ln.SelectionLength = 0;
            this.txt_ln.SelectionStart = 0;
            this.txt_ln.ShortcutsEnabled = true;
            this.txt_ln.Size = new System.Drawing.Size(187, 23);
            this.txt_ln.TabIndex = 68;
            this.txt_ln.UseSelectable = true;
            this.txt_ln.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ln.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtLeadReceived
            // 
            this.dtLeadReceived.Location = new System.Drawing.Point(18, 49);
            this.dtLeadReceived.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtLeadReceived.Name = "dtLeadReceived";
            this.dtLeadReceived.Size = new System.Drawing.Size(212, 29);
            this.dtLeadReceived.TabIndex = 67;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(18, 341);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(107, 19);
            this.metroLabel13.TabIndex = 66;
            this.metroLabel13.Text = "Lead assigned to";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(440, 258);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(225, 19);
            this.metroLabel12.TabIndex = 65;
            this.metroLabel12.Text = "Memo ( From GPG Staff/ LUKE/ GIL) ";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(239, 236);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(51, 19);
            this.metroLabel11.TabIndex = 64;
            this.metroLabel11.Text = "Priority";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(18, 280);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(131, 19);
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "Lead follow up status";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(239, 179);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(113, 19);
            this.metroLabel9.TabIndex = 62;
            this.metroLabel9.Text = "Lead Status Result";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(18, 179);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 61;
            this.metroLabel8.Text = "Lead Source";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(440, 131);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(330, 19);
            this.metroLabel7.TabIndex = 60;
            this.metroLabel7.Text = "Call / Issue Description (Notes about the call or Inquiry)";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(239, 131);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 19);
            this.metroLabel6.TabIndex = 59;
            this.metroLabel6.Text = "Email Address";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 131);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 19);
            this.metroLabel5.TabIndex = 58;
            this.metroLabel5.Text = "Phone Number";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(440, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 57;
            this.metroLabel4.Text = "Middle name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(239, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 56;
            this.metroLabel3.Text = "First name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 55;
            this.metroLabel2.Text = "Last name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(193, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Date of the Call/ Lead Received";
            // 
            // Frm_LeadAssigned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 635);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LeadAssigned";
            this.Resizable = false;
            this.Text = "Lead Assigned";
            this.Load += new System.EventHandler(this.Frm_LeadAssigned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxLeadAssesment;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.ComboBox cBoxLeadAssigned;
        private System.Windows.Forms.ComboBox cBoxPriority;
        private System.Windows.Forms.ComboBox cBoxLeadFollowUp;
        private MetroFramework.Controls.MetroTextBox txt_others;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.ComboBox cBoxLeadStats;
        private System.Windows.Forms.ComboBox cBoxLeadSource;
        private MetroFramework.Controls.MetroTextBox txt_memo;
        private MetroFramework.Controls.MetroTextBox txt_IssueDes;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_pnum;
        private MetroFramework.Controls.MetroTextBox txt_mn;
        private MetroFramework.Controls.MetroTextBox txt_fn;
        private MetroFramework.Controls.MetroTextBox txt_ln;
        private MetroFramework.Controls.MetroDateTime dtLeadReceived;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}