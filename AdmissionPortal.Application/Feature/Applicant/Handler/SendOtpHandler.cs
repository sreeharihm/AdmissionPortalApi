using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Application.Interface;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class SendOtpHandler : IRequestHandler<SendOtpCommand, bool>
    {
        private readonly IApplicantRepository _applicationRepository;
        private readonly IEmailSender _emailSender;
        private readonly ISMSSender _smsSender;
        public SendOtpHandler(IApplicantRepository applicationRepository, IEmailSender emailSender, ISMSSender smsSender)
        {
            _applicationRepository = applicationRepository;
            _emailSender = emailSender;
            _smsSender = smsSender;
        }

        public async Task<bool> Handle(SendOtpCommand request, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(request.PrimaryEmailId ))
            {
                string emailOtp = await _applicationRepository.GetEmailOtp(request.UserId);
                if (emailOtp != null)
                {                   
                    var message = new Message(request.PrimaryEmailId, "Secure OTP", "Your OTP is"+emailOtp);
                    _emailSender.SendEmail(message);
                    return true;
                }

            }
            else if(!string.IsNullOrEmpty(request.PrimaryMobileNo))
            {
               // string mobileOtp = await _applicationRepository.GetMobileOtp(request.UserId);
                _smsSender.SendSmsAsync();

            }
            return false;
        }

    }
}
