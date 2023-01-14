using Microsoft.AspNetCore.Mvc;
using MediatR;
using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Application.Features.Bookings.Commands.Delete;
using HotelManagement.Application.Features.Bookings.Commands.Requests;
using HotelManagement.Application.Features.Bookings.Commands.Update;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.Features.Queries.Bookings.Requests;
using Microsoft.AspNetCore.Authorization;
using ILogger = Serilog.ILogger;

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ISender _mediator;
        private readonly ILogger _logger;

        public BookingController(ISender mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // GET: <BookingController>
        [HttpGet]
        [Authorize(Roles = "Administrator,Employee,Guest")]
        public async Task<ICollection<BookingDto>> Get()
        {
            _logger.Information("BookingsController GET start");
            return await _mediator.Send(new GetAllBookingsRequest());
        }

        [HttpGet("{id}")]
        public async Task<BookingDto> GetById(int id)
        {
            _logger.Information("BookingsController GET by id start");
            return await _mediator.Send(
                new GetBookingByIdRequest { Id = id });
        }

        // POST: <BookingController>
        [HttpPost]
        public async Task<BookingDto> Post(
            [FromBody] SaveBookingDto saveBookingDto)
        {
            _logger.Information("BookingsController POST start");
            return await _mediator.Send(
                new CreateBookingRequest
                    { SaveBookingDto = saveBookingDto });
        }

        [Authorize(Roles = "Administrator,Employee,Guest")]
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            _logger.Information("BookingsController DELETE start");
            return await _mediator.Send(new DeleteBookingRequest { Id = id });
        }

        [Authorize(Roles = "Administrator,Employee,Guest")]
        [HttpPut("{id}")]
        public async Task<BookingDto> Update(
            [FromBody] SaveBookingDto updateBookingDto, int id)
        {
            _logger.Information("BookingsController PUT start");
            return await _mediator.Send(new UpdateBookingRequest
                { UpdateBookingDto = updateBookingDto, Id = id });
        }
    }
}