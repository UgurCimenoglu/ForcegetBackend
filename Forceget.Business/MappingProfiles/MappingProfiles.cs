using AutoMapper;
using Forceget.Core.Entities;
using Forceget.Entities.Concrete;
using Forceget.Entities.Dtos;

namespace Forceget.Business.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDetailDto>().ReverseMap();
            CreateMap<Mode, ModeDetailDto>().ReverseMap();
            CreateMap<MovementType, MovementTypeDetailDto>().ReverseMap();
            CreateMap<Incoterm, IncotermDetailDto>().ReverseMap();
            CreateMap<Country, CountryDetailDto>().ReverseMap().ForMember(dest => dest.Cities, opt => opt.MapFrom(src => src.Cities));
            CreateMap<City, CityDetailForCountryDto>().ReverseMap();
            CreateMap<City, CityDetailDto>().ReverseMap();
            CreateMap<Offer, OfferAddDto>().ReverseMap();
            CreateMap<PackageType, PackageTypeDetailDto>().ReverseMap();
            CreateMap<Unit1, Unit1DetailDto>().ReverseMap();
            CreateMap<Unit2, Unit2DetailDto>().ReverseMap();
            CreateMap<Currency, CurrencyDetailDto>().ReverseMap();
            CreateMap<Offer, OfferAddDto>().ReverseMap();
        }
    }
}
