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
    public partial class Frm_ExportFiles : MetroForm
    {
        public Frm_ExportFiles()
        {
            InitializeComponent();
        }

        private void Frm_ExportFiles_Load(object sender, EventArgs e)
        {

        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            Frm_CompanyLoginsView fcompanyView = new Frm_CompanyLoginsView();
            fcompanyView.ShowDialog();
        }

        private void btn_adminOffice_Click(object sender, EventArgs e)
        {
            Frm_AdminOfficeView fadminView = new Frm_AdminOfficeView();
            fadminView.ShowDialog();
        }

        private void btn_landStay_Click(object sender, EventArgs e)
        {
            Frm_LandStayView flandView = new Frm_LandStayView();
            flandView.ShowDialog();
        }

        private void btn_socialMedia_Click(object sender, EventArgs e)
        {
            Frm_SocialMediaExport fsocialExport = new Frm_SocialMediaExport();
            fsocialExport.ShowDialog();
        }

        private void btn_videoTutorials_Click(object sender, EventArgs e)
        {
            Frm_VideoTutorialsView fvideoView = new Frm_VideoTutorialsView();
            fvideoView.ShowDialog();
        }
    }
}
