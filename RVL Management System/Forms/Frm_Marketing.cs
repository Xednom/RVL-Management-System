using System;
using RVL_Management_System.Panel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using MetroFramework.Forms;

namespace RVL_Management_System
{
    public partial class Frm_LeadGeneration : PnlSlider
    {
        public Frm_LeadGeneration(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void Frm_LeadGeneration_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
        
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
        
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            swipe(false);
        }
    }
}
