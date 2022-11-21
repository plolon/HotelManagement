namespace HotelManagement.Domain.Exceptions
{
    public class UserNotFoundException : ApplicationException
    {
        public UserNotFoundException(string message) : base("Not Found", message)
        {
        }
    }
}