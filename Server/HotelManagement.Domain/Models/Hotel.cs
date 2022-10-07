using System.Collections.ObjectModel;
using HotelManagement.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Domain.Models
{
    [Table("Hotels")]
    public class Hotel : BaseDomainEntity
    {
        [StringLength(128)]
        public string Name { get; set; }
        [StringLength(128)]
        public string Country { get; set; }
        [StringLength(128)]
        public string City { get; set; }
        [StringLength(128)]
        public string Street { get; set; }

        public virtual ICollection<HotelRoom> HotelRooms { get; set; }

        public Hotel()
        {
            HotelRooms = new Collection<HotelRoom>();
        }
    }
}
