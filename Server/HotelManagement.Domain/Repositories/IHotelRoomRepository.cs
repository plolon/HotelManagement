using HotelManagement.Domain.Models;

namespace HotelManagement.Domain.Repositories;

public interface IHotelRoomRepository : IGenericRepository<HotelRoom>
{
    Task<ICollection<HotelRoom>> GetHotelRoomsByHotelId(int hotelId);
}