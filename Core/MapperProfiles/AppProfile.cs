using AutoMapper;
using Core.Models;
using Core.Services;
using Data.Entities;
using Data.Entities.VenichleInfo;

namespace Core.MapperProfiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<SellCarModel, Venichle>().AfterMap<SellVehicleMapping>()
                                               .ForPath(dest => dest.Auction.CurrentPrice, opt => opt.MapFrom(src => src.AuctionStartPrice))
                                               .ForPath(dest => dest.Auction.CityNow, opt => opt.MapFrom(src => src.AuctionCityNow))
                                               .ForPath(dest => dest.Auction.MinDescription, opt => opt.MapFrom(src => src.AuctionMinDescription))
                                               .ForPath(dest => dest.Auction.Name, opt => opt.MapFrom(src => src.AuctionName))
                                               .ForPath(dest => dest.Auction.TimeEnd, opt => opt.MapFrom(src => DateTime.SpecifyKind(src.AuctionTimeEnd, DateTimeKind.Local)))
                                               .ForPath(dest => dest.Auction.TimeStart, opt => opt.MapFrom(src => DateTime.SpecifyKind(src.AuctionTimeStart, DateTimeKind.Local)));



            CreateMap<Venichle, EditCarModel>();
            CreateMap<EditCarModel, Venichle>().AfterMap<EditVehicleMapping>();
            CreateMap<EditCarModel, Auction>().ForMember(dest => dest.VenichleId, opt => opt.MapFrom(src => src.Id))
                                              .ForMember(dest => dest.TimeStart, opt => opt.MapFrom(src => DateTime.SpecifyKind(src.AuctionTimeStart, DateTimeKind.Local)))
                                              .ForMember(dest => dest.TimeEnd, opt => opt.MapFrom(src => DateTime.SpecifyKind(src.AuctionTimeEnd, DateTimeKind.Local)))
                                              .ForMember(dest => dest.CurrentPrice, opt => opt.MapFrom(src => src.AuctionStartPrice))
                                              .ForMember(dest => dest.CityNow, opt => opt.MapFrom(src => src.AuctionCityNow))
                                              .ForMember(dest => dest.MinDescription, opt => opt.MapFrom(src => src.AuctionMinDescription))
                                              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.AuctionName));
        }
    }

    public class SellVehicleMapping(IFileService service) : IMappingAction<SellCarModel, Venichle>
    {
        public void Process(SellCarModel s, Venichle d, ResolutionContext context)
        {
            d.MainPhotoURL = service.SaveImage(s.MainPhoto).Result;
            d.ExteriorPhotosURLId = service.SaveImages(s.ExteriorPhotos.ToList()).Result;
            d.InteriorPhotosURLId = service.SaveImages(s.InteriorPhotos.ToList()).Result;
        }
    }

    public class EditVehicleMapping(IFileService service) : IMappingAction<EditCarModel, Venichle>
    {
        public void Process(EditCarModel s, Venichle d, ResolutionContext context)
        {
            if (s.MainPhoto != null) d.MainPhotoURL = service.EditImage(s.MainPhoto, d.MainPhotoURL).Result;
            if (s.ExteriorPhotos != null) d.ExteriorPhotosURLId = service.SaveImages(s.ExteriorPhotos.ToList()).Result;
            if (s.InteriorPhotos != null) d.InteriorPhotosURLId = service.SaveImages(s.InteriorPhotos.ToList()).Result;
        }
    }

}
