using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Infrastructure.Persistence.Common;
using MediatR;

namespace HotelManagement.Application.Features.Commands.Hotels.Handlers
{
    public class DeleteHotelRequestHandler : IRequestHandler<DeleteHotelRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteHotelRequestHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteHotelRequest request, CancellationToken cancellationToken)
        {
            bool result = await _unitOfWork.Hotels.Delete(request.Id);
            await _unitOfWork.Complete();
            return result;
        }
    }
}