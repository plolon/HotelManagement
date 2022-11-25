using HotelManagement.Domain.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Persistence.Extensions
{
    public static class EnumTableExtensions
    {
        public static void SeedTableWithEnumValues<T, TEnum>(this EntityTypeBuilder<T> builder, Func<TEnum, T> converter)
            where T : BaseDomainEnumEntity => Enum.GetValues(typeof(TEnum))
            .Cast<object>()
            .Select(value => converter((TEnum)value))
            .ToList()
            .ForEach(instance => builder.HasData(instance));
    }
}
