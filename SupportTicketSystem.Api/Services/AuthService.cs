using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Api.Data;
using SupportTicketSystem.Api.DTOs;
using SupportTicketSystem.Api.Services.Interface;

namespace SupportTicketSystem.Api.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<LoginResponseDto?> Login(LoginRequestDto request)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.Username == request.Username);

            if (user == null)
                return null;

            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
                return null;

            return new LoginResponseDto
            {
                UserId = user.Id,
                Role = user.Role
            };
        }
    }
}
