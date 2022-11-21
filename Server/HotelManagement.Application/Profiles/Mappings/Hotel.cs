using AutoMapper;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Domain.Models;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateHotelMappings()
        {
            CreateMap<HotelDto, Hotel>()
                .ForMember(h => h.Country, opt => opt.MapFrom(hdto => hdto.Address.Country))
                .ForMember(h => h.City, opt => opt.MapFrom(hdto => hdto.Address.City))
                .ForMember(h => h.Street, opt => opt.MapFrom(hdto => hdto.Address.Street));
            
            CreateMap<SaveHotelDto, Hotel>()
                .ForMember(h => h.Id, opt => opt.Ignore())
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