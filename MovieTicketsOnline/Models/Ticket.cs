using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketsOnline.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public string Seatno { get; set; }
        public string UserId { get; set; }
        public DateTime TicketsDate { get; set; }
        public int Amount { get; set; }
        public int MovieID { get; set; }
       
        [ForeignKey("MovieID")]
        public virtual Movie Movie { get; set; }
    }
}
