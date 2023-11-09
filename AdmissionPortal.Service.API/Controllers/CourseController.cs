using AdmissionPortal.Application.Feature.Course.Queries;
using AdmissionPortal.Application.Feature.MasterData.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AdmissionPortal.Service.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCourse(CancellationToken cancellationToken)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            return Ok(await _mediator.Send(new GetCourseQuery()));
        }

        [HttpGet]
        [Route("/IsCourseAvailable")]
        public async Task<IActionResult> CheckAvailability(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetRegistrationAvailability()));
        }
    }
}
