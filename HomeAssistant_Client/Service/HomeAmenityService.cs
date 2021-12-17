using HomeAssistant_Client.Service.IService;
using Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HomeAssistant_Client.Service
{
    public class HomeAmenityService : IHomeAmenityService
    {
        private readonly HttpClient _client;

        public HomeAmenityService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<HomeAmenityDTO>> GetAmenityList()
        {
            // Get it from api. name is api[controller] which amenitycontroller
            var response = await _client.GetAsync($"api/amenity");
            var content = await response.Content.ReadAsStringAsync();
            var apartaments = JsonConvert.DeserializeObject<IEnumerable<HomeAmenityDTO>>(content);
            return apartaments;

        }
    }
}
