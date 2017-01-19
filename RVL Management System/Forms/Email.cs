using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MetroFramework.Forms;
using System.Net.Mime;

namespace RVL_Management_System.Forms
{
    public partial class Email : MetroForm
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Frm_Email_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string file = txt_attachments.Text;
            MailMessage mail = new MailMessage(txt_email.Text, txt_to.Text, txt_subject.Text, txt_content.Text);
            Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
            mail.Attachments.Add(data);
            SmtpClient client = new SmtpClient(txt_smtp.Text);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(txt_email.Text, txt_pw.Text);
            client.Port = 587;
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Email Sent!", "Sent Successfully");
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_attachments.Text = openFileDialog1.FileName;
            }
        }
    }
}
