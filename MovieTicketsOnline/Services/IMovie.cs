using MovieTicketsOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketsOnline.Services
{
   public interface IMovie
    {
        void AddMovie(Movie movie);
        IEnumerable<Movie> GetAllMovies();
        void Delete(int id);
        void Edit(Movie movie);
    }
}
