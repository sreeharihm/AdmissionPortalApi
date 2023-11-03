﻿using AdmissionPortal.Application.Feature.Login.Commands;
using AdmissionPortal.Application.Feature.Registration.Commands;
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
        public async Task<IActionResult> ForgetPassword([FromBody] ForgetPasswordCommand model)
        {
            return Ok(await _mediator.Send(model));
        }
        // POST api/<LoginController>
        [HttpPost]
        [Route("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] PasswordResetCommand model)
        {
            return Ok(await _mediator.Send(model));
        }

        [HttpPost]
        [Route("ActivatePassword")]
        public async Task<IActionResult> ActivatePassword([FromBody] PasswordActivateCommand model)
        {
            return Ok(await _mediator.Send(model));
        }

    }
}
