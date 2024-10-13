using AutoMapper;
using Data.Entities;
using Data.Entities.VenichleInfo;
using WebApplication1.Models;

namespace WebApplication1.MapperProfiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<CreateVehichleModel, Venichle>();
            CreateMap<CreateAuctionModel, Auction>();
            CreateMap<Venichle, CreateVehichleModel>();
            CreateMap<Auction, CreateAuctionModel>();
        }
    }
}
