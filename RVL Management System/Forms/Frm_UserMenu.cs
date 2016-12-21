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
    public partial class Frm_UserMenu : Panel.PnlSlider
    {
        public Frm_UserMenu(Form owner) : base(owner)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            swipe(false);
        }

        private void Frm_UserMenu_MouseHover(object sender, EventArgs e)
        {
            this.Region = new Region(new Rectangle(0, 0, this.Width, this.Height));
        }
    }
}
