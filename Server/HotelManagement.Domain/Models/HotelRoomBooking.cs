using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Domain.Models
{
    [Table("HotelRoomBookings")]
    public class HotelRoomBooking
    {
        public int HotelRoomId { get; set; }
        public int BookingId { get; set; }
        public virtual Booking? Booking { get; set; } = null!;
        public virtual HotelRoom? HotelRoom { get; set; } = null!;
    }
}