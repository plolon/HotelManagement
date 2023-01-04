using Microsoft.AspNetCore.Mvc;
using MediatR;
using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Application.Features.Bookings.Commands.Requests;
using HotelManagement.Application.Features.Queries.Bookings.Requests;
using ILogger = Serilog.ILogger;

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public BookingController(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // GET: <BookingController>
        [HttpGet]
        public async Task<BookingDto> Get()
        {
            _logger.Information("BookingsController GET start");
            return await _mediator.Send(new GetAllBookingsRequest());
        }

        // POST: <BookingController>
        [HttpPost]
        public async Task<BookingDto> Post([FromBody] BookingDto bookingDto) =>
            await _mediator.Send(
                new CreateBookingRequest { BookingDto = bookingDto });
    }
}