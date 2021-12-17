using AutoMapper;
using Business.Repository.IRepository;
using DataAccess;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HomeApRepository : IHomeApRepository
    {
        //implements the methods defined in the interface
        

        // Use application db context
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        // get an implementation of appdbcontext and assign to local variable 
        public HomeApRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }


        public async Task<HomeApDTO> CreateHomeAp(HomeApDTO homeApDTO)
        {
            HomeAp homeAp = _mapper.Map<HomeApDTO, HomeAp>(homeApDTO);
            homeAp.CreatedDate = DateTime.Now;
            homeAp.CreatedBy = "";

            var addApartament = await _db.HomeAps.AddAsync(homeAp);

            await _db.SaveChangesAsync();

            return _mapper.Map<HomeAp, HomeApDTO>(addApartament.Entity);

        }

        public async Task<IEnumerable<HomeApDTO>> GetAllHomeAp(string checkInStr, string checkOutStr)
        {
            try
            {
                IEnumerable<HomeApDTO> homeApDTOs = _mapper.Map<IEnumerable<HomeAp>, 
                    IEnumerable<HomeApDTO>>(_db.HomeAps.Include(x => x.HomeApImages));

                if (!string.IsNullOrEmpty(checkInStr) && !string.IsNullOrEmpty(checkOutStr)){
                   foreach(HomeApDTO homeAp in homeApDTOs)
                    {
                        homeAp.IsBooked = await IsBooked(homeAp.Id, checkInStr, checkOutStr);

                    }

                }
                return homeApDTOs;
            }

            catch (Exception ex )
            {
                {
                    throw ex;
                }
            }
        }


        public async Task<HomeApDTO> GetHomeAp(int apartamentId, string checkInStr, string checkOutStr)
        {
            try
            {
                HomeApDTO homeAp = _mapper.Map<HomeAp, HomeApDTO>(
                    await _db.HomeAps.Include(x=>x.HomeApImages).FirstOrDefaultAsync(x => x.Id == apartamentId));

                if(!string.IsNullOrEmpty(checkInStr)&& !string.IsNullOrEmpty(checkOutStr)){
                    homeAp.IsBooked = await IsBooked(homeAp.Id, checkInStr, checkOutStr);
                }

                return homeAp;
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        
        public async Task<bool> IsBooked(int ApartamentId, string checkInDatestr, string checkOutDatestr)
        {
            try
            {
                if (!string.IsNullOrEmpty(checkOutDatestr) && !string.IsNullOrEmpty(checkInDatestr))
                {
                    DateTime checkInDate = DateTime.ParseExact(checkInDatestr, "dd/MM/yyyy", null);
                    DateTime checkOutDate = DateTime.ParseExact(checkOutDatestr, "dd/MM/yyyy", null);

                    var existingBooking = await _db.ApartamentOrderDetails.Where(x => x.ApartamentId == ApartamentId && x.PaymentSuccessful &&
                       //check if checkin date that user wants does not fall in between any dates for apartament that is booked
                       (checkInDate < x.CheckOutDate && checkInDate.Date >= x.CheckInDate
                       //check if checkout date that user wants does not fall in between any dates for apartament that is booked
                       || checkOutDate.Date > x.CheckInDate.Date && checkInDate.Date <= x.CheckInDate.Date
                       )).FirstOrDefaultAsync();

                    if (existingBooking != null)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<HomeApDTO> UpdateHomeAp(int apartamentId, HomeApDTO homeApDTO)
        {
            try
            {
                if (apartamentId == homeApDTO.Id)
                {
                    //valid
                    HomeAp apartamentDetails = await _db.HomeAps.FindAsync(apartamentId);
                    HomeAp apartament = _mapper.Map<HomeApDTO, HomeAp>(homeApDTO, apartamentDetails);
                    apartament.UpdatedBy = "";
                    apartament.UpdatedDate = DateTime.Now;
                    var updatedApartament = _db.HomeAps.Update(apartament);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<HomeAp, HomeApDTO>(updatedApartament.Entity);
                }
                else
                {
                    //invalid
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> DeleteHomeAp(int apartamentId)
        {
            var apartamentDetails = await _db.HomeAps.FindAsync(apartamentId);

            if (apartamentDetails != null)
            {
                //find the images associated with the apartamentId
                var allImages = await _db.HomeApImages.Where(x => x.ApartamentId == apartamentId).ToListAsync();
                

                _db.HomeApImages.RemoveRange(allImages);

                _db.HomeAps.Remove(apartamentDetails);
                return await _db.SaveChangesAsync();
            }
            return 0;

        }
    }
}
