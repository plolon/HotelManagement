namespace HotelManagement.Application.DTOs.Booking
{
    public class SaveBookingDto
    {
        //TODO: UserId
        public int HotelRoomId { get; set; }
        public int StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}