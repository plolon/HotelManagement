using HotelManagement.Application.Identity.Models;

namespace HotelManagement.Application.Identity
{
    public interface IAuthService
    {
        Task<IAuthResponse> Login(IAuthRequest request);
        Task<RegistrationResponse> Register(RegistrationResponse request);
    }
}