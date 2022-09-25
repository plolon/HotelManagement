using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Api.DTOs.Hotel
{
    public class HotelDto
    {
        public string Name { get; set; }
        public HotelAddressDto Address { get; set; }
    }
}
