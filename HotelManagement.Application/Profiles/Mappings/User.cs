using HotelManagement.Domain.Models;
using HotelManagement.Application.Models;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateUserMappings()
        {
            CreateMap<RegistrationRequest, ApplicationUser>()
                .ForMember(appUsr => appUsr.NormalizedEmail,
                    opt => opt.MapFrom(regReq => regReq.Email.ToUpper()))
                .ForMember(appUsr => appUsr.NormalizedUserName,
                    opt => opt.MapFrom(regReq => regReq.UserName.ToUpper()));
        }
    }
}
