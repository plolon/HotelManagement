﻿using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.Features.Queries.Hotels.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ILogger = Serilog.ILogger;

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public HotelsController(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        
        // GET: api/<HotelsController>
        //[Authorize(Roles =
        //    "SuperAdministrator, Administrator, Premium, Gold, Silver, Basic")]
        [HttpGet]
        public async Task<ICollection<HotelDto>> Get()
        { 
            _logger.Information("HotelsController GET start");
            _logger.Information("{}");
            return await _mediator.Send(new GetAllHotelsRequest());
        }
        
        // GET: api/<HotelsController>/id
        //[Authorize(Roles =
        //    "SuperAdministrator, Administrator, Premium, Gold, Silver, Basic")]
        [HttpGet("{id}")]
        public async Task<HotelDto> Get(int id) => 
            await _mediator.Send(new GetHotelByIdRequest { Id = id });
        
        // POST: api/<HotelsController>
        //[Authorize(Roles = "Administrator, SuperAdministrator")] // DEV
        [HttpPost]
        public async Task<HotelDto> Post([FromBody] SaveHotelDto saveHotelDto)
        {
            return await _mediator.Send(new CreateHotelRequest { SaveHotelDto = saveHotelDto });
        }

        // PUT: api/<HotelsController>/id
        //[Authorize(Roles = "Administrator, SuperAdministrator")]
        [HttpPut("{id}")]
        public async Task<HotelDto> Update([FromBody] SaveHotelDto updateHotelDto, int id) => 
            await _mediator.Send(new UpdateHotelRequest { UpdateHotelDto = updateHotelDto, Id = id });
        
        // DELETE: api/<HotelsController>/id
        //[Authorize(Roles = "SuperAdministrator")]
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id) => 
            await _mediator.Send(new DeleteHotelRequest { Id = id });
    }
}
