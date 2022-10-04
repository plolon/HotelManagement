using HotelManagement.Api.DTOs.RoomType;
using HotelManagement.Api.Features.Queries.RoomTypes.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Api.Controllers;

[Route("api/[controller]")]
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
        return await _mediator.Send(new GetAllRoomTypesRequest());
    }
    
    // GET: api/<RoomTypesController>
    [HttpGet("{id}")]
    public async Task<RoomTypeDto> Get(int id)
    {
        return await _mediator.Send(new GetRoomTypeRequest{Id = id});
    }
}