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

namespace RVL_Management_System.Forms
{
    public partial class Frm_Email : MetroForm
    {
        public Frm_Email()
        {
            InitializeComponent();
        }
        //sending an email with attachments
        public void email_send()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("your mail@gmail.com");
            mail.To.Add("to_mail@gmail.com");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("your mail@gmail.com", "your password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

        private void Frm_Email_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(txt_email.Text, txt_to.Text, txt_subject.Text, txt_content.Text);
            SmtpClient client = new SmtpClient(txt_smtp.Text);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(txt_email.Text, txt_pw.Text);
            client.Port = 587;
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Email Sent!", "Sent Successfully");
        }
    }
}
