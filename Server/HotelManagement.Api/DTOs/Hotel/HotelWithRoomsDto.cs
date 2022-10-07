using System.Collections.ObjectModel;
using HotelManagement.Api.DTOs.HotelRoom;

namespace HotelManagement.Api.DTOs.Hotel;

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