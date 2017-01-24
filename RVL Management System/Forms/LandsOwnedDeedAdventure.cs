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
    public partial class LandsOwnedDeedAdventure : MetroForm
    {
        public static string apn = "";
        public static string county = "";
        public static string originalPrice = "";
        public static string marketPrice = "";
        public static string statusOfTheLand = "";
        public static string typeOfSale = "";
        public static string downPaymentMade = "";
        public static string monthlyPaymentMade = "";
        public static string paymentPaidSoFar = "";
        public static string amountClosed = "";

        public LandsOwnedDeedAdventure()
        {
            InitializeComponent();
        }

        private void LandsOwnedDeedAdventure_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            apn = txt_apn.Text;
            county = txt_county.Text;
            originalPrice = txt_origPrice.Text;
            marketPrice = txt_marketPrice.Text;
            statusOfTheLand = cBoxStatus.Text;
            typeOfSale = cBoxTypeOfSale.Text;
            downPaymentMade = txt_downPaymentMade.Text;
            monthlyPaymentMade = txt_monthlyPaymentMade.Text;
            paymentPaidSoFar = txt_paymentPaidSoFar.Text;
            amountClosed = txt_amountClosed.Text;
            Class.Cls_cmd.deedAdventureAdd();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            LandsOwnedDeedAdventureView fview = new LandsOwnedDeedAdventureView();
            fview.Show();
        }
    }
}
