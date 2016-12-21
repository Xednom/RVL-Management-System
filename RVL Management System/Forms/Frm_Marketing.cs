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
            txt_leadSource.Text = null;
            txt_leadStat.Text = null;
            txt_leadFollow.Text = null;
            txt_priority.Text = null;
            txt_leadAssigned.Text = null;
            txt_memo.Text = null;
        }

        private void Frm_LeadGeneration_Load(object sender, EventArgs e)
        {
            
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
            leadSource = txt_leadSource.Text;
            leadStat = txt_leadStat.Text;
            leadFollow = txt_leadFollow.Text;
            priority = txt_priority.Text;
            leadAssigned = txt_leadAssigned.Text;
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
    }
}
