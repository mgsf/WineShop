using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WineWeb.Models;

namespace WineWeb.Services
{
    public class WineDataService :IWineDataService
    {
        private readonly HttpClient _httpClient;

        public WineDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Wine>> GetAllWines()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Wine>>
                    (await _httpClient.GetStreamAsync($"api/Wine"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
