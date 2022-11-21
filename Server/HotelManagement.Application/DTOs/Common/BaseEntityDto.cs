namespace HotelManagement.Application.DTOs.Common
{
    public class BaseEntityDto
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}