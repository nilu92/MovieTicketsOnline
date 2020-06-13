using Microsoft.EntityFrameworkCore;
using MovieTicketsOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketsOnline.Data
{
    public class MovieTicketsDbContext : DbContext
    {
        public MovieTicketsDbContext(DbContextOptions<MovieTicketsDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies  { get; set; }
        public DbSet<Ticket>  Tickets{ get; set; }

    }
}
