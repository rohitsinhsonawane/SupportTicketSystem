namespace SupportTicketSystem.Api.Entities
{
    public class Ticket
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

        public User CreatedByUser { get; set; }

        public User AssignedAdmin { get; set; }

        public ICollection<TicketComment> Comments { get; set; }

        public ICollection<TicketStatusHistory> StatusHistory { get; set; }
    }
}
