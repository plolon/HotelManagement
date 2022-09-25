using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Queries.Hotels.Requests;
using HotelManagement.Domain.Repositories;
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
    }
}
