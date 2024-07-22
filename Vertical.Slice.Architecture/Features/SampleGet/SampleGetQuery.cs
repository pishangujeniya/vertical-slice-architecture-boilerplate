using MediatR;

namespace Vertical.Slice.Architecture.Features.SampleGet
{
    public class SampleGetQuery : IRequest<ResponseBase<SampleGetResponse>>
    {
        public string QueryParam1 { get; set; }

        public string QueryParam2 { get; set; }

        public string RouteParam1 { get; set; }

        public string RouteParam2 { get; set; }
    }
}
