using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.ThirdPartyService.Interface
{
    public interface ISender
    {
        Task SendMessageAsync(string senderType,string senderId, string subject, string htmlMessage);
    }
}
