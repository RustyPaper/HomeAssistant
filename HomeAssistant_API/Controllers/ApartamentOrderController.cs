using Business.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
using Stripe.Checkout;
using System.Threading.Tasks;

namespace HomeAssistant_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ApartamentOrderController : Controller
    {

        private readonly IApartamentOrderDetailsRepository _repository;

        public ApartamentOrderController(IApartamentOrderDetailsRepository repository)
        {
            _repository = repository;   
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ApartamentOrderDetailsDTO details)
        {
            if (ModelState.IsValid)
            {
                var result = await _repository.Create(details);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating Apartament Details"
                }) ;
            }
        }
        [HttpPost]
        public async Task<IActionResult> PaymentSuccessful([FromBody] ApartamentOrderDetailsDTO details)
        {
            //Validate payment
            var service = new SessionService();
            var sessionDetails = service.Get(details.StripeSessionId);

            if (sessionDetails.PaymentStatus == "paid")
            {

                var result = await _repository.PaymentSuccessful(details.Id);
                if (result == null)
                {
                    return BadRequest(new ErrorModel()
                    {
                        ErrorMessage = "Payment not successful"
                    });
                }
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Payment not successful"
                });
            }
        }
    }
}
