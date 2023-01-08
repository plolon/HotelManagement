using HotelManagement.Application.Features.Commands.Hotels.Handlers;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.UnitTests.Mocs.Repositories;
using HotelManagement.Domain.Repositories;
using Moq;
using Xunit;

namespace HotelManagement.Application.UnitTests.HotelTests
{
    public class DeleteHotelHandlerTests
    {
        [Fact]
        public async Task Handle_OnValidInput_ReturnsTrue()
        {
            var unitOfWork = new Mock<IUnitOfWork>();

            unitOfWork.Setup(x => x.Hotels.Delete(It.IsAny<int>()))
                .Returns(async () => true);

            var handler =
                new DeleteHotelRequestHandler(unitOfWork.Object);

            var res = await handler.Handle(new DeleteHotelRequest
            {
                Id = 1
            }, CancellationToken.None);

            Assert.Equal(true, res);
        }

        [Fact]
        public async Task Handle_OnNoRecord_ReturnsFalse()
        {
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(x => x.Hotels.Delete(It.IsAny<int>()))
                .Returns(async () => false);
            var handler =
                new DeleteHotelRequestHandler(unitOfWork.Object);


            var res = await handler.Handle(new DeleteHotelRequest
            {
                Id = 1
            }, CancellationToken.None);
            Assert.Equal(false, res);
        }

        [Fact]
        public async Task Handle_OnNoInput_ThrowsValidationError()
        {
            var unitOfWork = new Mock<IUnitOfWork>();
            var handler = new DeleteHotelRequestHandler(unitOfWork.Object);

            // TODO: Change to exact exception type
            var res = Assert.ThrowsAsync<Exception>(async () =>
                await handler.Handle(
                    new DeleteHotelRequest(), CancellationToken.None));
            Assert.Contains("One or more errors occurred",
                res.Exception.Message);
        }

        [Fact]
        public async Task Handle_OnNegativeInt_ThrowsValidationError()
        {
            var unitOfWork = new Mock<IUnitOfWork>();
            var handler = new DeleteHotelRequestHandler(unitOfWork.Object);

            // TODO: Change to exact exception type
            var res = Assert.ThrowsAsync<Exception>(async () =>
                await handler.Handle(
                    new DeleteHotelRequest { Id = -1 },
                    CancellationToken.None));
            Assert.Contains("One or more errors occurred",
                res.Exception.Message);
        }
    }
}