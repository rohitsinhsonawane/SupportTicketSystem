using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportTicketSystem.Api.DTOs;
using SupportTicketSystem.Api.Services.Interface;

namespace SupportTicketSystem.Api.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTicketDto dto)
        {
            try
            {
                int userId = 1;
                var ticket = await _ticketService.CreateTicket(dto, userId);

                return Ok(new ApiResponse<object>(
                    true,
                    "Ticket created successfully",
                    ticket
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<object>(
                    false,
                    $"Error creating ticket: {ex.Message}",
                    null
                ));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            try
            {
                int userId = 1;
                string role = "Admin";

                var tickets = await _ticketService.GetTickets(userId, role);

                return Ok(new ApiResponse<object>(
                    true,
                    "Tickets retrieved successfully",
                    tickets
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<object>(
                    false,
                    $"Error retrieving tickets: {ex.Message}",
                    null
                ));
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            try
            {
                var ticket = await _ticketService.GetTicketDetails(id);

                if (ticket == null)
                    return NotFound(new ApiResponse<object>(
                        false,
                        "Ticket not found",
                        null
                    ));

                return Ok(new ApiResponse<object>(
                    true,
                    "Ticket details retrieved successfully",
                    ticket
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<object>(
                    false,
                    $"Error retrieving ticket details: {ex.Message}",
                    null
                ));
            }
        }

        [HttpGet("{id}/comments")]
        public async Task<IActionResult> GetComments(int id)
        {
            try
            {
                var comments = await _ticketService.GetTicketComments(id);

                return Ok(new ApiResponse<object>(
                    true,
                    "Comments retrieved successfully",
                    comments
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<object>(
                    false,
                    $"Error retrieving comments: {ex.Message}",
                    null
                ));
            }
        }

        [HttpPut("{id}/assign")]
        public async Task<IActionResult> Assign(int id, AssignTicketDto dto)
        {
            try
            {
                await _ticketService.AssignTicket(id, dto.AdminUserId);

                return Ok(new ApiResponse<object>(
                    true,
                    "Ticket assigned successfully",
                    null
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<object>(
                    false,
                    $"Error assigning ticket: {ex.Message}",
                    null
                ));
            }
        }

        [HttpPost("{id}/comment")]
        public async Task<IActionResult> AddComment(int id, AddCommentDto dto)
        {
            try
            {
                int userId = 1;

                await _ticketService.AddComment(id, dto.Comment, userId, dto.IsInternal);

                return Ok(new ApiResponse<object>(
                    true,
                    "Comment added successfully",
                    null
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<object>(
                    false,
                    $"Error adding comment: {ex.Message}",
                    null
                ));
            }
        }
    }
}
