using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MetroFramework.Forms;

namespace RVL_Management_System
{
    public partial class Frm_Tasks : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string uID = "";
        public static string taskAssign = "";

        public Frm_Tasks()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadTask()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblTask";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gCategory = reader.GetString(reader.GetOrdinal("Task"));
                cBoxTask.Items.Add(gCategory);
            }
            conn.Close();
        }

        public void taskSearch()
        {
            conn.Open();
            cmd.Connection = conn;
            string Show = "SELECT UID, Last_Name+', '+First_Name+' '+Middle_Name AS [Full name], TaskAssign FROM tblUser WHERE Last_Name=@ln";
            cmd.Parameters.AddWithValue("ln", txt_search.Text);
            cmd.CommandText = Show;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridTask.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        private void Frm_Tasks_Load(object sender, EventArgs e)
        {
            loadTask();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            taskSearch();
        }

        private void GridTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridTask_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in GridTask.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_uid.Text = row.Cells[0].Value.ToString();
                txt_name.Text = row.Cells[1].Value.ToString();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            uID = txt_uid.Text;
            taskAssign = cBoxTask.Text;
            Class.Cls_cmd.taskAssign();
        }
    }
}
