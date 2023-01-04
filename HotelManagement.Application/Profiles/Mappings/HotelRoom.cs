using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Domain.Models;

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
            CreateMap<CreateHotelRoomDto, HotelRoom>();
        }
    }
}