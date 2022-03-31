namespace SwapiClient.API
{
    public interface ISwapiHttpClient
    {
        Task<T> Get<T>(string url);
    }
}
