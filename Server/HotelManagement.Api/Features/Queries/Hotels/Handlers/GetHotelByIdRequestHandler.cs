﻿using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Queries.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Queries.Hotels.Handlers
{
    public class GetHotelByIdRequestHandler : IRequestHandler<GetHotelByIdRequest, HotelDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetHotelByIdRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<HotelDto> Handle(GetHotelByIdRequest request, CancellationToken cancellationToken)
        {
            var hotel =  await _unitOfWork.Hotels.GetAll();
            return _mapper.Map<HotelDto>(hotel);
        }
    }
}
