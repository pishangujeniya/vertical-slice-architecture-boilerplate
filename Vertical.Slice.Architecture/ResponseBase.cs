using System.Net;
using System.Text.Json.Serialization;

namespace Vertical.Slice.Architecture
{
    public class ResponseBase<T> where T : class
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonPropertyName("statusCode")]
        public HttpStatusCode StatusCode { get; set; }

        [JsonPropertyName("errors")] public List<string> Errors { get; set; } = new List<string>();
    }
}
