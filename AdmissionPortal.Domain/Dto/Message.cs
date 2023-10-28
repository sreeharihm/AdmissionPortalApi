using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.Domain.Dto
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public Message(string to, string subject, string content)
        {
            To = new List<MailboxAddress>
            {
                new MailboxAddress("sender", to)
            };
            Subject = subject;
            Content = content;
        }
    }
}
