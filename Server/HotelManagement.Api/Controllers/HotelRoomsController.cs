using HotelManagement.Api.DTOs.HotelRoom;
using HotelManagement.Api.Features.Queries.HotelRooms.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Api.Controllers;

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