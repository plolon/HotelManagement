using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Commands.Hotels.Requests;
using HotelManagement.Api.Features.Queries.Hotels.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HotelsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<HotelsController>
        [HttpGet]
        public async Task<ICollection<HotelDto>> Get()
        {
            var hotels = await _mediator.Send(new GetAllHotelsRequest());
            return hotels;
        }
        // GET: api/<HotelsController>/id
        [HttpGet("{id}")]
        public async Task<HotelDto> Get(int id)
        {
            var hotel = await _mediator.Send(new GetHotelByIdRequest { Id = id });
            return hotel;
        }
        // POST: api/<HotelsController>
        [HttpPost]
        public async Task<HotelDto> Post([FromBody] SaveHotelDto saveHotelDto)
        {
            var hotel = await _mediator.Send(new CreateHotelRequest { SaveHotelDto = saveHotelDto });
            return hotel;
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _mediator.Send(new DeleteHotelRequest { Id = id });
        }
    }
}
