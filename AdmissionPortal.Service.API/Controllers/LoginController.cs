using AdmissionPortal.Application.Feature.Login.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdmissionPortal.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoginController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCommand model)
        {
            bool isSucess = await _mediator.Send(model);
            if (isSucess)
                return Ok();
            return Unauthorized();
        }


        // POST api/<LoginController>
        [HttpPost]
        [Route("ForgetPassword")]
        public void ForgetPassword([FromBody] string value)
        {
        }
        // POST api/<LoginController>
        [HttpPost]
        [Route("ResetPassword")]
        public void ResetPassword([FromBody] string value)
        {
        }

    }
}
