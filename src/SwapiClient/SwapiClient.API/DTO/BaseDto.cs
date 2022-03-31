using Newtonsoft.Json;

namespace SwapiClient.API.DTO
{
    public record BaseDto
    {
        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public DateTime Created { get; set; }

        [JsonProperty]
        public DateTime Edited { get; set; }
    }
}
