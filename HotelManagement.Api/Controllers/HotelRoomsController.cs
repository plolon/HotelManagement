﻿using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Application.Features.HotelRooms.Commands.Create;
using HotelManagement.Application.Features.HotelRooms.Commands.Delete;
using HotelManagement.Application.Features.HotelRooms.Commands.Update;
using HotelManagement.Application.Features.Queries.HotelRooms.Requests;
using HotelManagement.Application.Features.RoomTypes.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ILogger = Serilog.ILogger;

namespace HotelManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HotelRoomsController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly ILogger _logger;

    public HotelRoomsController(ISender mediator, ILogger logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    // GET: api/<HotelRoomsController>
    [HttpGet]
    public async Task<ICollection<HotelRoomDto>> Get()
    {
        _logger.Information("HotelRoomsController GET start");
        return await _mediator.Send(new GetAllHotelRoomsRequest());
    }

    // GET: api/<HotelRoomsController>/id

    [HttpGet("{id}")]
    public async Task<HotelRoomDto> Get(int id)
    {
        _logger.Information("HotelRoomsController GET by ID start");
        return await _mediator.Send(new GetHotelRoomByIdRequest { Id = id });
    }

    // POST: api/<RoomTypesController>
    [Authorize(Roles = "Administrator,Employee")]
    [HttpPost]
    public async Task<HotelRoomDto>
        Post([FromBody] CreateHotelRoomDto createHotelRoomDto)
    {
        _logger.Information("HotelRoomsController POST start");
        return await _mediator.Send(new CreateHotelRoomRequest
            { CreateHotelRoomDto = createHotelRoomDto });
    }

    [Authorize(Roles = "Administrator,Employee")]
    [HttpPut("{id}")]
    public async Task<HotelRoomDto> Update(
        [FromBody] CreateHotelRoomDto createHotelRoomDto, int id)
    {
        _logger.Information("HotelRoomsController PUT start");
        return await _mediator.Send(new UpdateHotelRoomRequest
            { UpdateHotelRoomDto = createHotelRoomDto, Id = id });
    }

    [Authorize(Roles = "Administrator,Employee")]
    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        _logger.Information("HotelRoomsController DELETE start");
        return await _mediator.Send(new DeleteHotelRoomRequest { Id = id });
    }
}