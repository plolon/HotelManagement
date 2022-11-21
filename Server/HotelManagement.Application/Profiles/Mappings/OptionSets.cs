using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Domain.Models.OptionSets;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateOptionSetMappings()
        {
            CreateMap<RoomType, RoomTypeDto>();
        }
    }
}