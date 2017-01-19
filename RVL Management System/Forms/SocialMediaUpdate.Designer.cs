namespace RVL_Management_System.Forms
{
    partial class SocialMediaUpdate
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.txt_addiotnalNotes = new MetroFramework.Controls.MetroTextBox();
            this.cBoxStatus = new MetroFramework.Controls.MetroComboBox();
            this.cBoxPreApproved = new MetroFramework.Controls.MetroComboBox();
            this.txt_schedule = new MetroFramework.Controls.MetroTextBox();
            this.txt_hashtags = new MetroFramework.Controls.MetroTextBox();
            this.txt_socialmedia = new MetroFramework.Controls.MetroTextBox();
            this.txt_title = new MetroFramework.Controls.MetroTextBox();
            this.txt_updatePrice = new MetroFramework.Controls.MetroTextBox();
            this.txt_current = new MetroFramework.Controls.MetroTextBox();
            this.txt_apn = new MetroFramework.Controls.MetroTextBox();
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
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cBoxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(103, 283);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 43;
            this.metroButton2.Text = "&Clear";
            this.metroButton2.UseSelectable = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(23, 283);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 42;
            this.btn_update.Text = "&Update";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_addiotnalNotes
            // 
            // 
            // 
            // 
            this.txt_addiotnalNotes.CustomButton.Image = null;
            this.txt_addiotnalNotes.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txt_addiotnalNotes.CustomButton.Name = "";
            this.txt_addiotnalNotes.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.txt_addiotnalNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addiotnalNotes.CustomButton.TabIndex = 1;
            this.txt_addiotnalNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addiotnalNotes.CustomButton.UseSelectable = true;
            this.txt_addiotnalNotes.CustomButton.Visible = false;
            this.txt_addiotnalNotes.Lines = new string[0];
            this.txt_addiotnalNotes.Location = new System.Drawing.Point(730, 224);
            this.txt_addiotnalNotes.MaxLength = 32767;
            this.txt_addiotnalNotes.Multiline = true;
            this.txt_addiotnalNotes.Name = "txt_addiotnalNotes";
            this.txt_addiotnalNotes.PasswordChar = '\0';
            this.txt_addiotnalNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addiotnalNotes.SelectedText = "";
            this.txt_addiotnalNotes.SelectionLength = 0;
            this.txt_addiotnalNotes.SelectionStart = 0;
            this.txt_addiotnalNotes.ShortcutsEnabled = true;
            this.txt_addiotnalNotes.Size = new System.Drawing.Size(323, 93);
            this.txt_addiotnalNotes.TabIndex = 41;
            this.txt_addiotnalNotes.UseSelectable = true;
            this.txt_addiotnalNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addiotnalNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.ItemHeight = 23;
            this.cBoxStatus.Items.AddRange(new object[] {
            "Complete",
            "Incomplete",
            "Changes has to be made"});
            this.cBoxStatus.Location = new System.Drawing.Point(570, 224);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(121, 29);
            this.cBoxStatus.TabIndex = 40;
            this.cBoxStatus.UseSelectable = true;
            // 
            // cBoxPreApproved
            // 
            this.cBoxPreApproved.FormattingEnabled = true;
            this.cBoxPreApproved.ItemHeight = 23;
            this.cBoxPreApproved.Items.AddRange(new object[] {
            "Gil",
            "Luke"});
            this.cBoxPreApproved.Location = new System.Drawing.Point(421, 224);
            this.cBoxPreApproved.Name = "cBoxPreApproved";
            this.cBoxPreApproved.Size = new System.Drawing.Size(121, 29);
            this.cBoxPreApproved.TabIndex = 39;
            this.cBoxPreApproved.UseSelectable = true;
            // 
            // txt_schedule
            // 
            // 
            // 
            // 
            this.txt_schedule.CustomButton.Image = null;
            this.txt_schedule.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txt_schedule.CustomButton.Name = "";
            this.txt_schedule.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_schedule.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_schedule.CustomButton.TabIndex = 1;
            this.txt_schedule.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_schedule.CustomButton.UseSelectable = true;
            this.txt_schedule.CustomButton.Visible = false;
            this.txt_schedule.Lines = new string[0];
            this.txt_schedule.Location = new System.Drawing.Point(234, 224);
            this.txt_schedule.MaxLength = 32767;
            this.txt_schedule.Name = "txt_schedule";
            this.txt_schedule.PasswordChar = '\0';
            this.txt_schedule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_schedule.SelectedText = "";
            this.txt_schedule.SelectionLength = 0;
            this.txt_schedule.SelectionStart = 0;
            this.txt_schedule.ShortcutsEnabled = true;
            this.txt_schedule.Size = new System.Drawing.Size(155, 23);
            this.txt_schedule.TabIndex = 38;
            this.txt_schedule.UseSelectable = true;
            this.txt_schedule.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_schedule.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_hashtags
            // 
            // 
            // 
            // 
            this.txt_hashtags.CustomButton.Image = null;
            this.txt_hashtags.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txt_hashtags.CustomButton.Name = "";
            this.txt_hashtags.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_hashtags.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_hashtags.CustomButton.TabIndex = 1;
            this.txt_hashtags.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_hashtags.CustomButton.UseSelectable = true;
            this.txt_hashtags.CustomButton.Visible = false;
            this.txt_hashtags.Lines = new string[0];
            this.txt_hashtags.Location = new System.Drawing.Point(23, 224);
            this.txt_hashtags.MaxLength = 32767;
            this.txt_hashtags.Name = "txt_hashtags";
            this.txt_hashtags.PasswordChar = '\0';
            this.txt_hashtags.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_hashtags.SelectedText = "";
            this.txt_hashtags.SelectionLength = 0;
            this.txt_hashtags.SelectionStart = 0;
            this.txt_hashtags.ShortcutsEnabled = true;
            this.txt_hashtags.Size = new System.Drawing.Size(163, 23);
            this.txt_hashtags.TabIndex = 37;
            this.txt_hashtags.UseSelectable = true;
            this.txt_hashtags.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_hashtags.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_socialmedia
            // 
            // 
            // 
            // 
            this.txt_socialmedia.CustomButton.Image = null;
            this.txt_socialmedia.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txt_socialmedia.CustomButton.Name = "";
            this.txt_socialmedia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_socialmedia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_socialmedia.CustomButton.TabIndex = 1;
            this.txt_socialmedia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_socialmedia.CustomButton.UseSelectable = true;
            this.txt_socialmedia.CustomButton.Visible = false;
            this.txt_socialmedia.Lines = new string[0];
            this.txt_socialmedia.Location = new System.Drawing.Point(890, 145);
            this.txt_socialmedia.MaxLength = 32767;
            this.txt_socialmedia.Name = "txt_socialmedia";
            this.txt_socialmedia.PasswordChar = '\0';
            this.txt_socialmedia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_socialmedia.SelectedText = "";
            this.txt_socialmedia.SelectionLength = 0;
            this.txt_socialmedia.SelectionStart = 0;
            this.txt_socialmedia.ShortcutsEnabled = true;
            this.txt_socialmedia.Size = new System.Drawing.Size(163, 23);
            this.txt_socialmedia.TabIndex = 36;
            this.txt_socialmedia.UseSelectable = true;
            this.txt_socialmedia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_socialmedia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_title
            // 
            // 
            // 
            // 
            this.txt_title.CustomButton.Image = null;
            this.txt_title.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.txt_title.CustomButton.Name = "";
            this.txt_title.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_title.CustomButton.TabIndex = 1;
            this.txt_title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_title.CustomButton.UseSelectable = true;
            this.txt_title.CustomButton.Visible = false;
            this.txt_title.Lines = new string[0];
            this.txt_title.Location = new System.Drawing.Point(533, 145);
            this.txt_title.MaxLength = 32767;
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_title.SelectedText = "";
            this.txt_title.SelectionLength = 0;
            this.txt_title.SelectionStart = 0;
            this.txt_title.ShortcutsEnabled = true;
            this.txt_title.Size = new System.Drawing.Size(326, 23);
            this.txt_title.TabIndex = 35;
            this.txt_title.UseSelectable = true;
            this.txt_title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_updatePrice
            // 
            // 
            // 
            // 
            this.txt_updatePrice.CustomButton.Image = null;
            this.txt_updatePrice.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_updatePrice.CustomButton.Name = "";
            this.txt_updatePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_updatePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_updatePrice.CustomButton.TabIndex = 1;
            this.txt_updatePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_updatePrice.CustomButton.UseSelectable = true;
            this.txt_updatePrice.CustomButton.Visible = false;
            this.txt_updatePrice.Lines = new string[0];
            this.txt_updatePrice.Location = new System.Drawing.Point(383, 145);
            this.txt_updatePrice.MaxLength = 32767;
            this.txt_updatePrice.Name = "txt_updatePrice";
            this.txt_updatePrice.PasswordChar = '\0';
            this.txt_updatePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_updatePrice.SelectedText = "";
            this.txt_updatePrice.SelectionLength = 0;
            this.txt_updatePrice.SelectionStart = 0;
            this.txt_updatePrice.ShortcutsEnabled = true;
            this.txt_updatePrice.Size = new System.Drawing.Size(132, 23);
            this.txt_updatePrice.TabIndex = 34;
            this.txt_updatePrice.UseSelectable = true;
            this.txt_updatePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_updatePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_current
            // 
            // 
            // 
            // 
            this.txt_current.CustomButton.Image = null;
            this.txt_current.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txt_current.CustomButton.Name = "";
            this.txt_current.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_current.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_current.CustomButton.TabIndex = 1;
            this.txt_current.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_current.CustomButton.UseSelectable = true;
            this.txt_current.CustomButton.Visible = false;
            this.txt_current.Lines = new string[0];
            this.txt_current.Location = new System.Drawing.Point(234, 145);
            this.txt_current.MaxLength = 32767;
            this.txt_current.Name = "txt_current";
            this.txt_current.PasswordChar = '\0';
            this.txt_current.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_current.SelectedText = "";
            this.txt_current.SelectionLength = 0;
            this.txt_current.SelectionStart = 0;
            this.txt_current.ShortcutsEnabled = true;
            this.txt_current.Size = new System.Drawing.Size(132, 23);
            this.txt_current.TabIndex = 33;
            this.txt_current.UseSelectable = true;
            this.txt_current.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_current.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_apn
            // 
            // 
            // 
            // 
            this.txt_apn.CustomButton.Image = null;
            this.txt_apn.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txt_apn.CustomButton.Name = "";
            this.txt_apn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_apn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apn.CustomButton.TabIndex = 1;
            this.txt_apn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apn.CustomButton.UseSelectable = true;
            this.txt_apn.CustomButton.Visible = false;
            this.txt_apn.Lines = new string[0];
            this.txt_apn.Location = new System.Drawing.Point(23, 145);
            this.txt_apn.MaxLength = 32767;
            this.txt_apn.Name = "txt_apn";
            this.txt_apn.PasswordChar = '\0';
            this.txt_apn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apn.SelectedText = "";
            this.txt_apn.SelectionLength = 0;
            this.txt_apn.SelectionStart = 0;
            this.txt_apn.ShortcutsEnabled = true;
            this.txt_apn.Size = new System.Drawing.Size(163, 23);
            this.txt_apn.TabIndex = 32;
            this.txt_apn.UseSelectable = true;
            this.txt_apn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_apn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(730, 202);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(107, 19);
            this.metroLabel10.TabIndex = 31;
            this.metroLabel10.Text = "Additional Notes";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(570, 202);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(43, 19);
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "Status";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(421, 202);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 19);
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Pre-Approved";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(234, 202);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(140, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Schedule to be posted";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 202);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Hashtags to use";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(890, 123);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Social Media Notes";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(533, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Title";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(383, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Update Price";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(234, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(132, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Current Market Value";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 123);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "APN ID";
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = null;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.Visible = false;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(234, 82);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(163, 23);
            this.txt_search.TabIndex = 45;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(234, 60);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(48, 19);
            this.metroLabel11.TabIndex = 44;
            this.metroLabel11.Text = "Search";
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.ItemHeight = 23;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "APN ID",
            "Title"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(23, 82);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(163, 29);
            this.cBoxSearchBy.TabIndex = 47;
            this.cBoxSearchBy.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(23, 60);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(66, 19);
            this.metroLabel12.TabIndex = 46;
            this.metroLabel12.Text = "Search By";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(403, 82);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 48;
            this.metroButton1.Text = "&Search";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            this.GridView.Location = new System.Drawing.Point(23, 333);
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
            this.GridView.Size = new System.Drawing.Size(1072, 194);
            this.GridView.TabIndex = 49;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // Frm_SocialMediaUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 550);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cBoxSearchBy);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_addiotnalNotes);
            this.Controls.Add(this.cBoxStatus);
            this.Controls.Add(this.cBoxPreApproved);
            this.Controls.Add(this.txt_schedule);
            this.Controls.Add(this.txt_hashtags);
            this.Controls.Add(this.txt_socialmedia);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_updatePrice);
            this.Controls.Add(this.txt_current);
            this.Controls.Add(this.txt_apn);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SocialMediaUpdate";
            this.Resizable = false;
            this.Text = "Update Social Media Information";
            this.Load += new System.EventHandler(this.Frm_SocialMediaUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroTextBox txt_addiotnalNotes;
        private MetroFramework.Controls.MetroComboBox cBoxStatus;
        private MetroFramework.Controls.MetroComboBox cBoxPreApproved;
        private MetroFramework.Controls.MetroTextBox txt_schedule;
        private MetroFramework.Controls.MetroTextBox txt_hashtags;
        private MetroFramework.Controls.MetroTextBox txt_socialmedia;
        private MetroFramework.Controls.MetroTextBox txt_title;
        private MetroFramework.Controls.MetroTextBox txt_updatePrice;
        private MetroFramework.Controls.MetroTextBox txt_current;
        private MetroFramework.Controls.MetroTextBox txt_apn;
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
        private MetroFramework.Controls.MetroTextBox txt_search;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cBoxSearchBy;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid GridView;
    }
}