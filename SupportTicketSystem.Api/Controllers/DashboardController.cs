using Microsoft.AspNetCore.Mvc;
using SupportTicketSystem.Api.DTOs;
using SupportTicketSystem.Api.Services.Interface;

namespace SupportTicketSystem.Api.Controllers;

[ApiController]
[Route("api/dashboard")]
public class DashboardController : ControllerBase
{
    private readonly IDashboardService _dashboardService;

    public DashboardController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    [HttpGet]
    public async Task<IActionResult> GetDashboard()
    {
        var data = await _dashboardService.GetDashboardData();

        return Ok(new ApiResponse<DashboardResponseDto>(
            true,
            "Dashboard loaded successfully",
            data
        ));
    }
}