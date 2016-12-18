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

namespace RVL_Management_System
{
    public partial class Frm_UserMenu : MetroForm
    {
        public Frm_UserMenu()
        {
            InitializeComponent();
        }

        private void Frm_UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Frm_UserEdit fedit = new Frm_UserEdit();
            fedit.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Frm_UserView fview = new Frm_UserView();
            fview.ShowDialog();
        }
    }
}
