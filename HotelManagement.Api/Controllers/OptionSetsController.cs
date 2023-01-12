using HotelManagement.Application.DTOs.OptionSets;
using HotelManagement.Application.Features.OptionSets.Queries.Requests;
using HotelManagement.Application.Features.RoomTypes.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ILogger = Serilog.ILogger;

namespace HotelManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OptionSets : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger _logger;

    public OptionSets(IMediator mediator, ILogger logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet("roomtype")]
    public async Task<ICollection<RoomTypeDto>> GetRoomTypes()
    {
        _logger.Information("OptionSetsController GetRoomTypes GET start");
        return await _mediator.Send(new GetAllRoomTypesRequest());
    }

    [HttpGet("status")]
    public async Task<ICollection<StatusDto>> GetStatuses()
    {
        _logger.Information("OptionSetsController GetStatuses GET start");
        return await _mediator.Send(new GetAllStatusesRequest());
    }
}