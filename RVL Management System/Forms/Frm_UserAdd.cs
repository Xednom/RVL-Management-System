using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RVL_Management_System
{
    public partial class Frm_UserAdd : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public static string lastName = "";
        public static string firstName = "";
        public static string middleName = "";
        public static string email = "";
        public static string userName = "";
        public static string Password = "";
        public static string role = "";
        public static string acctID = "";
        public static string uID = "";

        public Frm_UserAdd()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }
        public void loadUserype()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblAccount";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gCategory = reader.GetString(reader.GetOrdinal("Account"));
                cBoxRole.Items.Add(gCategory);
            }
            conn.Close();
        }

        public void loadUID()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT IDENT_CURRENT('tblLogin')+1[UID]";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gUid = reader.GetDecimal(reader.GetOrdinal("UID")).ToString();
                txt_userID.Text = gUid;
            }
            conn.Close();
        }

        private void Frm_UserAdd_Load(object sender, EventArgs e)
        {
            loadUID();
            loadUserype();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void cBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxRole.Text == "Admin")
            {
                txt_level.Text = "1";
            }
            else
            {
                txt_level.Text = "2";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            userName = txt_un.Text;
            Password = txt_pw.Text;
            role = cBoxRole.Text;
            acctID = txt_level.Text;
            uID = txt_userID.Text;
            lastName = txt_ln.Text;
            firstName = txt_fn.Text;
            middleName = txt_mi.Text;
            email = txt_email.Text;
            Class.Cls_cmd.userAdd();
            Class.Cls_cmd.userLogin();
        }

        private void txt_confirmPw_TextChanged(object sender, EventArgs e)
        {
            txt_confirmPw.Text.CompareTo(txt_pw.Text);
        }
    }
}
