namespace SupportTicketSystem.Api.Entities
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
