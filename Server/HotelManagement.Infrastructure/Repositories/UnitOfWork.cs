using HotelManagement.Domain.Repositories;

namespace HotelManagement.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly HotelManagementDbContext _dbContext;

    public UnitOfWork(
        HotelManagementDbContext dbContext,
        IHotelRepository hotelRepository,
        IRoomTypeRepository roomTypeRepository)
    {
        _dbContext = dbContext;
        this.Hotels = hotelRepository;
        this.RoomTypes = roomTypeRepository;
    }

    public void Dispose()
    {
        _dbContext.Dispose();
        GC.SuppressFinalize(this);
    }

    public async Task Complete()
    {
        await _dbContext.SaveChangesAsync();
    }

    public IHotelRepository Hotels { get; }
    public IRoomTypeRepository RoomTypes { get; }
}