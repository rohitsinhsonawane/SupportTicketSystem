namespace SupportTicketSystem.Api.Entities
{
    public class TicketComment
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public string Comment { get; set; }

        public int CreatedByUserId { get; set; } = 0;
        public User CreatedByUser { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsInternal { get; set; }

        public Ticket Ticket { get; set; }
    }
}
