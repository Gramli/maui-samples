using Newtonsoft.Json;

namespace SwapiClient.API.DTO
{
    public record PersonDto : BaseDto
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty(PropertyName = "eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "hair_color")]
        public string HairColor { get; set; }

        [JsonProperty]
        public string Height { get; set; }

        [JsonProperty]
        public string Mass { get; set; }

        [JsonProperty(PropertyName = "skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty]
        public string Homeworld { get; set; }

        [JsonProperty]
        public ICollection<string> FilmsUrl { get; set; }

        [JsonProperty]
        public ICollection<string> SpeciesUrl { get; set; }

        [JsonProperty]
        public ICollection<string> StarshipsUrl { get; set; }

        [JsonProperty]
        public ICollection<string> VehiclesUrl { get; set; }
    }
}
