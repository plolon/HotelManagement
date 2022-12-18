using HotelManagement.Application.DTOs.RoomType;

namespace HotelManagement.Application.DTOs.HotelRoom
{
    public class CreateHotelRoomDto
        {
            public string Number { get; set; }
            public int HotelId { get; set; }
            public virtual RoomTypeDto RoomTypeDto { get; set; }
            
        }
}