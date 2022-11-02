using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Application.Features.Queries.HotelRooms.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Api.Controllers;

[Authorize(Roles = "any")]
[Route("api/[controller]")]
[ApiController]
public class HotelRoomsController : ControllerBase
{
    private readonly IMediator _mediator;

    public HotelRoomsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<HotelRoomsController>
    [HttpGet]
    public async Task<ICollection<HotelRoomDto>> Get() =>
        await _mediator.Send(new GetAllHotelRoomsRequest());

    // GET: api/<HotelRoomsController>/id
    [HttpGet("{id}")]
    public async Task<HotelRoomDto> Get(int id) =>
        await _mediator.Send(new GetHotelRoomByIdRequest { Id = id });
}