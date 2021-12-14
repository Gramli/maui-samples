using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwapiClient.DTO
{
    internal record StarshipDto : BaseDto
    {

        [JsonProperty]
        public string Name { get; set; }

        public string Model { get; set; }

        [JsonProperty(PropertyName = "starship_class")]
        public string StarshipClass { get; set; }

        public string Manufacturer { get; set; }

        [JsonProperty(PropertyName = "cost_in_credits")]
        public string CostInCredits { get; set; }

        [JsonProperty]
        public string Length { get; set; }

        [JsonProperty]
        public string Crew { get; set; }

        [JsonProperty]
        public string Passengers { get; set; }

        [JsonProperty(PropertyName = "max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }

        [JsonProperty(PropertyName = "hyperdrive_rating")]
        public string HyperdriveRating { get; set; }

        [JsonProperty(PropertyName = "MGLT")]
        public string MegaLights { get; set; }

        [JsonProperty(PropertyName = "cargo_capacity")]
        public string CargoCapacity { get; set; }

        [JsonProperty]
        public string Consumables { get; set; }

        [JsonProperty]
        public ICollection<string> FilmsUrl { get; set; }

        [JsonProperty]
        public ICollection<string> PilotsUrl { get; set; }
    }
}
