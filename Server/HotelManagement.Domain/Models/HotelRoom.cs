using HotelManagement.Domain.Models.Common;
using HotelManagement.Domain.Models.OptionSets;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Domain.Models
{
    [Table("HotelRooms")]
    public class HotelRoom :BaseDomainEntity
    {
        [StringLength(128)]
        public string Number { get; set; }
        public virtual RoomType RoomType { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
