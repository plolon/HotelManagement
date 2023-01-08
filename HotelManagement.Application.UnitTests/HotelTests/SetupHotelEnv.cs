using HotelManagement.Application.UnitTests.Mocs.Repositories;
using HotelManagement.Domain.Repositories;
using Moq;

namespace HotelManagement.Application.UnitTests.HotelTests
{
    public struct SetupHotelUnitOfWork
    {
        public SetupHotelUnitOfWork(Mock<IUnitOfWork> unitOfWork)
        {
            var repo = MockHotelRepository.GetRepository();
            unitOfWork.Setup(x => x.Hotels).Returns(repo.Object);

            this.unitOfWork = unitOfWork;
        }

        public Mock<IUnitOfWork> unitOfWork { get; }
    }
}