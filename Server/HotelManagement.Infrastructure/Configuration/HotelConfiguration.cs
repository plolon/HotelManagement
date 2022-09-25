using HotelManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(new Hotel
            {
                Id = 1,
                Name = "Hotel1",
                Country = "Germany",
                City = "Drezno",
                Street = "Danzigerstrasse 12"
            });
            builder.HasData(new Hotel
            {
                Id = 2,
                Name = "Hotel2",
                Country = "Poland",
                City = "Cracow",
                Street = "Gertrudy 14"
            });
        }
    }
}