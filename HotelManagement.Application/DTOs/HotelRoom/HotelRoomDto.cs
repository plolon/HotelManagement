using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.DTOs.OptionSets;

namespace HotelManagement.Application.DTOs.HotelRoom
{
    public class HotelRoomDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public virtual RoomTypeDto RoomType { get; set; }
        public virtual HotelDto Hotel { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}