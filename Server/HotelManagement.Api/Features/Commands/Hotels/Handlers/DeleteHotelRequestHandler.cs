using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Handlers
{
    public class DeleteHotelRequestHandler : IRequestHandler<DeleteHotelRequest, Unit>
    {
        public Task<Unit> Handle(DeleteHotelRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}