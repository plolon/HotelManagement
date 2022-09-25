using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Domain.Models;

namespace HotelManagement.Api.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelDto, Hotel>()
                .ForMember(h => h.Country, opt => opt.MapFrom(hdto => hdto.Address.Country))
                .ForMember(h => h.City, opt => opt.MapFrom(hdto => hdto.Address.City))
                .ForMember(h => h.Street, opt => opt.MapFrom(hdto => hdto.Address.Street));

            CreateMap<Hotel, HotelDto>()
                .ForMember(hdto => hdto.Address, opt => opt.MapFrom(h =>
                    new HotelAddressDto
                    {
                        Country = h.Country,
                        City = h.City,
                        Street = h.Street
                    }));
        }
    }
}
