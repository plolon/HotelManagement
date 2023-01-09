using HotelManagement.Application.Abstraction;

namespace HotelManagement.Application.Features.Bookings.Commands.Delete
{
public class DeleteBookingRequest : ICommand<bool>
{
    public int Id { get; set; }
}
}