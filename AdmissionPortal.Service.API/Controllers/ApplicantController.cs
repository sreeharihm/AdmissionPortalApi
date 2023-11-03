using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Application.Feature.Course.Queries;
using AdmissionPortal.Application.Feature.MasterData.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionPortal.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ApplicantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/CreateApplication")]
        public async Task<IActionResult> GetInstructions([FromBody] CreateApplicantCommand applicantCommand, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(applicantCommand, cancellationToken));
        }

        [HttpGet]
        [Route("/Instructions")]
        public async Task<IActionResult> GetInstructions(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetInstructionsQuery(), cancellationToken));
        }

        [HttpGet]
        [Route("/PersonalDetails")]
        public async Task<IActionResult> GetPersonalDetails(GetApplicantPersonalDetailsQuery personalDetailsQuery, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(personalDetailsQuery, cancellationToken));
        }

        [HttpPost]
        [Route("/PersonalDetails")]
        public async Task<IActionResult> CreatePersonalDetails([FromBody] CreateApplicantPersonalDetailsCommand personalDetailsCommand, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(personalDetailsCommand, cancellationToken));
        }

        [HttpGet]
        [Route("/ProgramPreferences")]
        public async Task<IActionResult> GetProgramPreferences(GetProgramPreferencesQuery programPreferenceQuery, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(programPreferenceQuery, cancellationToken));
        }

        [HttpPost]
        [Route("/ProgramPreferences")]
        public async Task<IActionResult> CreatePreferenceDetails([FromBody] List<CreateApplicantPerferenceCommand> perferenceCommand, CancellationToken cancellationToken)
        {
            foreach (var command in perferenceCommand)
            {
                await _mediator.Send(command, cancellationToken);
            }
            return Ok();
        }

        [HttpGet]
        [Route("/AdditionalDetails")]
        public async Task<IActionResult> GetAdditionalDetails(GetAdditionalDetailsQuery additionalDetailsQuery, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(additionalDetailsQuery, cancellationToken));
        }

        [HttpPost]
        [Route("/AdditionalDetails")]
        public async Task<IActionResult> CreateAdditionalDetails([FromBody] List<CreateAdditionalDetailsCommand> detailsCommand, CancellationToken cancellationToken)
        {
            foreach (var command in detailsCommand)
            {
                await _mediator.Send(command, cancellationToken);
            }
            return Ok();
        }
        [HttpGet]
        [Route("/AdmissionCriteria")]
        public async Task<IActionResult> GetAdmissionCriteria(GetAdditionalDetailsQuery additionalDetailsQuery, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(additionalDetailsQuery, cancellationToken));
        }

        [HttpPost]
        [Route("/AdmissionCriteria")]
        public async Task<IActionResult> CreateAdmissionCriteria([FromBody] List<CreateApplicantCriteriaCommand> detailsCommand, CancellationToken cancellationToken)
        {
            foreach (var command in detailsCommand)
            {
                await _mediator.Send(command, cancellationToken);
            }
            return Ok();
        }
    }
}
