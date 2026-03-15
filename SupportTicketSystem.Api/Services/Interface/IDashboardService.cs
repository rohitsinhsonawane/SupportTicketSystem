using SupportTicketSystem.Api.DTOs;

namespace SupportTicketSystem.Api.Services.Interface;

public interface IDashboardService
{
    Task<DashboardResponseDto> GetDashboardData();
}