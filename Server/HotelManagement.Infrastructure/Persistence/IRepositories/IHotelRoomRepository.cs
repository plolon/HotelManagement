using HotelManagement.Domain.Models;

namespace HotelManagement.Infrastructure.Persistence.IRepositories
{
    public interface IHotelRoomRepository : IGenericRepository<HotelRoom>
    {
        Task<ICollection<HotelRoom>> GetAllHotelRoomsWithDetails();
        Task<HotelRoom> GetHotelRoomWithDetailsById(int id);
    }
}