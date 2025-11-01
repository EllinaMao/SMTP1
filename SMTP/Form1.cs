using Google.Apis.Auth.OAuth2;
using MailKit.Security;
using MimeKit;
using System.Net.Mail;
using System.Windows.Forms;

namespace SMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private async void Send_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(textFrom.Text, textFrom.Text)); //1 param name,  2 email 
                message.To.Add(new MailboxAddress(textTo.Text, textTo.Text));
                message.Subject = text_theme.Text;

                var body = new Multipart("mixed");
                body.Add(new TextPart("plain")
                {
                    Text = textMessage.Text,
                    ContentTransferEncoding = ContentEncoding.QuotedPrintable,
                    ContentType = { Charset = "UTF-8" }
                });

                if (!string.IsNullOrWhiteSpace(text_path.Text))
                {
                    var attachment = new MimePart()
                    {
                        Content = new MimeContent(System.IO.File.OpenRead(text_path.Text)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = System.IO.Path.GetFileName(text_path.Text)
                    };
                    body.Add(attachment);
                }
                message.Body = body;
                message.ReplyTo.Add(new MailboxAddress("Support", "xotaoshi@gmail.com"));

                //string accessToken = await GetGmailAccessTokenAsync();
                // Відправка листа через SMTP
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                    var oauth2 = new MailKit.Security.SaslMechanismOAuth2(textFrom.Text, accessToken);
                    await client.AuthenticateAsync(oauth2);

                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                MessageBox.Show("Письмо отправлено через OAuth 2.0!");
            }
                        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_file_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                text_path.Text = openFileDialog1.FileName;
        }
    }
}
