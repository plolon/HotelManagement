using HotelManagement.Domain.Models;

namespace HotelManagement.Infrastructure.Persistence.IRepositories
{
    public interface IHotelRepository :IGenericRepository<Hotel>
    {
        Task<Hotel> GetHotelWithRoomsById(int id);
    }
}
