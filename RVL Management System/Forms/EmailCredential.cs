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

namespace RVL_Management_System.Forms
{
    public partial class EmailCredential : MetroForm
    {
        public static string email = "";
        public static string password = "";

        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public EmailCredential()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void EmailCredential_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            string LOGIN = "SELECT * FROM Email WHERE Email = @email";
            cmd.Parameters.AddWithValue("email", txt_email.Text);
            cmd.CommandText = LOGIN;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                email = txt_email.Text;
                password = txt_pw.Text;
                Class.Cls_cmd.emailUpdate();
            }
            else if (count == 0)
            {
                email = txt_email.Text;
                password = txt_pw.Text;
                Class.Cls_cmd.emailAdd();
            }
            conn.Close();

            cmd.Parameters.Clear();

            
            
        }
    }
}
