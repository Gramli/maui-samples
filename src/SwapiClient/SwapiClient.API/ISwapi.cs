using SwapiClient.API.DTO;

namespace SwapiClient.API
{
    public interface ISwapi
    {
        Task<PersonDto> GetPerson(int id);
        Task<StarshipDto> GetStarship(int id);
        Task<IEnumerable<PersonDto>> FetchPersons();
        Task<IEnumerable<StarshipDto>> FetchStarships();
    }
}
