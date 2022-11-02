using AutoMapper;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Models.OptionSets;

namespace HotelManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region dto->domain

            var xd = CreateMap<HotelDto, Hotel>()
                .ForMember(h => h.Country, opt => opt.MapFrom(hdto => hdto.Address.Country))
                .ForMember(h => h.City, opt => opt.MapFrom(hdto => hdto.Address.City))
                .ForMember(h => h.Street, opt => opt.MapFrom(hdto => hdto.Address.Street));

            CreateMap<SaveHotelDto, Hotel>()
                .ForMember(h => h.Id, opt => opt.Ignore())
                .ForMember(h => h.Country, opt => opt.MapFrom(hdto => hdto.Address.Country))
                .ForMember(h => h.City, opt => opt.MapFrom(hdto => hdto.Address.City))
                .ForMember(h => h.Street, opt => opt.MapFrom(hdto => hdto.Address.Street));

            CreateMap<HotelRoomDto, HotelRoom>()
                .ForMember(hr => hr.RoomType, opt => opt.MapFrom(hrdto => hrdto.RoomType));
                
            #endregion dto->domain

            #region domain->dto

            CreateMap<Hotel, HotelDto>()
                .ForMember(hdto => hdto.Address, opt => opt.MapFrom(h =>
                    new HotelAddressDto
                    {
                        Country = h.Country,
                        City = h.City,
                        Street = h.Street
                    }));

            CreateMap<RoomType, RoomTypeDto>();
            CreateMap<HotelRoom, HotelRoomDto>()
                .ForMember(hrdto => hrdto.RoomType, opt => opt.MapFrom(hr => hr.RoomType));

            #endregion domain->dto
        }
    }
}