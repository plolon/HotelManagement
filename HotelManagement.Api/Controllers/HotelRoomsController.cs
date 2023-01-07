using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Application.Features.HotelRooms.Commands.Create;
using HotelManagement.Application.Features.Queries.HotelRooms.Requests;
using HotelManagement.Application.Features.RoomTypes.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles =
        "Administrator,Employee,Guest")]
    [HttpGet]
    public async Task<ICollection<HotelRoomDto>> Get() =>
        await _mediator.Send(new GetAllHotelRoomsRequest());

    // GET: api/<HotelRoomsController>/id
    [Authorize(Roles =
        "Administrator,Employee,Guest")]
    [HttpGet("{id}")]
    public async Task<HotelRoomDto> Get(int id) =>
        await _mediator.Send(new GetHotelRoomByIdRequest { Id = id });

    // POST: api/<RoomTypesController>
    [Authorize(Roles = "Administrator")]
    [HttpPost]
    public async Task<HotelRoomDto>
        Post(CreateHotelRoomDto createHotelRoomDto) =>
        await _mediator.Send(new CreateHotelRoomRequest
            { CreateHotelRoomDto = createHotelRoomDto });
}