using HotelManagement.Domain.Repositories;
using HotelManagement.Domain.Models;
using Moq;

namespace HotelManagement.Application.UnitTests.Mocs.Repositories
{
    public static class MockHotelRepository
    {
        public static Mock<IHotelRepository> GetRepository()
        {
            var mockRepo = new Mock<IHotelRepository>();

            var entities = new List<Hotel>
            {
                new Hotel
                {
                    Id = 1,
                    Name = "TEST1"
                },
                new Hotel
                {
                    Id = 2,
                    Name = "TEST2"
                }
            };

            mockRepo.Setup(x => x.GetAll()).ReturnsAsync(entities);
            mockRepo.Setup(x => x.Get(It.IsAny<int>())).ReturnsAsync((int id) =>
            {
                return entities.FirstOrDefault(x => x.Id.Equals(id));
            });
            mockRepo.Setup(x => x.Add(It.IsAny<Hotel>())).ReturnsAsync((Hotel hotel) =>
            {
                entities.Add(hotel);
                return hotel;
            });
            return mockRepo;
        }
    }
}