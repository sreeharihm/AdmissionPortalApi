using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateAddressDetialsHandler : IRequestHandler<CreateAddressDetailsCommand, ApplicantDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public CreateAddressDetialsHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantDto> Handle(CreateAddressDetailsCommand request, CancellationToken cancellationToken)
        {
            var result = new ApplicantDto();
            var model = new TblAdmApplicantPersonalInformation();
            model.ContactAddress = request.ContactAddress;
            model.ContactCityName = request.ContactCityName;
            model.ContactCountryId = request.ContactCountryId;
            model.ContactPobox = request.ContactPobox;
            model.ContactPostalCode = request.ContactPostalCode;
            model.ContactProvinceName = request.ContactProvinceName;
            model.ContactHomeTelephoneNumber = request.ContactHomeTelephoneNumber;
            model.PermanentAddress = request.PermanentAddress;
            model.PermanentCityName = request.PermanentCityName;
            model.PermanentCountryId = request.PermanentCountryId;
            model.PermanentHomeTelephoneNumber = request.PermanentHomeTelephoneNumber;
            model.PermanentPobox = request.PermanentPobox;
            model.PermanentPostalCode = request.PermanentPostalCode;
            model.PermanentProvinceName = request.PermanentProvinceName;
            await _applicationRepository.UpSertAddressDetails(request.UserId, model);
            return result;
        }
    }
}
