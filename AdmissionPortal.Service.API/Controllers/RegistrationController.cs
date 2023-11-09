using AdmissionPortal.Application.Feature.MasterData.Queries;
using AdmissionPortal.Application.Feature.Registration.Commands;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionPortal.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<CreateApplicationUserCommand> _createvalidator;
        private readonly IValidator<UpdateApplicationUserCommand> _updatevalidator;
        public ApplicationUserController(IMediator mediator, IValidator<CreateApplicationUserCommand> createvalidator, IValidator<UpdateApplicationUserCommand> updatevalidator)
        {
            _mediator = mediator;
            _createvalidator = createvalidator;
            _updatevalidator = updatevalidator;
        }

        [HttpPost]
        [Route("/Registration")]
        public async Task<IActionResult> AddApplicationUser([FromBody] CreateApplicationUserCommand model)
        {
            var validation = await _createvalidator.ValidateAsync(model);
            if (!validation.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest,validation.Errors);
            }
            return Ok(await _mediator.Send(model));
        }

        [HttpPost]
        [Route("/UpdateRegistration")]
        public async Task<IActionResult> UpdateApplicationUser([FromBody] UpdateApplicationUserCommand model)
        {
            var validation = await _updatevalidator.ValidateAsync(model);
            if (!validation.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validation.Errors);
            }
            return Ok(await _mediator.Send(model));
        }
    }
}