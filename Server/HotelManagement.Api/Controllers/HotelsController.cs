using HotelManagement.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelRepository hotelRepository;  // todo use repository injection in command/query layer

        public HotelsController(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }
        // GET: api/<HotelsController>
        [HttpGet]
        public async Task<ICollection<string>> Get()    //todo dto objects
        {
            //return hotelRepository.GetAll();
            return new List<string> { "123" };          // todo CQRS -> Commands -> mediator
        }
    }
}
