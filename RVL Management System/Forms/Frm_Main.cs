using System;
using RVL_Management_System.Forms;
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

namespace RVL_Management_System
{
    public partial class Frm_Main : MetroForm
    {
        private int childFormNumber = 0;
        public static string task = "";
        public static string name = "";

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
            lbl_name.Text = Frm_Login.fullName;

            name = lbl_name.Text;
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UserMenu Umenu = new UserMenu();
            Umenu.ShowDialog();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        void _pnlone_Shown(object sender, EventArgs e)
        {

        }

        void _pnlone_Closed(object sender, EventArgs e)
        {
            btn_marketing.Enabled = true;
        }
        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Forms.TrainingMaterials ftrain = new Forms.TrainingMaterials();
            ftrain.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Forms.Email femail = new Forms.Email();
            femail.ShowDialog();
        }

        private void btn_marketing_Click(object sender, EventArgs e)
        {
          
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to logout?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Login flogin = new Frm_Login();
                flogin.Show();
                this.Hide();
            }
            else
            {
                //TODO:NOTHING
            }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            Frm_Tasks ftask = new Frm_Tasks();
            ftask.Show();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroLink2_Click_1(object sender, EventArgs e)
        {
            AddLeadSource flead = new AddLeadSource();
            flead.ShowDialog();
        }

        private void metroLink2_Click_2(object sender, EventArgs e)
        {
            LeadAssigned fassigned = new LeadAssigned();
            fassigned.ShowDialog();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            CompanyLoginsMenu flogins = new CompanyLoginsMenu();
            flogins.ShowDialog();
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            PropertyAccountingMenu fmenu = new PropertyAccountingMenu();
            fmenu.ShowDialog();
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            SocialMediaMenu fsocial = new SocialMediaMenu();
            fsocial.ShowDialog();
        }

        private void metroLink6_Click(object sender, EventArgs e)
        {
            LandStay fland = new LandStay();
            fland.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void metroLink7_Click(object sender, EventArgs e)
        {
            TrainingMaterials ftrain = new TrainingMaterials();
            ftrain.ShowDialog();
        }

        private void metroLink8_Click(object sender, EventArgs e)
        {
            VideoTutorialsMenu vMenu = new VideoTutorialsMenu();
            vMenu.ShowDialog();
        }

        private void metroLink9_Click(object sender, EventArgs e)
        {
            LandsOwnedDeedAdventure adventure = new LandsOwnedDeedAdventure();
            adventure.ShowDialog();
        }

        private void metroLink8_Click_1(object sender, EventArgs e)
        {
            Email email = new Email();
            email.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {

        }
    }
}
