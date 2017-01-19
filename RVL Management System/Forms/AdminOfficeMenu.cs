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
    public partial class AdminOfficeMenu : MetroForm
    {
        public AdminOfficeMenu()
        {
            InitializeComponent();
        }

        private void Frm_AdminOfficeMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AdminOfficeAdd fofficeadd = new AdminOfficeAdd();
            fofficeadd.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            AdminOfficeView fadminView = new AdminOfficeView();
            fadminView.ShowDialog();
        }
    }
}
