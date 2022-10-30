using AutoMapper;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Infrastructure.Persistence.Common;
using MediatR;

namespace HotelManagement.Application.Features.Commands.Hotels.Handlers
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
