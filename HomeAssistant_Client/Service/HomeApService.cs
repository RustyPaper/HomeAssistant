using HomeAssistant_Client.Service.IService;
using Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HomeAssistant_Client.Service
{
    public class HomeApService : IHomeApService
    {


        //use http client and json helpers like 


        private readonly HttpClient _client;

        public HomeApService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<HomeApDTO>> GetHomeAps(string checkInDate, string checkOutDate)
        {
                 
            var response = await _client.GetAsync($"api/homeapartament?checkIn={checkInDate}&checkOut={checkInDate}");
            var content = await response.Content.ReadAsStringAsync();
            var apartaments = JsonConvert.DeserializeObject<IEnumerable<HomeApDTO>>(content);
            return apartaments;
        }
        public async Task<HomeApDTO> GetHomeApById(int apartamentId, string checkInDate, string checkOutDate)
        {

            var response = await _client.GetAsync($"api/homeapartament/{apartamentId}?checkIn={checkInDate}&checkOut={checkInDate}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apartament = JsonConvert.DeserializeObject<HomeApDTO>(content);
                return apartament;
            }
            else
            {
                return null;
            }
        }
    }
}
