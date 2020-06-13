using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketsOnline.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Movie_Name{ get; set; }
        public string Movie_Type { get; set; }
        public int SeatsLeft { get; set; }
        [DataType(DataType.Date)]
        public DateTime Showtime { get; set; }
        public string Movie_Image { get; set; }
    
        public ICollection<Ticket> Tickets { get; set; }
    }
}
