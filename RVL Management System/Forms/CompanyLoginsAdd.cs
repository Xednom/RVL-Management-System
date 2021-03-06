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

namespace RVL_Management_System.Forms
{
    public partial class CompanyLoginsAdd : MetroForm
    {
        public static string categoryName = "";
        public static string URLlink = "";
        public static string userName = "";
        public static string passWord = "";
        public static string nameLogin = "";
        public static string giveAccess = "";

        public CompanyLoginsAdd()
        {
            InitializeComponent();
        }

        private void Frm_CompanyLogins_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (txt_categoryName.Text == string.Empty || txt_giveAccess.Text == string.Empty || txt_nameLogin.Text == string.Empty || txt_pw.Text == string.Empty || txt_un.Text == string.Empty || txt_url.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please fill-up the required information.", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }

            if (MetroMessageBox.Show(this, "Do you want to save this information ?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                categoryName = txt_categoryName.Text;
                URLlink = txt_url.Text;
                userName = txt_un.Text;
                passWord = txt_pw.Text;
                nameLogin = txt_nameLogin.Text;
                giveAccess = txt_giveAccess.Text;
                Class.Cls_cmd.companyAdd();
            }
            else
            {
                //IF NO
                //TODO: NOTHING
            }
        }
    }
}
