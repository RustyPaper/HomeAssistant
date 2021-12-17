using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHomeAmenityRepository
    {

        public Task<HomeAmenityDTO> CreateHomeAmenity(HomeAmenityDTO homeAmenity);
        public Task<HomeAmenityDTO> UpdateHomeAmenity(int amenityId, HomeAmenityDTO homeAmenity);
        public Task<int> DeleteHomeAmenity(int amenityId, string userId);
        public Task<IEnumerable<HomeAmenityDTO>> GetAllHomeAmenity();
        public Task<HomeAmenityDTO> GetHomeAmenity(int amenityId);
        public Task<HomeAmenityDTO> IsSameNameAmenityAlreadyExists(string name);


    }
}
