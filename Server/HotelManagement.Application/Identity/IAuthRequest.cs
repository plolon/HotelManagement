namespace HotelManagement.Application.Identity
{
    public interface IAuthRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}