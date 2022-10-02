using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Handlers
{
    public class CreateHotelRequestHandler : IRequestHandler<CreateHotelRequest, HotelDto>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;
        public CreateHotelRequestHandler(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        public async Task<HotelDto> Handle(CreateHotelRequest request, CancellationToken cancellationToken)
        {
            // TODO
            // some validation
            // maybe add custom response
            // add try catch and add errors to custom response
            // 2137
            var hotel = _mapper.Map<Hotel>(request.SaveHotelDto);
            hotel = await _hotelRepository.Add(hotel);
            return _mapper.Map<HotelDto>(hotel);
        }
    }
}
