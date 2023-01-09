using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.Features.HotelRooms.Commands.Delete;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.HotelRooms.Commands
{
    public class
        DeleteHotelRequestHandler : ICommandHandler<DeleteHotelRoomRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteHotelRequestHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteHotelRoomRequest request,
            CancellationToken cancellationToken)
        {
            var res = await _unitOfWork.HotelRooms.Delete(request.Id);
            await _unitOfWork.Complete();
            return res;
        }
    }
}