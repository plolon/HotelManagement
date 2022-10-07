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
