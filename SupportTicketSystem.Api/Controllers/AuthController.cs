using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportTicketSystem.Api.DTOs;
using SupportTicketSystem.Api.Services.Interface;

namespace SupportTicketSystem.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto request)
        {
            try
            {
                var result = await _authService.Login(request);

                if (result == null)
                    return Unauthorized(new ApiResponse<object>(
                        false,
                        "Invalid credentials",
                        null
                    ));

                return Ok(new ApiResponse<object>(
                    true,
                    "Login successful",
                    result
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<object>(
                    false,
                    $"Error during login: {ex.Message}",
                    null
                ));
            }
        }
    }
}
