using AutoMapper;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<HomeApDTO, HomeAp>();
            CreateMap<HomeAp, HomeApDTO>();
            CreateMap<HomeApImage, HomeApImageDTO>().ReverseMap();
            CreateMap<HomeAmenity, HomeAmenityDTO>();
            CreateMap<ApartamentOrderDetails, ApartamentOrderDetailsDTO>().ForMember(x => x.HomeApDTO, opt => opt.MapFrom(c => c.HomeAp));
            CreateMap<ApartamentOrderDetailsDTO, ApartamentOrderDetails>();
        }
    }
}
