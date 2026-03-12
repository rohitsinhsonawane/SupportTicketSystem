namespace SupportTicketSystem.Api.Entities
{
    public class TicketStatusHistoryDto
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public string OldStatus { get; set; }

        public string NewStatus { get; set; }

        public int UpdatedByUserId { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
