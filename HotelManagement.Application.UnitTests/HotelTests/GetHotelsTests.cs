using AutoMapper;
using FluentAssertions;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Hotels.Queries.Handlers;
using HotelManagement.Application.Features.Hotels.Queries.Requests;
using HotelManagement.Application.Profiles;
using HotelManagement.Application.UnitTests.Mocs.Repositories;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using Moq;
using Xunit;

namespace HotelManagement.Application.UnitTests.HotelTests
{
    public class GetHotelsTests
    {
        [Fact]
        public async Task Handle_GetAll_ReturnsListOfHotels()
        {
            var hotels = new List<Hotel>
            {
                new Hotel
                {
                    City = "Warschau",
                    Country = "Polen",
                    Id = 1,
                    Name = "Jugend",
                    Street = "Mustache",
                    DateCreated = new DateTime(1939, 09, 01),
                    DateModified = new DateTime(1945, 09, 02)
                },
                new Hotel
                {
                    City = "Wollstein",
                    Country = "Polen",
                    Id = 2,
                    Name = "Volks",
                    Street = "Wagen",
                    DateCreated = new DateTime(1937, 05, 28),
                    DateModified = new DateTime(1945, 09, 02)
                }
            };

            var hotelDtos = new List<HotelDto>
            {
                new HotelDto
                {
                    DateCreated = new DateTime(1939, 09, 01),
                    DateModified = new DateTime(1945, 09, 02),
                    Id = 1,
                    Name = "Jugend",
                    Address = new HotelAddressDto
                    {
                        City = "Warschau",
                        Country = "Polen",
                        Street = "Mustache",
                    }
                },
                new HotelDto
                {
                    DateCreated = new DateTime(1937, 05, 28),
                    DateModified = new DateTime(1945, 09, 02),
                    Id = 2,
                    Name = "Volks",
                    Address = new HotelAddressDto
                    {
                        City = "Wollstein",
                        Country = "Polen",
                        Street = "Wagen",
                    }
                },
            };

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(x => x.Hotels.GetAll()).ReturnsAsync(hotels);

            var mapperConfig = new MapperConfiguration(x =>
            {
                x.AddProfile<MappingProfile>();
            });
            var mapper = mapperConfig.CreateMapper();

            var handler =
                new GetAllHotelsRequestHandler(unitOfWork.Object, mapper);

            var res = await handler.Handle(new GetAllHotelsRequest(),
                CancellationToken.None);

            res.Should().NotBeEmpty().Equals(hotelDtos);
        }
    }
}