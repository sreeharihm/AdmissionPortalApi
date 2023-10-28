using AdmissionPortal.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.Application.Interface
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
