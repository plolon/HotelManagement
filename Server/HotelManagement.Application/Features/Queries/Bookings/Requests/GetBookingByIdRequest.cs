using HotelManagement.Application.DTOs.Booking;
using MediatR;

namespace HotelManagement.Application.Features.Queries.Bookings.Requests
{
    public class GetBookingByIdRequest
    {
        public int Id { get; set; }
    }
}