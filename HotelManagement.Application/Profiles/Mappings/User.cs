using HotelManagement.Domain.Models;
using HotelManagement.Application.Models;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateUserMappings()
        {
            CreateMap<RegistrationRequest, ApplicationUser>()
                .ForMember(appUsr => appUsr.Email, opt => opt.MapFrom(regReq => regReq.Email))
                .ForMember(appUsr => appUsr.FirstName, opt => opt.MapFrom(regReq => regReq.FirstName))
                .ForMember(appUsr => appUsr.LastName, opt => opt.MapFrom(regReq => regReq.LastName))
                .ForMember( appUsr => appUsr.UserName, opt => opt.MapFrom(regReq => regReq.UserName))
                .ForMember( appUsr => appUsr.Password, opt => opt.MapFrom(regReq => regReq.Password))
                .ForMember( appUsr => appUsr.NormalizedEmail, opt => opt.MapFrom( regReq => regReq.Email.ToUpper()))
                .ForMember(appUsr => appUsr.NormalizedUserName, opt => opt.MapFrom(regReq => regReq.UserName.ToUpper()));
        }
    }
}