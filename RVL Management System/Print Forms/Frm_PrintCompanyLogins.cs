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

namespace RVL_Management_System.Print_Forms
{
    public partial class Frm_PrintCompanyLogins : MetroForm
    {
        public Frm_PrintCompanyLogins()
        {
            InitializeComponent();
        }

        private void Frm_PrintCompanyLogins_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
