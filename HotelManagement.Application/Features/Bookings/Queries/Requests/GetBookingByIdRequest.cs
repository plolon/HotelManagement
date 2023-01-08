using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Booking;
using MediatR;

namespace HotelManagement.Application.Features.Queries.Bookings.Requests
{
    public class GetBookingByIdRequest : IQuery<BookingDto>
    {
        public int Id { get; set; }
    }
}