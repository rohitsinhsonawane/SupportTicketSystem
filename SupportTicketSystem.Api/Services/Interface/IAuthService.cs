using SupportTicketSystem.Api.DTOs;

namespace SupportTicketSystem.Api.Services.Interface
{
    public interface IAuthService
    {
        Task<LoginResponseDto?> Login(LoginRequestDto request);
    }
}
