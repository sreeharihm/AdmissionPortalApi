using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.Application.Helpers
{
    public  class EmailSenderHelper
    {
        public async Task SendWelcomeEmailAsync(string emailId,string subject, string data)
        {
            //StreamReader str = new StreamReader(FilePath);
            //string MailText = str.ReadToEnd();
            //str.Close();
            //MailText = MailText.Replace("[username]", request.UserName).Replace("[email]", request.ToEmail);
            //var email = new MimeMessage();
            //email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            //email.To.Add(emailId);
            //email.Subject = $"Welcome emailId";
            //var builder = new BodyBuilder();
            //builder.HtmlBody = MailText;
            //email.Body = builder.ToMessageBody();
            //using var smtp = new SmtpClient();
            //smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            //smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            //await smtp.SendAsync(email);
            //smtp.Disconnect(true);
        }
    }
}
