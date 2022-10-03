using HotelManagement.Domain.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Domain.Models.OptionSets
{
    [Table("RoomTypes")]
    public class RoomType : BaseDomainEnumEntity
    {
        public RoomType(RoomTypeEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }
        protected RoomType() { } //For EF

        public static implicit operator RoomType(RoomTypeEnum @enum) => new RoomType(@enum);

        public static implicit operator RoomTypeEnum(RoomType type) => (RoomTypeEnum)type.Id;
    }
}
