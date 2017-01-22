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
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

namespace RVL_Management_System.Forms
{
    public partial class Email : MetroForm
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        public Email()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void email_send()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(txt_smtp.Text);
            mail.From = new MailAddress(txt_email.Text, txt_nameFrom.Text);
            mail.To.Add(txt_to.Text);
            mail.Subject = txt_subject.Text;
            mail.Body = txt_content.Text;

            Attachment attachment;
            attachment = new Attachment(txt_attachments.Text);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(txt_email.Text, txt_pw.Text);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            MetroMessageBox.Show(this, "Email Sent!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void loadEmail()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Email";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gEmail = reader.GetString(reader.GetOrdinal("Email")).ToString();
                string gAppPass = reader.GetString(reader.GetOrdinal("AppPassword")).ToString();
                string gSenderName = reader.GetString(reader.GetOrdinal("SenderName")).ToString();
                txt_email.Text = gEmail;
                txt_pw.Text = gAppPass;
                txt_nameFrom.Text = gSenderName;
            }
            conn.Close();
        }

        private void Frm_Email_Load(object sender, EventArgs e)
        {
            loadEmail();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            email_send();

            //var message = new MimeMessage();
            //message.From.Add(new MailboxAddress("Richmond B. Lacanlalay", txt_email.Text));
            //message.To.Add(new MailboxAddress("Raymond Negro", txt_to.Text));
            //message.Subject = txt_subject.Text;

            //message.Body = new TextPart("plain")
            //{
            //    Text = txt_content.Text
            //};

            //using (var client = new SmtpClient())
            //{
            //    client.Connect(txt_smtp.Text, 587);
            //    var attachments = txt_attachments.Text;

            //    // Note: since we don't have an OAuth2 token, disable
            //    // the XOAUTH2 authentication mechanism.
            //    client.AuthenticationMechanisms.Remove("XOAUTH2");

            //    // Note: only needed if the SMTP server requires authentication
            //    client.Authenticate(txt_email.Text, txt_pw.Text);
            //    client.Send(message);
            //    client.Disconnect(true);

            //    MetroMessageBox.Show(this, "Email Sent!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_attachments.Text = openFileDialog1.FileName;
            }
        }

        private void btn_emailCreden_Click(object sender, EventArgs e)
        {
            EmailCredential eCredential = new EmailCredential();
            eCredential.ShowDialog();
        }
    }
}
