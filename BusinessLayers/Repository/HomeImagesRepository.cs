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
    public class HomeImagesRepository : IHomeImagesRepository
    {

        // Use application db context
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        // get an implementation of appdbcontext and assign to local variable 
        public HomeImagesRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }


        public async Task<int> CreateHomeApImage(HomeApImageDTO imageDTO)
        {

            //convert DTO to image
            var image = _mapper.Map<HomeApImageDTO, HomeApImage>(imageDTO);
            await _db.HomeApImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteHomeImageByImageUrl(string imageUrl)
        {
            var allImages = await _db.HomeApImages.FirstOrDefaultAsync(x => x.ApartamentImageURL.ToLower() == imageUrl.ToLower());
            _db.HomeApImages.Remove(allImages);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteHomeApImageByImageId(int imageId)
        {
            var image = await _db.HomeApImages.FindAsync(imageId);
            _db.HomeApImages.Remove(image);
            return await _db.SaveChangesAsync();

        }

        public async Task<int> DeleteHomeApImageByApartamentId(int apartamentId)
        {
            var imageList = await _db.HomeApImages.Where(x => x.ApartamentId == apartamentId).ToListAsync();
            _db.HomeApImages.RemoveRange(imageList);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<HomeApImageDTO>> GetHomeApImages(int apartamentId)
        {
            return _mapper.Map<IEnumerable<HomeApImage>, IEnumerable<HomeApImageDTO>>(
            await _db.HomeApImages.Where(x => x.ApartamentId == apartamentId).ToListAsync());
        }
    }
}
