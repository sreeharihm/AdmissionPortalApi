using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Application.Feature.Applicant.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionPortal.Service.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly int _userId;
        public ApplicantController(IMediator mediator)
        {
            _mediator = mediator;
            _userId= Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value);
        }

        [HttpPost]
        [Route("/CreateApplication")]
        public async Task<IActionResult> GetInstructions([FromBody] CreateApplicantCommand applicantCommand, CancellationToken cancellationToken)
        {
            applicantCommand.UserId = _userId;
            return Ok(await _mediator.Send(applicantCommand, cancellationToken));
        }

        [HttpGet]
        [Route("/Instructions")]
        public async Task<IActionResult> GetInstructions(CancellationToken cancellationToken)
        {
            var query = new GetInstructionsQuery();
            query.InstructionType = "Instructions";
            return Ok(await _mediator.Send(query, cancellationToken));
        }

        [HttpGet]
        [Route("/PersonalDetails")]
        public async Task<IActionResult> GetPersonalDetails(string ApplicationNumber, int ApplicationRecId, CancellationToken cancellationToken)
        {
            var personalDetailsQuery = new GetApplicantPersonalDetailsQuery
            {
                UserId = _userId,
                ApplicationNumber = ApplicationNumber,
                ApplicationRecId = ApplicationRecId
            };
            return Ok(await _mediator.Send(personalDetailsQuery, cancellationToken));
        }

        [HttpPost]
        [Route("/PersonalDetails")]
        public async Task<IActionResult> CreatePersonalDetails([FromBody] CreateApplicantPersonalDetailsCommand personalDetailsCommand, CancellationToken cancellationToken)
        {
            personalDetailsCommand.UserId = _userId;
            return Ok(await _mediator.Send(personalDetailsCommand, cancellationToken));
        }

        [HttpGet]
        [Route("/ProgramPreferences")]
        public async Task<IActionResult> GetProgramPreferences(string ApplicationNumber, int ApplicationRecId, CancellationToken cancellationToken)
        {
            var query = new GetProgramPreferencesQuery
            {
                ApplicationRecId = ApplicationRecId,
                ApplicationNumber = ApplicationNumber,
            };
            return Ok(await _mediator.Send(query, cancellationToken));
        }

        [HttpPost]
        [Route("/ProgramPreferences")]
        public async Task<IActionResult> CreatePreferenceDetails([FromBody] List<CreateApplicantPerferenceCommand> perferenceCommand, CancellationToken cancellationToken)
        {
            foreach (var command in perferenceCommand)
            {
                command.UserId = _userId;
                await _mediator.Send(command, cancellationToken);
            }
            return Ok();
        }

        [HttpGet]
        [Route("/AdditionalDetails")]
        public async Task<IActionResult> GetAdditionalDetails(string ApplicationNumber, int ApplicationRecId, CancellationToken cancellationToken)
        {
            var query = new GetAdditionalDetailsQuery
            {
                ApplicationRecId = ApplicationRecId,
                ApplicationNumber = ApplicationNumber,
            };
            return Ok(await _mediator.Send(query, cancellationToken));
        }

        [HttpPost]
        [Route("/AdditionalDetails")]
        public async Task<IActionResult> CreateAdditionalDetails([FromBody] List<CreateAdditionalDetailsCommand> detailsCommand, CancellationToken cancellationToken)
        {
            foreach (var command in detailsCommand)
            {
                command.UserId = _userId;
                await _mediator.Send(command, cancellationToken);
            }
            return Ok();
        }
        [HttpGet]
        [Route("/AdmissionCriteria")]
        public async Task<IActionResult> GetAdmissionCriteria(string ApplicationNumber, int ApplicationRecId, CancellationToken cancellationToken)
        {
            var query = new GetAdmissionCriteriaQuery
            {
                ApplicationRecId = ApplicationRecId,
                ApplicationNumber = ApplicationNumber,
            };
            return Ok(await _mediator.Send(query, cancellationToken));
        }

        [HttpPost]
        [Route("/AdmissionCriteria")]
        public async Task<IActionResult> CreateAdmissionCriteria([FromBody] List<CreateApplicantCriteriaCommand> detailsCommand, CancellationToken cancellationToken)
        {
            foreach (var command in detailsCommand)
            {
                command.UserId = _userId;
                await _mediator.Send(command, cancellationToken);
            }
            return Ok();
        }
        [HttpGet]
        [Route("/CheckList")]
        public async Task<IActionResult> GetApplicantCheckList(string ApplicationNumber, int ApplicationRecId, CancellationToken cancellationToken)
        {
            var query = new GetApplicantCheckListQuery
            {
                UserId = _userId,
                ApplicationRecId = ApplicationRecId,
                ApplicationNumber = ApplicationNumber,
            };
            query.UserId = _userId;
            return Ok(await _mediator.Send(query, cancellationToken));
        }

        [HttpPost]
        [Route("/CheckList")]
        public async Task<IActionResult> CreateApplicantCheckList([FromBody] List<CreateApplicantCheckListCommand> detailsCommand, CancellationToken cancellationToken)
        {
            foreach (var command in detailsCommand)
            {
                command.UserId = _userId;
                await _mediator.Send(command, cancellationToken);
            }
            return Ok();
        }

        [HttpGet]
        [Route("/DropDownDetails")]
        public async Task<IActionResult> GetEducationDetails(string ApplicationNumber, int ApplicationRecId, CancellationToken cancellationToken)
        {
            var query = new GetApplicantCheckListQuery
            {
                UserId = _userId,
                ApplicationRecId = ApplicationRecId,
                ApplicationNumber = ApplicationNumber,
            };
            return Ok(await _mediator.Send(query, cancellationToken));
        }
        [HttpPost]
        [Route("/EducationDetails")]
        public async Task<IActionResult> CreateApplicantEducationList([FromBody] List<CreateApplicantEducationCommand> detailsCommand, CancellationToken cancellationToken)
        {
            foreach (var command in detailsCommand)
            {
                command.UserId = _userId;
                await _mediator.Send(command, cancellationToken);
            }
            return Ok();
        }

        [HttpPost]
        [Route("/SendEmailOtp")]
        public async Task<IActionResult> SendEmailOtp([FromBody] CreateApplicantEducationCommand detailsCommand, CancellationToken cancellationToken)
        {
            detailsCommand.UserId = _userId;
            await _mediator.Send(detailsCommand, cancellationToken);
            return Ok();
        }

        [HttpPost]
        [Route("/VerifyEmailOtp")]
        public async Task<IActionResult> VerifyEmailOtp([FromBody] CreateApplicantEducationCommand detailsCommand, CancellationToken cancellationToken)
        {
            detailsCommand.UserId = _userId;
            await _mediator.Send(detailsCommand, cancellationToken);
            return Ok();
        }

        [HttpGet]
        [Route("/AddressDetails")]
        public async Task<IActionResult> GetAddressDetails(string ApplicationNumber, int ApplicationRecId, CancellationToken cancellationToken)
        {
            var query = new GetApplicantAddressQuery
            {
                ApplicationNumber = ApplicationNumber,
                ApplicationRecId = ApplicationRecId,
            };
            return Ok(await _mediator.Send(query, cancellationToken));
        }

        [HttpPost]
        [Route("/AddressDetails")]
        public async Task<IActionResult> CreateAddressDetails([FromBody] CreateAddressDetailsCommand addressQuery, CancellationToken cancellationToken)
        {
            addressQuery.UserId = _userId;
            return Ok(await _mediator.Send(addressQuery, cancellationToken));
        }

        [HttpGet]
        [Route("/Declaration")]
        public async Task<IActionResult> GetDeclaration(CancellationToken cancellationToken)
        {
            var query = new GetInstructionsQuery();
            query.InstructionType = "Declaration";
            return Ok(await _mediator.Send(query, cancellationToken));
        }
    }
}
