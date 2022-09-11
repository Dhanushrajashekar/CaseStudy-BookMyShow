using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class Theater
    {
        [Key]
        public int TheaterId { get; set; }


        public string TheaterName { get; set; }


        public string City { get; set; }


        public string Password { get; set; }



        public string Email { get; set; }



        public string Address { get; set; }

        public int NoOfScreen { get; set; }
    }
}
