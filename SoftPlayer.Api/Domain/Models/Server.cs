using Newtonsoft.Json;

namespace SoftPlayer.Api.Models
{
    public class Server
    {
        [JsonProperty("git_url")]
        public string Url { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("html_url")]
        public string Repository { get; set; }
    }
}