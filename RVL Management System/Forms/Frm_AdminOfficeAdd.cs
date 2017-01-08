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
    public partial class Frm_AdminOfficeAdd : MetroForm
    {
        public static string fullName = "";
        public static string email = "";
        public static string phoneNumber = "";
        public static string address = "";
        public static string county = "";
        public static string category = "";

        public Frm_AdminOfficeAdd()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txt_fullName.Text = null;
            txt_email.Text = null;
            txt_phoneNumber.Text = null;
            txt_address.Text = null;
            txt_county.Text = null;
            cBoxCategory.Text = null;
        }

        private void Frm_AdminOffice_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to save these informations?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fullName = txt_fullName.Text;
                email = txt_email.Text;
                phoneNumber = txt_phoneNumber.Text;
                address = txt_address.Text;
                county = txt_county.Text;
                category = cBoxCategory.Text;
                Class.Cls_cmd.adminOfficeAdd();
                clear();
            }
            else
            {
                //IF NO 
                //TODO:NOTHING
            }
        }
    }
}