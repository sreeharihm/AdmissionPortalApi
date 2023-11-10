using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateApplicantEducationHandler : IRequestHandler<CreateApplicantEducationCommand, ApplicantDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public CreateApplicantEducationHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantDto> Handle(CreateApplicantEducationCommand request, CancellationToken cancellationToken)
        {
            var data = new TblAdmApplicantEducationalInformation
            {
                ApplicationRecId = request.ApplicationRecId,
                CertificateType = request.CertificateType,
                SchoolName = request.SchoolName,
                CountryRecId = request.CountryId,
                ProvinceName = request.ProvinceName,
                CityName = request.CityName,
                StudyCenterName = request.StudyCenterName,
                GraduationYear = request.GraducationYear,
                GradeType = request.GradeType,
                ExternalCode = request.ExternalCode,
                InsertedBy = request.UserId
            };
            await _applicationRepository.UpsertEducationDetials(data, request.UserId);
            var result = new ApplicantDto
            {
                ApplicationRecId = request.ApplicationRecId,
                Message = "Education Details updated successfully"
            };
            return result;
        }
    }
}
