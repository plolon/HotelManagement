namespace HotelManagement.Api.DTOs.Hotel
{
    public class SaveHotelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HotelAddressDto Address { get; set; }
    }
}
