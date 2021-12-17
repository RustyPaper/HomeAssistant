using AutoMapper;
using Business.Repository.IRepository;
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
    public class HomeAmenityRepository : IHomeAmenityRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HomeAmenityRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<HomeAmenityDTO> CreateHomeAmenity(HomeAmenityDTO homeAmenity)
        {
            var amenity = _mapper.Map<HomeAmenityDTO, HomeAmenity>(homeAmenity);
            amenity.CreatedBy = "";
            amenity.CreatedDate = DateTime.UtcNow;
            var addedHomeAmenity = await _context.HomeAmenities.AddAsync(amenity);
            await _context.SaveChangesAsync();
            return _mapper.Map<HomeAmenity, HomeAmenityDTO>(addedHomeAmenity.Entity);
        }

        public async Task<HomeAmenityDTO> UpdateHomeAmenity(int amenityId, HomeAmenityDTO homeAmenity)
        {
            var amenityDetails = await _context.HomeAmenities.FindAsync(amenityId);
            var amenity = _mapper.Map(homeAmenity, amenityDetails);
            amenity.UpdatedBy = "";
            amenity.UpdatedDate = DateTime.UtcNow;
            var updatedamenity = _context.HomeAmenities.Update(amenity);
            await _context.SaveChangesAsync();
            return _mapper.Map<HomeAmenity, HomeAmenityDTO>(updatedamenity.Entity);
        }

        public async Task<int> DeleteHomeAmenity(int amenityId, string userId)
        {
            var amenityDetails = await _context.HomeAmenities.FindAsync(amenityId);
            if (amenityDetails != null)
            {
                _context.HomeAmenities.Remove(amenityDetails);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<IEnumerable<HomeAmenityDTO>> GetAllHomeAmenity()
        {
            return _mapper.Map<IEnumerable<HomeAmenity>, IEnumerable<HomeAmenityDTO>>(await _context.HomeAmenities.ToListAsync());
        }

        public async Task<HomeAmenityDTO> GetHomeAmenity(int amenityId)
        {
            var amenityData = await _context.HomeAmenities
                           .FirstOrDefaultAsync(x => x.Id == amenityId);

            if (amenityData == null)
            {
                return null;
            }
            return _mapper.Map<HomeAmenity, HomeAmenityDTO>(amenityData);
        }

        public async Task<HomeAmenityDTO> IsSameNameAmenityAlreadyExists(string name)
        {
            try
            {
                var amenityDetails =
                    await _context.HomeAmenities.FirstOrDefaultAsync(x => x.Name.ToLower().Trim() == name.ToLower().Trim()
                    );
                return _mapper.Map<HomeAmenity, HomeAmenityDTO>(amenityDetails);
            }
            catch (Exception ex)
            {

            }
            return new HomeAmenityDTO();
        }
    }
}
