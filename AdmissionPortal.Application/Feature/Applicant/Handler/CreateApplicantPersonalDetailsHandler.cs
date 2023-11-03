using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateApplicantPersonalDetailsHandler : IRequestHandler<CreateApplicantPersonalDetailsCommand, ApplicantDto>
    {
        private readonly IApplicantRepository _applicationRepository;

        public CreateApplicantPersonalDetailsHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<ApplicantDto> Handle(CreateApplicantPersonalDetailsCommand request, CancellationToken cancellationToken)
        {
            var applicantPersonalInformation = new TblAdmApplicantPersonalInformation();
            applicantPersonalInformation.UserId = request.UserId;
            applicantPersonalInformation.CountryId= request.NationalId;
            applicantPersonalInformation.FisrtNameEng = request.FirstNameEng;
            applicantPersonalInformation.SecondNameEng = request.LastNameEng;
            applicantPersonalInformation.FisrtNameLocal = request.FirstNameLocal;
            applicantPersonalInformation.SecondNameLocal = request.LastNameLocal;
            applicantPersonalInformation.ThirdNameEng = request.FatherNameEng;
            applicantPersonalInformation.ThirdNameLocal = request.FatherNameLocal;
            applicantPersonalInformation.FourthNameEng = request.GrandFatherNameEng;
            applicantPersonalInformation.FourthNameLocal = request.GrandFatherNameLocal;
            applicantPersonalInformation.ContactEmailAddress = request.PrimaryEmailId;
            applicantPersonalInformation.ContactHomeTelephoneNumber = request.PrimaryMobileNo;
            applicantPersonalInformation.Gender = request.Gender=="M"?1:2;
            applicantPersonalInformation.CountryId = request.CountryId;
            applicantPersonalInformation.IsMobileVerified = request.IsMobileVerified;
            applicantPersonalInformation.IsEmailVerified = request.IsEmailVerified;
            await Task.Delay(10);
            return new ApplicantDto();
        }
    }
}
