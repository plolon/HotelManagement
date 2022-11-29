using HotelManagement.Domain.Models;

namespace HotelManagement.Domain.Repositories
{
    public interface IHotelRepository :IGenericRepository<Hotel>
    {
        Task<Hotel> GetHotelWithRoomsById(int id);
    }
}
