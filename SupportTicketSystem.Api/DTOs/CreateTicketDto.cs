namespace SupportTicketSystem.Api.DTOs
{
    public class CreateTicketDto
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
    }
}
