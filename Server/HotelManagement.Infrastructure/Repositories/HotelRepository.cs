using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        private readonly HotelManagementDbContext _dbContext;
        public HotelRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Hotel> GetHotelWithRoomsById(int id)
        {
            return await _dbContext.Hotels
                .Include(x => x.HotelRooms)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
