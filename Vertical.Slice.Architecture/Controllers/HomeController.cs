using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Vertical.Slice.Architecture.Features.SampleGet;

namespace Vertical.Slice.Architecture.Controllers
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public HomeController(IMediator mediator, IMapper mapper)
        {
            this._mediator = mediator;
            this._mapper = mapper;
        }

        [HttpGet("sampleGet/{routeParam1}/SomeResource/{routeParam2}")]
        [ProducesResponseType(typeof(ResponseBase<SampleGetResponse>), 200)]
        public async Task<ActionResult<ResponseBase<SampleGetResponse>>> SampleGetAsync([FromRoute(Name = "routeParam1")] string routeParam1, [FromRoute(Name = "routeParam2")] string routeParam2, [FromQuery(Name = "queryParam1")] string queryParam1, [FromQuery(Name = "queryParam2")] string queryParam2)
        {
            var request = new SampleGetRequest()
            {
                QueryParam1 = queryParam1,
                QueryParam2 = queryParam2,
                RouteParam1 = routeParam1,
                RouteParam2 = routeParam2
            };

            await new SampleGetRequestValidator().ValidateAndThrowAsync(request);

            var mapped = this._mapper.Map<SampleGetQuery>(request);

            var response = await this._mediator.Send(mapped);

            return this.Ok(response);
        }
    }
}
