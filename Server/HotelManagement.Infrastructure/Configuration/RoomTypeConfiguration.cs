using HotelManagement.Domain.Models.OptionSets;
using HotelManagement.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configuration
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.SeedTableWithEnumValues<RoomType, RoomTypeEnum>(@enum => @enum);
        }
    }
}
