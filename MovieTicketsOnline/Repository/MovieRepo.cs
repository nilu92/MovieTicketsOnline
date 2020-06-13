using MovieTicketsOnline.Data;
using MovieTicketsOnline.Models;
using MovieTicketsOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketsOnline.Repository
{
    public class MovieRepo : IMovie
    {
        public MovieTicketsDbContext context { get; set; }
        public MovieRepo(MovieTicketsDbContext _context)
        {
            context = _context;

        }

        public void AddMovie(Movie movie)
        {
            context.Add(movie);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var movie = context.Movies.SingleOrDefault(m => m.ID == id);
            context.Movies.Remove(movie);
            context.SaveChanges();
        }

        public void Edit(Movie movie)
        {
            context.Update(movie);
            context.SaveChanges();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = context.Movies.ToList();
            return movies;
        }
    }
}
