using System.ComponentModel.DataAnnotations.Schema;
using HotelManagement.Domain.Models.Common;

namespace HotelManagement.Domain.Models.OptionSets
{
    [Table("Roles")]
    public class Roles : BaseDomainEnumEntity
    {
        public Roles(UserRoleEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected Roles()
        {
        }

        public static implicit operator Roles(UserRoleEnum @enum) =>
            new Roles(@enum);

        public static implicit operator UserRoleEnum(Roles type) =>
            (UserRoleEnum)type.Id;
    }
}