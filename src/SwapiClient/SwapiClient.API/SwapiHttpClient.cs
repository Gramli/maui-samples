using Newtonsoft.Json;

namespace SwapiClient.API
{
    internal class SwapiHttpClient : ISwapiHttpClient
    {
        private readonly HttpClient _httpClient;
        public SwapiHttpClient()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http swapi.dev/api"),
            };
        }

        public async Task<T> Get<T>(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(content)) 
            { 
                return default(T); 
            }

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}