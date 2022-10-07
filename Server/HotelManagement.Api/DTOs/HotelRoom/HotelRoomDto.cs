﻿using HotelManagement.Api.DTOs.RoomType;

namespace HotelManagement.Api.DTOs.HotelRoom
{
    public class HotelRoomDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public virtual RoomTypeDto RoomType { get; set; }
        public int HotelId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}