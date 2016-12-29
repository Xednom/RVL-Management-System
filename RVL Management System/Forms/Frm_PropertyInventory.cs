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
    public partial class Frm_PropertyInventory : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_PropertyInventory()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadLeadSource()
        {

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblLeadSource";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gLeadDes = reader.GetString(reader.GetOrdinal("LeadDescription"));
                cBoxLeadSource.Items.Add(gLeadDes);
            }
            conn.Close();
        }

        public void loadLandOwner()
        {

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblLandOwner";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gLandOwn = reader.GetString(reader.GetOrdinal("Land_Owner"));
                cBoxLandOwner.Items.Add(gLandOwn);
            }
            conn.Close();
        }

        private void Frm_PropertyInventory_Load(object sender, EventArgs e)
        {
            loadLeadSource();
            loadLandOwner();
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Frm_SocialMedia fsocial = new Frm_SocialMedia();
            fsocial.ShowDialog();
        }
    }
}
