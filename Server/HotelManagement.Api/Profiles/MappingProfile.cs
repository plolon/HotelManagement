using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.DTOs.HotelRoom;
using HotelManagement.Api.DTOs.RoomType;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Models.OptionSets;

namespace HotelManagement.Api.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region dto->domain

            CreateMap<HotelDto, Hotel>()
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
            // .ForMember(hrdto => hrdto.RoomType,
            //     opt => opt.MapFrom(hr => new RoomTypeDto
            //         { Id = hr.RoomType.Id, Name = hr.RoomType.Name }));

            #endregion domain->dto
        }
    }
}