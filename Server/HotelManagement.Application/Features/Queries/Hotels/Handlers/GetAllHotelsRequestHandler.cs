﻿using AutoMapper;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Queries.Hotels.Requests;
using HotelManagement.Infrastructure.Persistence;
using MediatR;

namespace HotelManagement.Application.Features.Queries.Hotels.Handlers
{
    public class GetAllHotelsRequestHandler : IRequestHandler<GetAllHotelsRequest, ICollection<HotelDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllHotelsRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ICollection<HotelDto>> Handle(GetAllHotelsRequest request, CancellationToken cancellationToken)
        {
            var hotels = await _unitOfWork.Hotels.GetAll();
            return _mapper.Map<ICollection<HotelDto>>(hotels);
        }
    }
}
