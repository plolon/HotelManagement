using System.Collections.ObjectModel;
using HotelManagement.Application.DTOs.HotelRoom;

namespace HotelManagement.Application.DTOs.Hotel
{
    public class HotelWithRoomsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<HotelRoomDto> HotelRooms { get; set; }

        public HotelWithRoomsDto()
        {
            HotelRooms = new Collection<HotelRoomDto>();
        }
    }
}