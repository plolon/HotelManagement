using HotelManagement.Infrastructure.Persistence.IRepositories;

namespace HotelManagement.Infrastructure.Persistence.Common
{
    public interface IUnitOfWork :IDisposable
    {
        Task Complete();
    
        IHotelRepository Hotels { get; }
        IRoomTypeRepository RoomTypes { get; }
        IHotelRoomRepository HotelRooms { get; }
    }   
}