using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.Features.Queries.Hotels.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ICollection<HotelDto>> Get() => 
            await _mediator.Send(new GetAllHotelsRequest());
        
        // GET: api/<HotelsController>/id
        [HttpGet("{id}")]
        public async Task<HotelDto> Get(int id) => 
            await _mediator.Send(new GetHotelByIdRequest { Id = id });
        
        // POST: api/<HotelsController>
        [HttpPost]
        public async Task<HotelDto> Post([FromBody] SaveHotelDto saveHotelDto) => 
            await _mediator.Send(new CreateHotelRequest { SaveHotelDto = saveHotelDto });

        // PUT: api/<HotelsController>/id
        [HttpPut("{id}")]
        public async Task<HotelDto> Update([FromBody] SaveHotelDto updateHotelDto, int id) => 
            await _mediator.Send(new UpdateHotelRequest { UpdateHotelDto = updateHotelDto, Id = id });
        
        // DELETE: api/<HotelsController>/id
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id) => 
            await _mediator.Send(new DeleteHotelRequest { Id = id });
    }
}
