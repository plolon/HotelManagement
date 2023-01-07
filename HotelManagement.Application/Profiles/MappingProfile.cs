using AutoMapper;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateHotelMappings();
            CreateHotelRoomMappings();
            CreateOptionSetMappings();
            CreateUserMappings();
            CreateBookingMappings();
        }
    }
}