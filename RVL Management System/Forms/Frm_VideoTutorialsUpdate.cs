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
    public partial class Frm_VideoTutorialsUpdate : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string process = "";
        public static string link = "";

        public Frm_VideoTutorialsUpdate()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void searchProcess()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblVideoTutorial WHERE Process = @process";
            cmd.Parameters.AddWithValue("process", txt_search.Text);
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public void searchcideoID()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblVideoTutorial WHERE VID LIKE @vid";
            cmd.Parameters.AddWithValue("vid", "%" + txt_search.Text + "%");
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void Frm_VideoTutorialsUpdate_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            searchProcess();
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
                txt_vid.Text = row.Cells[0].Value.ToString();
                txt_process.Text = row.Cells[1].Value.ToString();
                txt_youtube.Text = row.Cells[2].Value.ToString();

            }
        }
    }
}
