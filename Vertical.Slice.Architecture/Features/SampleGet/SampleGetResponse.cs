using System.Text.Json.Serialization;

namespace Vertical.Slice.Architecture.Features.SampleGet
{
    public class SampleGetResponse
    {
        [JsonPropertyName("queryParam1")]
        public string QueryParam1 { get; set; }

        [JsonPropertyName("queryParam2")]
        public string QueryParam2 { get; set; }

        [JsonPropertyName("routeParam1")]
        public string RouteParam1 { get; set; }

        [JsonPropertyName("routeParam2")]
        public string RouteParam2 { get; set; }
    }
}
