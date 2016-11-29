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
using MetroFramework;
using System.Data.SqlClient;
using System.Configuration;

namespace RVL_Management_System
{
    public partial class Frm_Login : MetroForm
    {
        public static string UserTypeParam = "";
        public static string UserType = "";
        public static string Username = "";
        public static string Password = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_Login()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            string LOGIN = "SELECT A.Account, L.UN, L.PW FROM tblUser AS U LEFT JOIN tblAccount AS A ON A.AcctID = U.AcctID LEFT JOIN tblLogin AS L ON L.AcctID = U.AcctID WHERE L.UN = @un AND L.PW = @pw AND A.Account = @ut";
            cmd.Parameters.AddWithValue("un", txt_un.Text);
            cmd.Parameters.AddWithValue("pw", txt_pw.Text);
            cmd.Parameters.AddWithValue("ut", cBoxUsertype.Text);
            cmd.CommandText = LOGIN;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Welcome!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                UserType = cBoxUsertype.Text;
                Frm_Main fmain = new Frm_Main();
                fmain.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            conn.Close();
            cmd.Parameters.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Exit?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //TODO: NOTHING
            }
        }
    }
}
