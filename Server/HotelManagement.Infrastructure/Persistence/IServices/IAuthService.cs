namespace HotelManagement.Infrastructure.Persistence.IServices
{
    public interface IAuthService
    {
        public Task<IAuthResponse> Login(string request);
    }
}