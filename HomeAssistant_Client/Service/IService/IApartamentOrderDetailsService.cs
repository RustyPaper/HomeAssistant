using Models;
using System.Threading.Tasks;

namespace HomeAssistant_Client.Service.IService
{
    public interface IApartamentOrderDetailsService
    {

        public Task<ApartamentOrderDetailsDTO> SaveApartamentOrderDetails(ApartamentOrderDetailsDTO details);
        public Task<ApartamentOrderDetailsDTO> PaymentSuccessful(ApartamentOrderDetailsDTO details);

    }
}
