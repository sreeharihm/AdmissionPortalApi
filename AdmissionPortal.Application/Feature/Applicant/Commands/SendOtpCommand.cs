using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class SendOtpCommand:IRequest<bool>
    {
        public int UserId { get; set; }
        public string PrimaryEmailId { get; set; }
        public string PrimaryMobileNo { get; set; }
    }

}
