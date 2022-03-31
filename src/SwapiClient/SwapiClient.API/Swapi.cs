using SwapiClient.API.DTO;

namespace SwapiClient.API
{
    internal class Swapi : ISwapi
    {
        private readonly SwapiHttpClient _swapiHttpClient;
        private const string PEOPLE_URL = "people";
        private const string PEOPLE_STARSHIP_URL = "starships";

        public Swapi(SwapiHttpClient swapiHttpClient)
        {
            _swapiHttpClient = swapiHttpClient;
        }

        public Task<PersonDto> GetPerson(int id)
        {
            var url = $"{PEOPLE_URL}/{id}";
            return _swapiHttpClient.Get<PersonDto>(url);
        }

        public Task<StarshipDto> GetStarship(int id)
        {
            var url = $"{PEOPLE_STARSHIP_URL}/{id}";
            return _swapiHttpClient.Get<StarshipDto>(url);
        }

        public Task<IEnumerable<PersonDto>> FetchPersons()
        {
            var url = $"{PEOPLE_URL}/";
            return _swapiHttpClient.Get<IEnumerable<PersonDto>>(url);
        }

        public Task<IEnumerable<StarshipDto>> FetchStarships()
        {
            var url = $"{PEOPLE_STARSHIP_URL}/";
            return _swapiHttpClient.Get<IEnumerable<StarshipDto>>(url);
        }
    }
}
