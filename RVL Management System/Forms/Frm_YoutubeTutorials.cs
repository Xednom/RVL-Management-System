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
    public partial class Frm_YoutubeTutorials : MetroForm
    {
        public static string process = "";
        public static string link = "";

        public Frm_YoutubeTutorials()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txt_process.Text = null;
            txt_youtube.Text = null;
        }

        private void Frm_YoutubeTutorials_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            lock (this)
            {
                if (MetroMessageBox.Show(this, "Do you want to save these informations?", "RVL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    process = txt_process.Text;
                    link = txt_youtube.Text;
                    Class.Cls_cmd.youtubeLinkAdd();
                    clear();
                }
                else
                {
                    //IF NO
                    //TODO:NOTHING
                }
            }
        }
    }
}
