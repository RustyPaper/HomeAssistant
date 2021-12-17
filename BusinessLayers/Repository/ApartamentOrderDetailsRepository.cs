using AutoMapper;
using Business.Repository.IRepository;
using CommonFiles;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class ApartamentOrderDetailsRepository : IApartamentOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ApartamentOrderDetailsRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }



        public async Task<ApartamentOrderDetailsDTO> Create(ApartamentOrderDetailsDTO details)
        {
            try
            {

                //Creating order detail, this will be a booking
                //Get the dates
                details.CheckInDate = details.CheckInDate.Date;
                details.CheckOutDate = details.CheckOutDate.Date;

                //Convert DTO to return ApartamentOrderDetails object
                var apartamentOrder = _mapper.Map<ApartamentOrderDetailsDTO, ApartamentOrderDetails>(details);
                apartamentOrder.Status = SD.Status_Pending;
                var result = await _db.ApartamentOrderDetails.AddAsync(apartamentOrder);

                await _db.SaveChangesAsync();
                return _mapper.Map<ApartamentOrderDetails, ApartamentOrderDetailsDTO>(result.Entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<ApartamentOrderDetailsDTO>> GetAllApartamentOrderDetail()
        {
            try
            {

                IEnumerable<ApartamentOrderDetailsDTO> apartamentOrders = _mapper.Map<IEnumerable<ApartamentOrderDetails>, IEnumerable<ApartamentOrderDetailsDTO>>
                   (_db.ApartamentOrderDetails.Include(u => u.HomeAp));

                return apartamentOrders;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ApartamentOrderDetailsDTO> GetApartamentOrderDetail(int apartamentOrderId)
        {
            try
            {

                ApartamentOrderDetails apartamentOrder = await _db.ApartamentOrderDetails.Include(u => u.HomeAp).ThenInclude(x => x.HomeApImages).FirstOrDefaultAsync(u => u.Id == apartamentOrderId);

                ApartamentOrderDetailsDTO apartamentOrderDetailsDTO = _mapper.Map<ApartamentOrderDetails, ApartamentOrderDetailsDTO>(apartamentOrder);
                apartamentOrderDetailsDTO.HomeApDTO.StayLength = apartamentOrderDetailsDTO.CheckOutDate.Subtract(apartamentOrderDetailsDTO.CheckInDate).Days;
                return apartamentOrderDetailsDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public async Task<bool> OrderStatus(int apartamentOrderId, string status)
        {
            try
            {

                var order = await _db.ApartamentOrderDetails.FirstOrDefaultAsync(u => u.Id == apartamentOrderId);
                if (order == null)
                {
                    return false;
                }
                else
                {
                    order.Status = status;
                }

                if (status == SD.Status_CheckedIn)
                {
                    order.ActualCheckInDate = DateTime.Now;
                }
                if (status == SD.Status_CheckedOut_Completed)
                {
                    order.ActualCheckOutDate = DateTime.Now;
                }
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<ApartamentOrderDetailsDTO> PaymentSuccessful(int id)
        {
            var data = await _db.ApartamentOrderDetails.FindAsync(id);

            if (data == null)
            {
                return null;
            }

            if (!data.PaymentSuccessful)
            {
                data.PaymentSuccessful = true;
                data.Status = SD.Status_Booked;
                var paymentSuccess = _db.ApartamentOrderDetails.Update(data);
                await _db.SaveChangesAsync();
                return _mapper.Map<ApartamentOrderDetailsDTO>(paymentSuccess.Entity);
            }
            return new ApartamentOrderDetailsDTO();
        }


        public async Task<int> DeleteBooking(int bookingId)
        {

            //Find the booking 
            var booking = await _db.ApartamentOrderDetails.FindAsync(bookingId);

            if (booking == null)
            {
                return 0;
            }

            _db.ApartamentOrderDetails.Remove(booking);
            return await _db.SaveChangesAsync();

        }
    }
}

