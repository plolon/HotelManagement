using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Booking;

namespace HotelManagement.Application.Features.Queries.Bookings.Requests
{
    public class GetAllBookingsRequest : IQuery<ICollection<BookingDto>>
    {
    }
}

