using HotelManagement.Application.Abstraction;
using HotelManagement.Application.DTOs.Booking;

namespace HotelManagement.Application.Features.Bookings.Commands.Requests
{
    public class CreateBookingRequest : ICommand<BookingDto>
    {
        public SaveBookingDto SaveBookingDto { get; set; }
    }
}