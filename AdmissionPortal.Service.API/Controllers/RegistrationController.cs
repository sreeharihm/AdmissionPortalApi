using AdmissionPortal.Application.Feature.Registration.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionPortal.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ApplicationUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/Registration")]
        public async Task<IActionResult> AddApplicationUser(CreateApplicationUserCommand userDetails)
        {
            return Ok(await _mediator.Send(userDetails));
        }
    }
}