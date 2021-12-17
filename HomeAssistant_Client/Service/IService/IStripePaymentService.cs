using Models;
using System.Threading.Tasks;

namespace HomeAssistant_Client.Service.IService
{
    public interface IStripePaymentService
    {

        public Task<SuccessModel> CheckOutCompleted(StripePaymentDTO model);

    }
}
