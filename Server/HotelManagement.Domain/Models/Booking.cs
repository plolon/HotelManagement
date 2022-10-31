using HotelManagement.Domain.Models.Common;
using HotelManagement.Domain.Models.OptionSets;

namespace HotelManagement.Domain.Models
{
    public class Booking : BaseDomainEntity
    {
        //TODO: Relation with User / Client
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HotelId { get; set; }
        public int HotelRoomId { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
    }
}