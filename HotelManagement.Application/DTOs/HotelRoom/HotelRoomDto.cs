using HotelManagement.Application.DTOs.RoomType;

namespace HotelManagement.Application.DTOs.HotelRoom
{
    public class HotelRoomDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int RoomTypeId { get; set; }
        public virtual RoomTypeDto RoomType { get; set; }
        public int HotelId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}