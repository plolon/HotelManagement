using HotelManagement.Domain.Models;
using HotelManagement.Application.Models;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateUserMappings()
        {
            CreateMap<RegistrationRequest, ApplicationUser>()
        }
    }
}