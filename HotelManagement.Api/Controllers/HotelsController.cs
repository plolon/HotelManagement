using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.Features.Hotels.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ILogger = Serilog.ILogger;

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public HotelsController(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // GET: api/<HotelsController>
        [Authorize(Roles = "Administrator,Employee,Guest")]
        [HttpGet]
        public async Task<ICollection<HotelDto>> Get()
        {
            _logger.Information("HotelsController GET start");
            _logger.Information("{}");
            return await _mediator.Send(new GetAllHotelsRequest());
        }

        // GET: api/<HotelsController>/id
        [HttpGet("{id}")]
        public async Task<HotelDto> Get(int id) =>
            await _mediator.Send(new GetHotelByIdRequest { Id = id });

        // POST: api/<HotelsController>
        [Authorize(Roles = "Administrator,Employee,Guest")] // DEV
        [HttpPost]
        public async Task<HotelDto> Post([FromBody] SaveHotelDto saveHotelDto)
        {
            _logger.Information("HotelsController POST start");
            return await _mediator.Send(new CreateHotelRequest
                { SaveHotelDto = saveHotelDto });
        }

        // PUT: api/<HotelsController>/id
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<HotelDto> Update(
            [FromBody] SaveHotelDto updateHotelDto, int id)
        {
            _logger.Information("HotelsController PUT start");
            return await _mediator.Send(new UpdateHotelRequest
                { UpdateHotelDto = updateHotelDto, Id = id });
        }

        // DELETE: api/<HotelsController>/id
        [Authorize(Roles = "Administrator,Employee,Guest")]
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            _logger.Information("HotelsController DELETE start");
            return await _mediator.Send(new DeleteHotelRequest { Id = id });
        }
    }
}