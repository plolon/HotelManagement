using HotelManagement.Application.Abstraction;
using HotelManagement.Application.DTOs.Booking;
using MediatR;

namespace HotelManagement.Application.Features.Bookings.Commands.Update
{
    public class UpdateBookingRequest: ICommand<BookingDto>
    {
        public SaveBookingDto UpdateBookingDto { get; set; }
        public int Id { get; set; }
    }
}