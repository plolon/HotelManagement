using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Extensions;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.Validators;
using HotelManagement.Domain.Exceptions;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.Commands.Hotels.Handlers
{
    public class CreateHotelHandler : ICommandHandler<CreateHotelRequest, HotelDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateHotelHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<HotelDto> Handle(CreateHotelRequest request, CancellationToken cancellationToken)
        {
            var hotel = _mapper.Map<Hotel>(request.SaveHotelDto);
            hotel = await _unitOfWork.Hotels.Add(hotel);
            await _unitOfWork.Complete();
            return _mapper.Map<HotelDto>(hotel);
        }
    }
}