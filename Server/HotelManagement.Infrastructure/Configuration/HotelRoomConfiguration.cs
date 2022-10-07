using HotelManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configuration
{
    public class HotelRoomConfiguration : IEntityTypeConfiguration<HotelRoom>
    {
        public void Configure(EntityTypeBuilder<HotelRoom> builder)
        {
            builder.HasData(new HotelRoom
            {
                Id = 1,
                Number = "001",
                RoomTypeId = 1,
                HotelId = 1,
            });
            builder.HasData(new HotelRoom
            {
                Id = 2,
                Number = "002",
                RoomTypeId = 3,
                HotelId = 1,
            });
            builder.HasData(new HotelRoom
            {
                Id = 3,
                Number = "003",
                RoomTypeId = 4,
                HotelId = 1,
            });
            builder.HasData(new HotelRoom
            {
                Id = 4,
                Number = "001",
                RoomTypeId = 2,
                HotelId = 2,
            });
        }
    }
}

/*
        public int Id { get; set; }
        public string Number { get; set; }
        public virtual RoomType RoomType { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
 */