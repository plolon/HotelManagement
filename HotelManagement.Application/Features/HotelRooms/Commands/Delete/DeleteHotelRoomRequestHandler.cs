using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.HotelRooms.Commands
{
    public class
        DeleteHotelRequestHandler : ICommandHandler<DeleteHotelRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteHotelRequestHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteHotelRequest request,
            CancellationToken cancellationToken)
        {
            var res = await _unitOfWork.HotelRooms.Delete(request.Id);
            await _unitOfWork.Complete();
            return res;
        }
    }
}