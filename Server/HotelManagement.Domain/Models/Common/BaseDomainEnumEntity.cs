using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Domain.Models.Common
{
    public class BaseDomainEnumEntity
    {
        public int Id { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
    }
}
