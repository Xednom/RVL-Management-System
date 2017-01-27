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

namespace RVL_Management_System.Forms
{
    public partial class Main : MetroForm
    {
        public static string name = "";
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_Usertype.Text = Frm_Login.UserType;
            lbl_name.Text = Frm_Login.fullName;

            name = lbl_name.Text;

            TabControlMain.SelectedTab = tabPage1;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Frm_UserAdd userAdd = new Frm_UserAdd();
            userAdd.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Frm_UserEdit userEdit = new Frm_UserEdit();
            userEdit.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Frm_UserView userView = new Frm_UserView();
            userView.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            CompanyLoginsAdd companyAdd = new CompanyLoginsAdd();
            companyAdd.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            CompanyLoginsUpdate companyEdit = new CompanyLoginsUpdate();
            companyEdit.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            CompanyLoginsDelete companyDelete = new CompanyLoginsDelete();
            companyDelete.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            CompanyLoginsView companyView = new CompanyLoginsView();
            companyView.ShowDialog();
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            SocialMediaAdd socialAdd = new SocialMediaAdd();
            socialAdd.ShowDialog();
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            SocialMediaUpdate socialEdit = new SocialMediaUpdate();
            socialEdit.ShowDialog();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            SocialMediaExport socialExport = new SocialMediaExport();
            socialExport.ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            SocialMediaView socialView = new SocialMediaView();
            socialView.ShowDialog();
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            PropertyAccountingBusiness accountBusiness = new PropertyAccountingBusiness();
            accountBusiness.ShowDialog();
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            PropertyAccountingPersonal accountPersonal = new PropertyAccountingPersonal();
            accountPersonal.ShowDialog();
        }

        private void metroTile19_Click(object sender, EventArgs e)
        {
            VideoTutorialsAdd vAdd = new VideoTutorialsAdd();
            vAdd.ShowDialog();
        }

        private void metroTile18_Click(object sender, EventArgs e)
        {
            VideoTutorialsUpdate vUpdate = new VideoTutorialsUpdate();
            vUpdate.ShowDialog();
        }

        private void metroTile17_Click(object sender, EventArgs e)
        {
            VideoTutorialsDelete vDelete = new VideoTutorialsDelete();
            vDelete.ShowDialog();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            VideoTutorialsView vView = new VideoTutorialsView();
            vView.ShowDialog();
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            VideoTutorialsExport vExport = new VideoTutorialsExport();
            vExport.ShowDialog();
        }
    }
}
