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
        public static string fullName = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_Login()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadName()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT Full_Name FROM tblUser AS U LEFT JOIN tblLogin AS L ON L.UID = U.UID WHERE L.UN = @userName";
            cmd.Parameters.AddWithValue("userName", txt_un.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            string LOGIN = "SELECT A.Account, L.UN, L.PW, U.Full_Name FROM tblUser AS U LEFT JOIN tblAccount AS A ON A.AcctID = U.AcctID LEFT JOIN tblLogin AS L ON L.AcctID = U.AcctID WHERE L.UN = @un AND L.PW = @pw AND A.Account = @ut";
            cmd.Parameters.AddWithValue("un", txt_un.Text);
            cmd.Parameters.AddWithValue("pw", txt_pw.Text);
            cmd.Parameters.AddWithValue("ut", cBoxUsertype.Text);
            cmd.CommandText = LOGIN;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Welcome", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UserType = cBoxUsertype.Text;
                fullName = txt_name.Text;
                Frm_Main fmain = new Frm_Main();
                fmain.Show();
                Hide();
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

        private void txt_un_TextChanged(object sender, EventArgs e)
        {
            loadName();
        }

        private void txt_un_Click(object sender, EventArgs e)
        {

        }

        private void GridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_name.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
