﻿using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public int UserId { get; set; }

        public int? ShowId { get; set; }

        public int TotalTickets { get; set; }

        public int SeatNo1 { get; set; }

        public int SeatNo2 { get; set; }

        public int SeatNo3 { get; set; }

        public double TotalCost { get; set; }
        public DateTime Date { get; set; }

        public string MovieName { get; set; }

        public string TheaterName { get; set; }

        public string UserName { get; set; }

        public string City { get; set; }

        public int ScreenNo { get; set; }

        public virtual Show Show { get; set; }

        public virtual User User { get; set; }
    }
}
