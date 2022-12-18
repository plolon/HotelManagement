using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Application.Features.HotelRooms.Queries.Handlers;
using HotelManagement.Application.Features.RoomTypes.Queries.Requests;
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
        => await _mediator.Send(new GetAllRoomTypesRequest());

    // GET: api/<RoomTypesController>
    [HttpGet("{id}")]
    public async Task<RoomTypeDto> Get(int id) 
        => await _mediator.Send(new GetRoomTypeRequest{Id = id});
}