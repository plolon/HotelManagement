using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Infrastructure.Repositories
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
    }
}
