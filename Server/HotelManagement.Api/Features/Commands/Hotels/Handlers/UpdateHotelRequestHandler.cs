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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateHotelRequestHandler(IUnitOfWork unitOfWork, IMapper mapper) {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<HotelDto> Handle(UpdateHotelRequest request, CancellationToken cancellationToken)
        {
            var hotel = await _unitOfWork.Hotels.Get(request.Id);
            _mapper.Map(request.UpdateHotelDto, hotel);
            await _unitOfWork.Hotels.Update(hotel);
            await _unitOfWork.Complete();
            var result = _mapper.Map<HotelDto>(hotel);
            return result;
        }
    }
}
