﻿namespace HotelManagement.Domain.Repositories;

public interface IUnitOfWork :IDisposable
{
    Task Complete();
    
    IHotelRepository Hotels { get; }
    IRoomTypeRepository RoomTypes { get; }
}