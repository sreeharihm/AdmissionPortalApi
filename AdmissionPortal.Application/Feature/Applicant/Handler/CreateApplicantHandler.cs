using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateApplicantHandler : IRequestHandler<CreateApplicantCommand, ApplicantDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public CreateApplicantHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantDto> Handle(CreateApplicantCommand request, CancellationToken cancellationToken)
        {
            var applicationNumber = "APP" + Convert.ToString(request.AyStartYear) + Convert.ToString(request.TermId) + "0000";
            var applicantMaster = new TblAdmApplicantApplicationMaster();
            applicantMaster.ApplicationNumber = applicationNumber;
            applicantMaster.AdmissionTypeRecId = request.AdmissionTypeRecId;
            applicantMaster.DegreeTypeRecId = request.DegreeTypeRecId;
            applicantMaster.AcademicYearRecId = request.AcademicYearRecId;
            applicantMaster.TermId = request.TermId;
            applicantMaster.UserId= request.UserId;
            Random generator = new Random();
            applicantMaster.EmailOtp = generator.Next(0, 1000000).ToString("D6");
            applicantMaster.MobileOtp = generator.Next(0, 1000000).ToString("D6");
            applicantMaster.MobileVerified = false;
            applicantMaster.EmailVerified = false;
            return await _applicationRepository.CreateApplicationId(applicantMaster); ;
        }
    }
}
