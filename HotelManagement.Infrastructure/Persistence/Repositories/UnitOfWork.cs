﻿using HotelManagement.Domain.Repositories;

namespace HotelManagement.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelManagementDbContext _dbContext;

        public UnitOfWork(
            HotelManagementDbContext dbContext,
            IHotelRepository hotelRepository,
            IRoomTypeRepository roomTypeRepository,
            IHotelRoomRepository hotelRoomRepository,
            IBookingRepository bookingRepository)
        {
            _dbContext = dbContext;
            Hotels = hotelRepository;
            RoomTypes = roomTypeRepository;
            HotelRooms = hotelRoomRepository;
            Bookings = bookingRepository;
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
        public IHotelRoomRepository HotelRooms { get; }
        public IBookingRepository Bookings { get; }
    }
}
