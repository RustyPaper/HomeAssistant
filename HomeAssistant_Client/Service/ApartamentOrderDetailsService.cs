using HomeAssistant_Client.Service.IService;
using Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssistant_Client.Service
{
    public class ApartamentOrderDetailsService  : IApartamentOrderDetailsService
    {

        private readonly HttpClient _client;

        public ApartamentOrderDetailsService(HttpClient client)
        {
            _client = client;
        }


        public async Task<ApartamentOrderDetailsDTO> PaymentSuccessful(ApartamentOrderDetailsDTO details)
        {
            //Serialise
            var content = JsonConvert.SerializeObject(details);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/apartamentorder/paymentsuccessful", bodyContent);

            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApartamentOrderDetailsDTO>(contentTemp);
                return result;
            }
            else
            {
                return null;
            }
        }
        //saving the order after payment completed
        //
        public async Task<ApartamentOrderDetailsDTO> SaveApartamentOrderDetails(ApartamentOrderDetailsDTO details)
        {
            details.UserId = "James";
            var content = JsonConvert.SerializeObject(details);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            //
            var response = await _client.PostAsync("api/apartamentorder/create", bodyContent);

            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApartamentOrderDetailsDTO>(contentTemp);
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
