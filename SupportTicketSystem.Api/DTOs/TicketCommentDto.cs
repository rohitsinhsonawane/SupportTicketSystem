namespace SupportTicketSystem.Api.Entities
{
    public class TicketCommentDto
    {
        public int Id { get; set; }
        public int TicketId { get; set; }

        public string Comment { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsInternal { get; set; }
    }
}
