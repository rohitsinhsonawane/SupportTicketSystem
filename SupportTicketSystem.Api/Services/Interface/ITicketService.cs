using SupportTicketSystem.Api.DTOs;
using SupportTicketSystem.Api.Entities;

namespace SupportTicketSystem.Api.Services.Interface
{
    public interface ITicketService
    {
        Task<TicketDto> CreateTicket(CreateTicketDto dto, int userId);
        Task<TicketDto> GetTicketDetails(int id);
        Task<List<TicketDto>> GetTickets(int userId, string role);
        Task<List<TicketCommentDto>> GetTicketComments(int ticketId);
        Task AssignTicket(int ticketId, int adminUserId);
        Task UpdateStatus(int ticketId, string newStatus, int userId);
        Task AddComment(int ticketId, string comment, int userId, bool internalComment);
    }
}
