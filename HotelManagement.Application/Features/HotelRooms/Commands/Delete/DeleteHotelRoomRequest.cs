using HotelManagement.Application.Abstraction;

namespace HotelManagement.Application.Features.HotelRooms.Commands.Delete
{
    public class DeleteHotelRoomRequest : ICommand<bool>
    {
        public int Id { get; set; }
    }
}