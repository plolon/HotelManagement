using HotelManagement.Api.DTOs.RoomType;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Api.Controllers;

[Route("api/[controler]")]
[ApiController]
public class RoomTypesController : ControllerBase
{
    private readonly IMediator _mediator;

    public RoomTypesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<RoomTypesController>
    [HttpGet]
    public async Task<ICollection<RoomTypeDto>> Get()
    {
        throw new NotImplementedException();
    }
    
    // GET: api/<RoomTypesController>
    [HttpGet("{id}")]
    public async Task<RoomTypeDto> Get(int id)
    {
        throw new NotImplementedException();
    }
}