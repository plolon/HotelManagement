namespace HotelManagement.Application.Identity.Models
{
    public class AuthResponse : IAuthResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }

    public class AuthRequest : IAuthRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}