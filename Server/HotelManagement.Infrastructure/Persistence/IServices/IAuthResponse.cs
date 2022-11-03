namespace HotelManagement.Infrastructure.Persistence.IServices;

public interface IAuthResponse
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
}