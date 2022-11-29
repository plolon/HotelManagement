using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Models.OptionSets;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateHotelRoomMappings()
        {
            CreateMap<HotelRoomDto, HotelRoom>()
                .ForMember(hr => hr.RoomType, opt => opt.MapFrom(hrdto => hrdto.RoomType));
            CreateMap<HotelRoom, HotelRoomDto>()
                .ForMember(hrdto => hrdto.RoomType, opt => opt.MapFrom(hr => hr.RoomType));
        }
    }
}