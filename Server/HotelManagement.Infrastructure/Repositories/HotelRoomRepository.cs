using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class HotelRoomRepository : GenericRepository<HotelRoom>, IHotelRoomRepository
    {
        private readonly HotelManagementDbContext _dbContext;

        public HotelRoomRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ICollection<HotelRoom>> GetAllHotelRoomsWithDetails()
        {
            return await _dbContext.HotelRooms
                .Include(x => x.RoomType)
                .ToListAsync();
        }

        public async Task<HotelRoom> GetHotelRoomWithDetailsById(int id)
        {
            return await _dbContext.HotelRooms
                .Where(x => x.Id.Equals(id))
                .Include(x => x.RoomType)
                .FirstOrDefaultAsync();
        }
    }
}