using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IApartamentOrderDetailsRepository
    {

        public Task<ApartamentOrderDetailsDTO> Create(ApartamentOrderDetailsDTO details);
        public Task<ApartamentOrderDetailsDTO> PaymentSuccessful(int id);
        public Task<ApartamentOrderDetailsDTO> GetApartamentOrderDetail(int apartamentOrderId);
        public Task<IEnumerable<ApartamentOrderDetailsDTO>> GetAllApartamentOrderDetail();
        public Task<bool> OrderStatus (int apartamentOrderId,string status);
        public Task<int> DeleteBooking(int bookingId);


    }
}
