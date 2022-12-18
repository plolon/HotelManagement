using HotelManagement.Application.Abstraction;
using HotelManagement.Application.DTOs.HotelRoom;

namespace HotelManagement.Application.Features.HotelRooms.Commands.Create
{
    public class CreateHotelRoomRequest : ICommand<HotelRoomDto>
    {
        public CreateHotelRoomDto CreateHotelRoomDto { get; set; }
    }
}
