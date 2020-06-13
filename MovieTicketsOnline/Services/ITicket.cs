using MovieTicketsOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketsOnline.Services
{
   public interface ITicket
    {
        IEnumerable<Ticket> GetallTickets();
    }
}
