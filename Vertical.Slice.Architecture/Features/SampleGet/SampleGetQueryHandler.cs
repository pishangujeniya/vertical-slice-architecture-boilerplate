using System.Net;
using System.Text.Json;
using MediatR;

namespace Vertical.Slice.Architecture.Features.SampleGet
{
    public class SampleGetQueryHandler : IRequestHandler<SampleGetQuery, ResponseBase<SampleGetResponse>>
    {
        private readonly ILogger<SampleGetQueryHandler> _logger;

        public SampleGetQueryHandler(ILogger<SampleGetQueryHandler> logger)
        {
            this._logger = logger;
        }

        public async Task<ResponseBase<SampleGetResponse>> Handle(SampleGetQuery request, CancellationToken cancellationToken)
        {
            this._logger.LogInformation($"{nameof(SampleGetQueryHandler)} - Request - {nameof(SampleGetQuery)}:{JsonSerializer.Serialize(request)}");
            var r = new ResponseBase<SampleGetResponse>();
            r.Data = new SampleGetResponse()
            {
                QueryParam1 = request.QueryParam1,
                QueryParam2 = request.QueryParam2,
                RouteParam1 = request.RouteParam1,
                RouteParam2 = request.RouteParam2
            };
            r.StatusCode = HttpStatusCode.OK;

            this._logger.LogInformation($"{nameof(SampleGetQueryHandler)} - Response - {nameof(SampleGetQuery)}:{JsonSerializer.Serialize(request)}");
            return r;
        }
    }
}
