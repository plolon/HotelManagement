namespace HotelManagement.Domain.Exceptions
{
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string message) : base("Bad Request", message)
        {
        }
    }
}