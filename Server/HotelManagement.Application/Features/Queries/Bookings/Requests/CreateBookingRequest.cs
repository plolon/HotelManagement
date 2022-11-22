using MediatR;
using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Application.DTOs.RoomType;

namespace HotelManagement.Application.Features.Queries.Bookings.Requests
{
    public class CreateBookingRequest : IRequest<ICollection<BookingDto>>
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public RoomTypeDto RoomType { get; set; }
        public int HotelId { get; set; }
    }
}