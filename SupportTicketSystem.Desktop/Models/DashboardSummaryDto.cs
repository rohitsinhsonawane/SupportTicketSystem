namespace SupportTicketSystem.Desktop.DTOs;

public class DashboardSummaryDto
{
    public int TotalTickets { get; set; }

    public int OpenTickets { get; set; }

    public int InProgressTickets { get; set; }

    public int ClosedTickets { get; set; }
}