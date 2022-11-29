using HotelManagement.Application.Models;

namespace HotelManagement.Identity.Services
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationResponse request);
    }
}