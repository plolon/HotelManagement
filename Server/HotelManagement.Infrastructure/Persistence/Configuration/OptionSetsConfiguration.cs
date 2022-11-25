using HotelManagement.Domain.Models.OptionSets;
using HotelManagement.Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Persistence.Configuration
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.SeedTableWithEnumValues<RoomType, RoomTypeEnum>(@enum => @enum);
        }
    }
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.SeedTableWithEnumValues<Status, StatusEnum>(@enum => @enum);
        }
    }
}
