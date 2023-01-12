using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using HotelManagement.Domain.Models.Common;
using HotelManagement.Domain.Models.OptionSets;

namespace HotelManagement.Domain.Models
{
    [Table("Bookings")]
    public class Booking : BaseDomainEntity
    {
        //TODO: Relation with User / Client
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HotelRoomId { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set;
        }
    }
}