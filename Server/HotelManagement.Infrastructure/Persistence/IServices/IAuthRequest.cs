namespace HotelManagement.Infrastructure.Persistence.IServices
{
    public interface IAuthRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}