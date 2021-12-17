using Business.Repository.IRepository;
using CommonFiles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace HomeAssistant_API.Controllers
{
    //Purpose of this controller is to fetch the apartaments from the database and return them to the client home page of the application.
    [Route("api/[controller]")]
    public class HomeApController : Controller
    {
        private readonly IHomeApRepository _homeApRepository;

        public HomeApController(IHomeApRepository homeApRepository)
        {
            _homeApRepository = homeApRepository;
        }



        [HttpGet]
        public async Task<IActionResult> GetHomeAps(string checkIn = null, string checkOut = null)
        {
            if (string.IsNullOrEmpty(checkIn) || string.IsNullOrEmpty(checkOut))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "All parameters need to be supplied"
                });
            }
            //check if the dates are in dd mm yyyy
            if (!DateTime.TryParseExact(checkIn, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckInDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "Invalid date - Please do it as dd/MM/yyyy"
                });
            }
            if (!DateTime.TryParseExact(checkOut, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckOutDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "Invalid date - Please do it as dd/MM/yyyy"
                });
            }

            var ApartamentCount = await _homeApRepository.GetAllHomeAp(checkIn,checkOut);
            return Ok(ApartamentCount);
        }


        [HttpGet("{apartamentId}")]
        public async Task<IActionResult> GetHomeApById(int? apartamentId, string checkIn = null, string checkOut = null)
        {
            if (string.IsNullOrEmpty(checkIn) || string.IsNullOrEmpty(checkOut))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "All parameters need to be supplied"
                });
            }

          
            var apartamentDetails = await _homeApRepository.GetHomeAp(apartamentId.Value, checkIn,checkOut);

            if (apartamentDetails == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "Error",
                    ErrorMessage = "InvalidApartamentId",
                    StatusCode = StatusCodes.Status404NotFound
                }); ;
            }
            return Ok(apartamentDetails);
        }
    }
}
