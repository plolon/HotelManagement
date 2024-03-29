﻿namespace HotelManagement.Application.DTOs.Booking
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int HotelRoomId { get; set; }
        public int StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}