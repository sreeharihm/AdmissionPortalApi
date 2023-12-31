﻿using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class GetApplicantPersonalDetailsHandler : IRequestHandler<GetApplicantPersonalDetailsQuery, ApplicantPersonalDetailsDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public GetApplicantPersonalDetailsHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantPersonalDetailsDto> Handle(GetApplicantPersonalDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = await _applicationRepository.GetPersonalDetails(request.UserId);
            return result;
        }
    }
}
