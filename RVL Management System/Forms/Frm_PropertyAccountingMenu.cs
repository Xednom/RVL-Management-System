using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace RVL_Management_System.Forms
{
    public partial class Frm_PropertyAccountingMenu : MetroForm
    {
        public Frm_PropertyAccountingMenu()
        {
            InitializeComponent();
        }

        private void Frm_PropertyAccountingMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Frm_PropertyAccountingBusiness fbusiness = new Frm_PropertyAccountingBusiness();
            fbusiness.ShowDialog();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            Frm_PropertyAccountingPersonal fpersonal = new Frm_PropertyAccountingPersonal();
            fpersonal.ShowDialog(); 
        }
    }
}
