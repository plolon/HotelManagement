using Microsoft.AspNetCore.Mvc;
using MediatR;
using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Application.Features.Bookings.Commands.Delete;
using HotelManagement.Application.Features.Bookings.Commands.Requests;
using HotelManagement.Application.Features.Bookings.Commands.Update;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
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
        public async Task<BookingDto> Post(
            [FromBody] SaveBookingDto saveBookingDto) =>
            await _mediator.Send(
                new CreateBookingRequest
                    { SaveBookingDto = saveBookingDto });

        [HttpDelete]
        public async Task<bool> Delete(int id) =>
            await _mediator.Send(new DeleteHotelRequest { Id = id });

        [HttpPut]
        public async Task<BookingDto> Update(
            [FromBody] SaveBookingDto updateBookingDto, int id) =>
            await _mediator.Send(new UpdateBookingRequest
                { UpdateBookingDto = updateBookingDto, Id = id });
    }
}