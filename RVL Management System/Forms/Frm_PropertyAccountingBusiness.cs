using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RVL_Management_System.Forms
{
    public partial class Frm_PropertyAccountingBusiness : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public Frm_PropertyAccountingBusiness()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
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
                cBoxSoldForom.Items.Add(gLandOwn);
            }
            conn.Close();
        }

        private void Frm_PropertyAccounting_Load(object sender, EventArgs e)
        {
            loadLandOwner();
        }
    }
}
