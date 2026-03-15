namespace SupportTicketSystem.Api.DTOs;

public class DashboardResponseDto
{
    public DashboardSummaryDto Summary { get; set; }

    public List<DashboardTicketDto> RecentTickets { get; set; } = new();

    public List<DashboardStatusDistributionDto> StatusDistribution { get; set; } = new();
}