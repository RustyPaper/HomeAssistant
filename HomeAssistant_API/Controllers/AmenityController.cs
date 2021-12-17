using Business.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace HomeAssistant_API.Controllers
{


    [Route("api/[controller]")]
    public class AmenityController : Controller
    {
        private readonly IHomeAmenityRepository _homeAmenityRepository;

        public AmenityController( IHomeAmenityRepository homeAmenityRepository)
        {
        _homeAmenityRepository = homeAmenityRepository;
        }



        [HttpGet]
        public async Task<IActionResult> GetAmenityList()
        {
            var amenityList = await _homeAmenityRepository.GetAllHomeAmenity();
            return Ok(amenityList);
            
            
        } 
    }
}
