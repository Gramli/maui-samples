using Newtonsoft.Json;
using System;

namespace SwapiClient.DTO
{
    internal record BaseDto
    {
        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public DateTime Created { get; set; }

        [JsonProperty]
        public DateTime Edited { get; set; }
    }
}
