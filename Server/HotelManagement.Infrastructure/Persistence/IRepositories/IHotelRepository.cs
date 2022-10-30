using HotelManagement.Domain.Models;
using HotelManagement.Infrastructure.Persistence.Common;

namespace HotelManagement.Infrastructure.Persistence.IRepositories
{
    public interface IHotelRepository :IGenericRepository<Hotel>
    {
        Task<Hotel> GetHotelWithRoomsById(int id);
    }
}
