namespace BookMyShow.Models
{
    public class Show
    {
        public int ShowId { get; set; }

        public int MovieId { get; set; }

        public int TheaterId { get; set; }

        public string MovieName { get; set; }

        public string TheaterName { get; set; }

        public string City { get; set; }

        public int ScreenNo { get; set; }


        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public double Price { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Theater Theater { get; set; }

    }
}
