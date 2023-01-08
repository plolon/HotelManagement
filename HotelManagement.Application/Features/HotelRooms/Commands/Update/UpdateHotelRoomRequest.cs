using HotelManagement.Application.Abstraction;
using HotelManagement.Application.DTOs.HotelRoom;

namespace HotelManagement.Application.Features.HotelRooms.Commands.Update;

public class UpdateHotelRoomRequest : ICommand<HotelRoomDto>
{
    public int Id { get; set; }
    public CreateHotelRoomDto UpdateHotelRoomDto { get; set; }
}