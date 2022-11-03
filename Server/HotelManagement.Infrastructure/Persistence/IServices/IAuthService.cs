namespace HotelManagement.Infrastructure.Persistence.IServices
{
    public interface IAuthService
    {
        Task<IAuthResponse> Login(string request);
    }
}