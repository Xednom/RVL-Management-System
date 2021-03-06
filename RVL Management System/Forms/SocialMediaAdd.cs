﻿using System;
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
    public partial class SocialMediaAdd : MetroForm
    {
        public static string apnID = "";
        public static string currentMarketValue = "";
        public static string updatedPrice = "";
        public static string title = "";
        public static string socialMediaNotes = "";
        public static string hashtagsToUse = "";
        public static string scheduleToBePosted = "";
        public static string preApproved = "";
        public static string status = "";
        public static string additionalNotes = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public void clearField()
        {
            txt_current.Text = null;
            txt_updatePrice.Text = null;
            txt_title.Text = null;
            txt_socialmedia.Text = null;
            txt_hashtags.Text = null;
            txt_schedule.Text = null;
            cBoxPreApproved.Text = null;
            cBoxStatus.Text = null;
            txt_addiotnalNotes.Text = null;
        }
        public void refresh()
        {
            conn.Open();
            cmd.Connection = conn;
            string LOAD = "SELECT * FROM tblSocialMedia";
            cmd.CommandText = LOAD;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;

            conn.Close();

            cmd.Parameters.Clear();
        }

        public SocialMediaAdd()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void Frm_SocialMediaAdd_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to save this information?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentMarketValue = txt_current.Text;
                updatedPrice = txt_updatePrice.Text;
                title = txt_title.Text;
                socialMediaNotes = txt_socialmedia.Text;
                hashtagsToUse = txt_hashtags.Text;
                scheduleToBePosted = txt_schedule.Text;
                preApproved = cBoxPreApproved.Text;
                status = cBoxStatus.Text;
                additionalNotes = txt_addiotnalNotes.Text;
                Class.Cls_cmd.socialMediaAdd();
                clearField();
                refresh();
            }
            else
            {
                //IF NO
                //TODO:NOTHING
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearField();
        }
    }
}
