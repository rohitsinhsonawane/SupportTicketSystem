using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Api.Entities;


namespace SupportTicketSystem.Api.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TicketComment> TicketComments { get; set; }
        public DbSet<TicketStatusHistory> TicketStatusHistories { get; set; }
    }
}
