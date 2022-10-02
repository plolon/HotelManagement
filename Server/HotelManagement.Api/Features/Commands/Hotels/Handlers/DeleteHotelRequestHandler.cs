using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Handlers
{
    public class DeleteHotelRequestHandler : IRequestHandler<DeleteHotelRequest, bool>
    {
        private readonly IHotelRepository _hotelRepository;

        public DeleteHotelRequestHandler(IHotelRepository hotelRepository
        )
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<bool> Handle(DeleteHotelRequest request, CancellationToken cancellationToken)
        {
            return await _hotelRepository.Delete(request.Id);
        }
    }
}