using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookMyShow.Models;

namespace BookMyShow.Data
{
    public class BookMyShowContext : DbContext
    {
        public BookMyShowContext (DbContextOptions<BookMyShowContext> options)
            : base(options)
        {
        }

        public DbSet<BookMyShow.Models.Booking> Booking { get; set; } = default!;

        public DbSet<BookMyShow.Models.Movie>? Movie { get; set; }

        public DbSet<BookMyShow.Models.Show>? Show { get; set; }

        public DbSet<BookMyShow.Models.Theater>? Theater { get; set; }

        public DbSet<BookMyShow.Models.User>? User { get; set; }
    }
}
