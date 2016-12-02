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
using MetroFramework.Controls;
using System.Data.SqlClient;
using System.Configuration;


namespace RVL_Management_System
{
    public partial class Frm_UserEdit : MetroForm
    {
        public static string acctID = "";
        public static string userID = "";
        public static string loginID = "";
        public static string lastName = "";
        public static string firstName = "";
        public static string middleName = "";
        public static string userName = "";
        public static string passWord = "";
        public static string role = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_UserEdit()
        {
            InitializeComponent(); 

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void UserSearch()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT L.LID, U.UID, U.Last_Name, U.First_Name, U.Middle_Name, L.UN, L.PW, A.Account FROM tblUser AS U LEFT JOIN tblLogin AS L ON U.UID = L.UID LEFT JOIN tblAccount AS A ON U.AcctID = A.AcctID WHERE U.UID=@uid";
            cmd.Parameters.AddWithValue("uid", txt_userID.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;
            
            conn.Close();

            cmd.Parameters.Clear();
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

        private void Frm_UserEdit_Load(object sender, EventArgs e)
        {
            loadUserype();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this information?", "Sample System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                acctID = txt_level.Text;
                userID = txt_userID.Text;
                loginID = txt_lid.Text;
                lastName = txt_ln.Text;
                firstName = txt_fn.Text;
                middleName = txt_mn.Text;
                userName = txt_un.Text;
                passWord = txt_pw.Text;
                role = cBoxRole.Text;
                Class.Cls_cmd.updateLogin();
                Class.Cls_cmd.updateUser();
            }
            else
            {
                //TODO:NOTHING
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            UserSearch();
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
                txt_lid.Text = row.Cells[0].Value.ToString();
                txt_uid.Text = row.Cells[1].Value.ToString();
                txt_ln.Text = row.Cells[2].Value.ToString();
                txt_fn.Text = row.Cells[3].Value.ToString();
                txt_mn.Text = row.Cells[4].Value.ToString();
                txt_un.Text = row.Cells[5].Value.ToString();
                txt_pw.Text = row.Cells[6].Value.ToString();
                cBoxRole.Text = row.Cells[7].Value.ToString();
            }
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
    }
}
