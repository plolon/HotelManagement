using System.ComponentModel.DataAnnotations.Schema;
using HotelManagement.Domain.Models.Common;

namespace HotelManagement.Domain.Models.OptionSets
{
    [Table("Statuses")]
    public class Status : BaseDomainEnumEntity
    {
        public Status(StatusEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected Status()
        {
        } //For EF

        public static implicit operator Status(StatusEnum @enum) => new Status(@enum);

        public static implicit operator StatusEnum(Status type) => (StatusEnum)type.Id;
    }
}