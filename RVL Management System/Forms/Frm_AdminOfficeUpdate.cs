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
    public partial class Frm_AdminOfficeUpdate : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_AdminOfficeUpdate()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchAdminID()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblAdminContact WHERE ACID = @acid";
            cmd.Parameters.AddWithValue("acid", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchAdminFName()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblAdminContact WHERE Full_name LIKE @fname";
            cmd.Parameters.AddWithValue("fname", "%" + txt_search.Text + "%");
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void Frm_AdminOfficeUpdate_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "Admin Contact ID")
            {
                searchAdminID();
            }
            if (cBoxSearchBy.Text == "Full name")
            {
                searchAdminFName();
            }
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
                txt_acid.Text = row.Cells[0].Value.ToString();
                txt_fullName.Text = row.Cells[1].Value.ToString();
                txt_email.Text = row.Cells[2].Value.ToString();
                txt_phoneNumber.Text = row.Cells[3].Value.ToString();
                txt_address.Text = row.Cells[4].Value.ToString();
                txt_county.Text = row.Cells[5].Value.ToString();
                cBoxCategory.Text = row.Cells[6].Value.ToString();

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
