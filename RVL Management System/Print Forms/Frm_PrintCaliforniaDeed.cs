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
using MetroFramework;

namespace RVL_Management_System.Forms
{
    public partial class Frm_PrintCaliforniaDeed : MetroForm
    {
        public Frm_PrintCaliforniaDeed()
        {
            InitializeComponent();
        }

        private void Frm_PrintCaliforniaDeed_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
