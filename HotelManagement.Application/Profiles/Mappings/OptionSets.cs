using HotelManagement.Application.DTOs.OptionSets;
using HotelManagement.Domain.Models.OptionSets;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateOptionSetMappings()
        {
            CreateMap<RoomType, RoomTypeDto>();
            CreateMap<Status, StatusDto>();
        }
    }
}