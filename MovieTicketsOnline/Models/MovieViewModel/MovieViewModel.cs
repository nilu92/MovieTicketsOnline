using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketsOnline.Models.MovieViewModel
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateofShow { get; set; }
        public string MoviePicture { get; set; }
        public int AvailableSeats {get;set;}
    }
}
