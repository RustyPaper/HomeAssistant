using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHomeImagesRepository  
    {

        public Task<int> CreateHomeApImage(HomeApImageDTO image);

        public Task<int> DeleteHomeApImageByImageId(int imageId);
        public Task<int> DeleteHomeApImageByApartamentId(int apartamentId);
        public Task<IEnumerable<HomeApImageDTO>> GetHomeApImages(int apartamentId);

        public Task<int> DeleteHomeImageByImageUrl(string imageUrl);

    }
}
