using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Vertical.Slice.Architecture.Features.SampleGet
{
    public class SampleGetRequest
    {
        [FromQuery(Name = "queryParam1")]
        [JsonPropertyName("queryParam1")]
        [Required]
        public string QueryParam1 { get; set; }

        [FromQuery(Name = "queryParam2")]
        [JsonPropertyName("queryParam2")]
        [Required]
        public string QueryParam2 { get; set; }

        [FromRoute(Name = "routeParam1")]
        [JsonPropertyName("routeParam1")]
        [Required]
        public string RouteParam1 { get; set; }

        [FromRoute(Name = "routeParam2")]
        [JsonPropertyName("routeParam2")]
        [Required]
        public string RouteParam2 { get; set; }
    }
}
