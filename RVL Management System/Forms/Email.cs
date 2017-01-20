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
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;



namespace RVL_Management_System.Forms
{
    public partial class Email : MetroForm
    {

        const string clientID = "419579761857-ins0hvsjj2u4t6bkjfnp780rbqvr4pmm.apps.googleusercontent.com";
        const string clientSecret = "1u3UL04y74WehY7s05Sgqtu4";
        const string authorizationEndpoint = "https://www.googleapis.com/oauth2/v1/certs";
        const string tokenEndpoint = "https://accounts.google.com/o/oauth2/token";

        //public async void Main(string[] args)
        //{
        //    var certificate = new X509Certificate2(@"C:\Users\monde\Downloads\client_id", "password", X509KeyStorageFlags.Exportable);
        //    var credential = new ServiceAccountCredential(new ServiceAccountCredential
        //        .Initializer("your-developer-id@developer.gserviceaccount.com")
        //    {
        //        // Note: other scopes can be found here: https://developers.google.com/gmail/api/auth/scopes
        //        Scopes = new[] { "https://mail.google.com/" },
        //        User = "xednom@gmail.com"
        //    }.FromCertificate(certificate));

        //    // Note: result will be true if the access token was received successfully
        //    bool result = await credential.RequestAccessTokenAsync(CancellationToken.None);

        //    if (!result)
        //    {
        //        MetroMessageBox.Show(this, "Error fetching access token!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    var message = new MimeMessage();
        //    message.From.Add(new MailboxAddress("Richmond", "xednom@gmail.com"));
        //    message.To.Add(new MailboxAddress("Piso", "monde.lacanlalay@gmail.com"));
        //    message.Subject = "This is a test message";

        //    var builder = new BodyBuilder();
        //    builder.TextBody = "This is the body of the message.";
        //    builder.Attachments.Add(@"E:\TeamBugels files\14485103_866861653448425_38638487722515396_n");

        //    message.Body = builder.ToMessageBody();

        //    using (var client = new SmtpClient())
        //    {
        //        client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

        //        // use the access token as the password string
        //        client.Authenticate("xednom@gmail.com", credential.Token.AccessToken);

        //        client.Send(message);

        //        client.Disconnect(true);
        //    }
        //}

    public Email()
        {
            InitializeComponent();
        }

        private void Frm_Email_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Richmond B. Lacanlalay", txt_email.Text));
            message.To.Add(new MailboxAddress("Piso kins", txt_to.Text));
            message.Subject = txt_subject.Text;

            message.Body = new TextPart("plain")
            {
                Text = txt_content.Text
            };

            using (var client = new SmtpClient())
            {
                client.Connect(txt_smtp.Text, 587);


                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(txt_email.Text, txt_pw.Text);

                client.Send(message);
                client.Disconnect(true);

                MetroMessageBox.Show(this, "Email Sent!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //string file = txt_attachments.Text;
            //MimeMessage mail = new MimeMessage(txt_email.Text, txt_to.Text, txt_subject.Text, txt_content.Text);
            //MimePart data = new MimePart(file, MediaTypeNames.Application.Octet);
            //Multipart multipart = new Multipart();
            //multipart.Add(data);
            //SmtpClient client = new SmtpClient(txt_smtp.text);
            //client. = false;
            //client.credentials = new networkcredential(txt_email.text, txt_pw.text);
            //client.port = 587;
            //client.enablessl = true;
            //client.send(mail);

            //MessageBox.Show("Email Sent!", "Sent Successfully");
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
