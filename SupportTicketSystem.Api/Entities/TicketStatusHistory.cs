namespace SupportTicketSystem.Api.Entities
{
    public class TicketStatusHistory
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public string OldStatus { get; set; }

        public string NewStatus { get; set; }

        public int UpdatedByUserId { get; set; }
        public User UpdatedByUser { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Ticket Ticket { get; set; }
    }
}
