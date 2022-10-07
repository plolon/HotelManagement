using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories;

public class HotelRoomRepository: GenericRepository<HotelRoom>, IHotelRoomRepository
{
    private readonly HotelManagementDbContext _dbContext;

    public HotelRoomRepository(HotelManagementDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ICollection<HotelRoom>> GetHotelRoomsByHotelId(int hotelId)
    {
        return await _dbContext.HotelRooms.Where(x => x.HotelId.Equals(hotelId)).ToListAsync();
    }
}