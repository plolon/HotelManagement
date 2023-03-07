using HotelManagement.Application.Models;
using HotelManagement.Domain.Models;

namespace HotelManagement.Identity.Services
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<ApplicationUser> Register(RegistrationRequest request);
        Task<bool> DeleteUser(Guid id);
    }
}