using MovieTicketsOnline.Data;
using MovieTicketsOnline.Models;
using MovieTicketsOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketsOnline.Repository
{
    public class TicketRepo : ITicket
    {
        private readonly MovieTicketsDbContext context;
        public TicketRepo(MovieTicketsDbContext _context)
        {
            context = _context;
        }
        public IEnumerable<Ticket> GetallTickets()
        {
           var tickets= context.Tickets.ToList();
            return tickets;
        }
    }
}
