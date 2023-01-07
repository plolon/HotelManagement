namespace HotelManagement.Application.DTOs.HotelRoom
{
    public class CreateHotelRoomDto
        {
            public string Number { get; set; }
            public int HotelId { get; set; }
            public int RoomTypeId { get; set; }
            
        }
}