using AdmissionPortal.Application.Feature.MasterData.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionPortal.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MasterDataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMasterData(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetMasterDataQuery
            {
                FieldName = "Test"
            }, cancellationToken));
        }

    }
}
