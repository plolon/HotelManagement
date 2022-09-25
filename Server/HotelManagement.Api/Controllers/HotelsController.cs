using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepository;  // todo use repository injection in command/query layer
        private readonly IMapper _mapper;

        public HotelsController(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        // GET: api/<HotelsController>
        [HttpGet]
        public async Task<ICollection<HotelDto>> Get()    //todo dto objects
        {
            var hotels = await _hotelRepository.GetAll();
            return _mapper.Map<ICollection<HotelDto>>(hotels);         // todo CQRS -> Commands -> mediator
        }
    }
}
