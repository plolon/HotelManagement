using AutoMapper;
using HotelManagement.Application.DTOs.Booking;
using MediatR;
using HotelManagement.Domain.Repositories;
using HotelManagement.Application.Features.Queries.Bookings.Requests;

namespace HotelManagement.Application.Features.Queries.Hotels.Requests
{
    public class GetBookingById : IRequest<BookingDto>
    {
        public int Id { get; set; }
    }
}
