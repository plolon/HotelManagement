using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Handlers
{
    public class UpdateHotelRequestHandler : IRequestHandler<UpdateHotelRequest, HotelDto>
    {
        public Task<HotelDto> Handle(UpdateHotelRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}