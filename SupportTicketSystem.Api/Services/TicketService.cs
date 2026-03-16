using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Api.Data;
using SupportTicketSystem.Api.DTOs;
using SupportTicketSystem.Api.Entities;
using SupportTicketSystem.Api.Services.Interface;
using System.Net.Sockets;

namespace SupportTicketSystem.Api.Services
{
    public class TicketService : ITicketService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TicketService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TicketDto> CreateTicket(CreateTicketDto dto, int userId)
        {
            var ticket = new Ticket
            {
                TicketNumber = GenerateTicketNumber(),
                Subject = dto.Subject,
                Description = dto.Description,
                Priority = dto.Priority,
                Status = "Open",
                CreatedAt = DateTime.UtcNow,
                CreatedByUserId = userId
            };

            _context.Tickets.Add(ticket);

            await _context.SaveChangesAsync();

            return _mapper.Map<TicketDto>(ticket);
        }

        public async Task<List<TicketDto>> GetTickets(int userId, string role)
        {
            IQueryable<Ticket> query = _context.Tickets
                .AsNoTracking()
                .Include(t => t.CreatedByUser)
                .Include(t => t.AssignedAdmin);

            if (role != "Admin")
            {
                query = query.Where(t => t.CreatedByUserId == userId);
            }

            var tickets = await query.ToListAsync();

            return _mapper.Map<List<TicketDto>>(tickets);
        }

        public async Task<TicketDto?> GetTicketDetails(int ticketId)
        {
            var ticket = await _context.Tickets
                .AsNoTracking()
                .Include(t => t.CreatedByUser)
                .Include(t => t.AssignedAdmin)
                .Include(t => t.Comments)
                .Include(t => t.StatusHistory)
                .FirstOrDefaultAsync(t => t.Id == ticketId);

            if (ticket == null)
                return null;

            return _mapper.Map<TicketDto>(ticket);
        }

        public async Task AssignTicket(int ticketId, int adminUserId)
        {
            var ticket = await _context.Tickets.FindAsync(ticketId);

            if (ticket == null)
                throw new Exception("Ticket not found");

            ticket.AssignedAdminId = adminUserId;

            await _context.SaveChangesAsync();
        }

        public async Task UpdateStatus(int ticketId, string newStatus, int userId)
        {
            var ticket = await _context.Tickets.FindAsync(ticketId);

            if (ticket == null)
                throw new Exception("Ticket not found");

            if (ticket.Status == "Closed")
                throw new Exception("Closed tickets cannot be modified");

            if (!IsValidStatusTransition(ticket.Status, newStatus))
                throw new Exception("Invalid status transition");

            var history = new TicketStatusHistory
            {
                TicketId = ticketId,
                OldStatus = ticket.Status,
                NewStatus = newStatus,
                UpdatedByUserId = userId,
                UpdatedAt = DateTime.UtcNow
            };

            ticket.Status = newStatus;

            _context.TicketStatusHistories.Add(history);

            await _context.SaveChangesAsync();
        }

        public async Task<List<TicketCommentDto>> GetTicketComments(int ticketId)
        {
            var comments = await _context.TicketComments
                .AsNoTracking()
                .Where(c => c.TicketId == ticketId)
                .Include(c => c.CreatedByUser)
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();

            return _mapper.Map<List<TicketCommentDto>>(comments);
        }

        public async Task AddComment(int ticketId, string comment, int userId, bool internalComment)
        {
            var ticket = await _context.Tickets.FindAsync(ticketId);

            if (ticket == null)
                throw new Exception("Ticket not found");

            var newComment = new TicketComment
            {
                TicketId = ticketId,
                Comment = comment,
                CreatedByUserId = userId,
                CreatedAt = DateTime.UtcNow,
                IsInternal = internalComment
            };

            _context.TicketComments.Add(newComment);

            await _context.SaveChangesAsync();
        }

        private bool IsValidStatusTransition(string current, string next)
        {
            return (current == "Open" && next == "InProgress")
                || (current == "InProgress" && next == "Closed")
                || (current == next);
        }


        private string GenerateTicketNumber()
        {
            return $"TCK-{DateTime.UtcNow:yyyyMMddHHmmss}";
        }
    }
}