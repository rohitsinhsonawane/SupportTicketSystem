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
        var tickets = await _context.Tickets
            .Include(t => t.AssignedAdmin)
            .OrderByDescending(t => t.CreatedAt)
            .ToListAsync();

        var summary = new DashboardSummaryDto
        {
            TotalTickets = tickets.Count,
            OpenTickets = tickets.Count(t => t.Status == "Open"),
            InProgressTickets = tickets.Count(t => t.Status == "InProgress"),
            ClosedTickets = tickets.Count(t => t.Status == "Closed")
        };

        var recentTickets = tickets
            .Take(5)
            .Select(t => new DashboardTicketDto
            {
                Id = t.Id,
                TicketNumber = t.TicketNumber,
                Subject = t.Subject,
                Priority = t.Priority,
                Status = t.Status,
                CreatedAt = t.CreatedAt,
                AssignedAdminUsername = t.AssignedAdmin?.Username
            })
            .ToList();

        var statusDistribution = tickets
            .GroupBy(t => t.Status)
            .Select(g => new DashboardStatusDistributionDto
            {
                Status = g.Key,
                Count = g.Count()
            })
            .ToList();

        return new DashboardResponseDto
        {
            Summary = summary,
            RecentTickets = recentTickets,
            StatusDistribution = statusDistribution
        };
    }
}