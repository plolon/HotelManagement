using HotelManagement.Domain.Models.Common;

namespace HotelManagement.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetGenericRepository<T>() where T: BaseDomainEnumEntity;
        Task Complete();

        IHotelRepository Hotels { get; }
        IHotelRoomRepository HotelRooms { get; }
        IBookingRepository Bookings { get; }

    }
}
