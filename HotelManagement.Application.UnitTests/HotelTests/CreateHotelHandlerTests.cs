using AutoMapper;
using FluentAssertions;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Commands.Hotels.Handlers;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.Profiles;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using Moq;
using Xunit;

namespace HotelManagement.Application.UnitTests.HotelTests
{
    public class CreateHotelHandlerTests
    {
        [Fact]
        public async Task Handle_OnValidInput_ReturnsHotelDto()
        {
            var setup = new SetupHotelUnitOfWork(new Mock<IUnitOfWork>());
            var mapperConfig = new MapperConfiguration(x =>
            {
                x.AddProfile<MappingProfile>();
            });
            var mapper = mapperConfig.CreateMapper();
            var handler =
                new CreateHotelHandler(setup.unitOfWork.Object, mapper);
            var savehoteldto = new SaveHotelDto
            {
                Name = "TEST",
                Address = new HotelAddressDto
                {
                    Country = "123",
                    City = "123",
                    Street = "123"
                }
            };
            var hotel = mapper.Map<Hotel>(savehoteldto);
            var hoteldto = mapper.Map<HotelDto>(hotel);
            var result = await handler.Handle(new CreateHotelRequest
            {
                SaveHotelDto = savehoteldto
            }, CancellationToken.None);
            result.Should().BeEquivalentTo(hoteldto);
        }

        [Fact]
        public async Task Handle_OnInvalidInput_ReturnValidationError()
        {
            var setup = new SetupHotelUnitOfWork(new Mock<IUnitOfWork>());
            var mapperConfig = new MapperConfiguration(x =>
            {
                x.AddProfile<MappingProfile>();
            });
            var mapper = mapperConfig.CreateMapper();

            var handler =
                new CreateHotelHandler(setup.unitOfWork.Object, mapper);
            var saveHodelDto = new SaveHotelDto
            {
                Name = "Invalid"
            };

            // TODO: Change to exact type :)
            var res = Assert.ThrowsAsync<Exception>(async () =>
                await handler.Handle(
                    new CreateHotelRequest
                        { SaveHotelDto = saveHodelDto },
                    CancellationToken.None));
            Assert.Contains("One or more errors occurred",
                res.Exception.Message);
        }
    }
}