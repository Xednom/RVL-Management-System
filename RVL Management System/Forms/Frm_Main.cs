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
    public partial class Frm_Main : MetroForm
    {
        private int childFormNumber = 0;

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lbl_Usertype.Text = Frm_Login.UserType;
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Frm_Tasks ftask = new Frm_Tasks();
            ftask.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Frm_UserMenu fmenu = new Frm_UserMenu();
            fmenu.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Frm_LeadGeneration flead = new Frm_LeadGeneration();
            flead.ShowDialog();
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Forms.Frm_TrainingMaterials ftrain = new Forms.Frm_TrainingMaterials();
            ftrain.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Forms.Frm_Email femail = new Forms.Frm_Email();
            femail.ShowDialog();
        }
    }
}
