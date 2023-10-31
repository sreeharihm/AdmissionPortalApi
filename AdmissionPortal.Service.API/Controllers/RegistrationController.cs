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
        private readonly IValidator<CreateApplicationUserCommand> _validator;
        public ApplicationUserController(IMediator mediator, IValidator<CreateApplicationUserCommand> validator)
        {
            _mediator = mediator;
            _validator = validator;
        }

        [HttpPost]
        [Route("/Registration")]
        public async Task<IActionResult> AddApplicationUser([FromBody] CreateApplicationUserCommand model)
        {
            var validation = await _validator.ValidateAsync(model);
            if (!validation.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest,validation.Errors);
            }
            return Ok(await _mediator.Send(model));
        }        
    }
}