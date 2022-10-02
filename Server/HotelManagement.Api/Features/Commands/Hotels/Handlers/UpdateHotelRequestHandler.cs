using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Handlers
{
    public class UpdateHotelRequestHandler : IRequestHandler<UpdateHotelRequest, HotelDto>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public UpdateHotelRequestHandler(IHotelRepository hotelRepository, IMapper mapper) {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }

        public async Task<HotelDto> Handle(UpdateHotelRequest request, CancellationToken cancellationToken)
        {
            var hotel = await _hotelRepository.Get(request.Id);
            _mapper.Map(request.UpdateHotelDto, hotel);
            await _hotelRepository.Update(hotel);
            var result = _mapper.Map<HotelDto>(hotel);
            return result;
        }
    }
}
