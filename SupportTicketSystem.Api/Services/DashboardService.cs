using Microsoft.EntityFrameworkCore;
using AutoMapper;
using SupportTicketSystem.Api.Data;
using SupportTicketSystem.Api.DTOs;
using SupportTicketSystem.Api.Entities;
using SupportTicketSystem.Api.Services.Interface;

namespace SupportTicketSystem.Api.Services;

public class DashboardService : IDashboardService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public DashboardService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<DashboardResponseDto> GetDashboardData()
    {
        // Use targeted queries instead of loading all tickets into memory
        var totalTickets = await _context.Tickets.CountAsync();
        var openTickets = await _context.Tickets.CountAsync(t => t.Status == "Open");
        var inProgressTickets = await _context.Tickets.CountAsync(t => t.Status == "InProgress");
        var closedTickets = await _context.Tickets.CountAsync(t => t.Status == "Closed");

        var summary = new DashboardSummaryDto
        {
            TotalTickets = totalTickets,
            OpenTickets = openTickets,
            InProgressTickets = inProgressTickets,
            ClosedTickets = closedTickets
        };

        var recentTickets = await _context.Tickets
            .AsNoTracking()
            .Include(t => t.AssignedAdmin)
            .OrderByDescending(t => t.CreatedAt)
            .Take(5)
            .Select(t => new DashboardTicketDto
            {
                Id = t.Id,
                TicketNumber = t.TicketNumber,
                Subject = t.Subject,
                Priority = t.Priority,
                Status = t.Status,
                CreatedAt = t.CreatedAt,
                AssignedAdminUsername = t.AssignedAdmin != null ? t.AssignedAdmin.Username : null
            })
            .ToListAsync();

        var statusDistribution = await _context.Tickets
            .AsNoTracking()
            .GroupBy(t => t.Status)
            .Select(g => new DashboardStatusDistributionDto
            {
                Status = g.Key,
                Count = g.Count()
            })
            .ToListAsync();

        return new DashboardResponseDto
        {
            Summary = summary,
            RecentTickets = recentTickets,
            StatusDistribution = statusDistribution
        };
    }
}