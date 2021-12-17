using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAssistant_Client.Service.IService
{
    public interface IHomeApService
    {

        public Task<IEnumerable<HomeApDTO>>  GetHomeAps(string checkInDate, string checkOutDate);
        public Task<HomeApDTO> GetHomeApById(int apartamentId, string checkInDate, string checkOutDate);
    }
}
