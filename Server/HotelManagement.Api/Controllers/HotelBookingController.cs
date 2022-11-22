using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Application.Features.Queries.HotelRooms.Requests;

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        private readonly ISender _sender;

        public BookingController(ISender sender)
        {
            _sender = sender;
        }

    // GET: <BookingController>
    [HttpGet]
    public async Task<ICollection<BookingDto>> Get() => 
        await _sender.Send(new GetAllBookings());
    
    [HttpPost]
    public async Task<ICollection<BookingDto>> Post() => 
        await _sender.Send(new CreateBooking()); 
    }
}