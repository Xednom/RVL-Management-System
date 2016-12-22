using System;
using RVL_Management_System.Panel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using MetroFramework.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace RVL_Management_System
{
    public partial class Frm_LeadGeneration : PnlSlider
    {
        public static string leadReceived = "";
        public static string lastName = "";
        public static string firstName = "";
        public static string middleName = "";
        public static string phoneNumber = "";
        public static string emailAddress = "";
        public static string issueDescription = "";
        public static string leadSource = "";
        public static string leadStat = "";
        public static string leadFollow = "";
        public static string priority = "";
        public static string leadAssigned = "";
        public static string memo = "";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int AW_SLIDE = 0X40000;

        const int AW_HOR_POSITIVE = 0X1;

        const int AW_HOR_NEGATIVE = 0X2;

        const int AW_BLEND = 0X80000;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public Frm_LeadGeneration(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        public void clear()
        {
            dtLeadReceived.Text = null;
            txt_ln.Text = null;
            txt_fn.Text = null;
            txt_mn.Text = null;
            txt_pnum.Text = null;
            txt_email.Text = null;
            txt_IssueDes.Text = null;
            cBoxLeadSource.Text = null;
            cBoxLeadStats.Text = null;
            cBoxLeadFollowUp.Text = null;
            cBoxPriority.Text = null;
            cBoxLeadAssigned.Text = null;
            txt_memo.Text = null;
        }

        public void loadLeadSource()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblLeadSource";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gLeadDes = reader.GetString(reader.GetOrdinal("LeadDescription"));
               cBoxLeadSource.Items.Add(gLeadDes);
            }
            conn.Close();
        }

        public void loadLeadAssigned()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblUser";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gFullname = reader.GetString(reader.GetOrdinal("Full_Name"));
                cBoxLeadAssigned.Items.Add(gFullname);
            }
            conn.Close();
        }

        private void Frm_LeadGeneration_Load(object sender, EventArgs e)
        {
            loadLeadSource();

            loadLeadAssigned();

            cBoxLeadSource.Items.Add("Others..");

            cBoxLeadStats.Items.Add("Prospect");
            cBoxLeadStats.Items.Add("Qualified Lead");
            cBoxLeadStats.Items.Add("Buyer");
            cBoxLeadStats.Items.Add("Seller");
            cBoxLeadStats.Items.Add("Invalid Lead");
            
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
        
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
        
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //swipe(false);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            leadReceived = dtLeadReceived.Text;
            lastName = txt_ln.Text;
            firstName = txt_fn.Text;
            middleName = txt_mn.Text;
            phoneNumber = txt_pnum.Text;
            emailAddress = txt_email.Text;
            issueDescription = txt_IssueDes.Text;
            leadSource = cBoxLeadSource.Text;
            leadStat = cBoxLeadStats.Text;
            leadFollow = cBoxLeadFollowUp.Text;
            priority = cBoxPriority.Text;
            leadAssigned = cBoxLeadAssigned.Text;
            memo = txt_memo.Text;
            Class.Cls_cmd.marketingAdd();
            clear();
        }

        private void txt_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Frm_LeadGeneration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            swipe(false);
        }

        private void cBoxLeadSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxLeadSource.Text == "Others..")
            {
                txt_others.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}
