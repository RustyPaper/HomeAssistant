using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHomeApRepository
    {

        //Create a new home apartament DTO, then return that DTO
    public Task<HomeApDTO> CreateHomeAp(HomeApDTO homeApDTO);

        //Update home
        public Task<HomeApDTO> UpdateHomeAp(int apartamentId,HomeApDTO homeApDTO);

        //Get individiaul home
        public Task<HomeApDTO> GetHomeAp(int apartamentId, string checkIn = null, string checkOut = null);
        public Task<int> DeleteHomeAp(int apartamentId);


        //Get all homes
        public Task<IEnumerable<HomeApDTO>> GetAllHomeAp(string checkIn = null, string checkOut = null);

        //Get the name of the home apartament to validate booking

        public Task<bool> IsBooked(int ApartamentId, string checkInDate, string checkOutDate);

    }
}
