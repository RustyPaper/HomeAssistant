using Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAssistant_Client.Service.IService
{
    public interface IHomeAmenityService
    {

        public Task<IEnumerable<HomeAmenityDTO>> GetAmenityList();
    }
}
