using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Application.Features.HotelRooms.Queries.Handlers;
using HotelManagement.Application.Features.RoomTypes.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ILogger = Serilog.ILogger;

namespace HotelManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomTypesController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger _logger;

    public RoomTypesController(IMediator mediator, ILogger logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    // GET: api/<RoomTypesController>
    [HttpGet]
    public async Task<ICollection<RoomTypeDto>> Get()
    {
        _logger.Information("RoomTypesController GET start");
        return await _mediator.Send(new GetAllRoomTypesRequest());
    }

    // GET: api/<RoomTypesController>
    [HttpGet("{id}")]
    public async Task<RoomTypeDto> Get(int id)
    {
        _logger.Information("RoomTypesController GET by id start");
        return await _mediator.Send(new GetRoomTypeRequest { Id = id });
    }
}