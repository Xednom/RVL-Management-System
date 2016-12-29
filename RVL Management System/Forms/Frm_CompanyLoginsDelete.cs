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

namespace RVL_Management_System.Forms
{
    public partial class Frm_CompanyLoginsDelete : MetroForm
    {
        public static string CID = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_CompanyLoginsDelete()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void search()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblCompanyLogins WHERE Category_Name = @cn";
            cmd.Parameters.AddWithValue("cn", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void refresh()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblCompanyLogins";
            cmd.Parameters.AddWithValue("cn", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void Frm_CompanyLoginsDelete_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
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
                txt_cid.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_cid.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please select a data to delete!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MetroMessageBox.Show(this, "Do you want to delete this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CID = txt_cid.Text;
                    Class.Cls_cmd.companyDelete();
                    refresh();
                }
                else
                {
                    //IF NO
                    //TODO: NOTHING
                }
            }
        }
    }
}
