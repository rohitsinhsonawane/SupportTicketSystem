namespace SupportTicketSystem.Api.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string Role { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<Ticket> CreatedTickets { get; set; }

        public ICollection<Ticket> AssignedTickets { get; set; }
    }
}
