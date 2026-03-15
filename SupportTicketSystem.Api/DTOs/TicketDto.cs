namespace SupportTicketSystem.Api.DTOs
{
    public class TicketDto
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedByUserId { get; set; }
        public int? AssignedAdminId { get; set; }
        public string CreatedByUsername { get; set; }
        public string AssignedAdminUsername { get; set; }
        public List<TicketCommentDto> Comments { get; set; }
        public List<TicketStatusHistoryDto> StatusHistory { get; set; }
    }
}
