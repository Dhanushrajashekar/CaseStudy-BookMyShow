using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [StringLength(100)]
        public string MovieName { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Language { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public int Duretion { get; set; }

        public string Director { get; set; }

        public string Cast { get; set; }

        public string PosterUrl { get; set; }
    }
}
