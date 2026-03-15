using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Api.Data;
using SupportTicketSystem.Api.Entities;

namespace SupportTicketSystem.Api.Seed
{
    public class DatabaseInitializer
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            using var scope = services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            await context.Database.MigrateAsync();

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Username = "admin",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin@123"),
                        Role = "Admin",
                        CreatedAt = DateTime.UtcNow
                    },
                    new User
                    {
                        Username = "user",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword("user@123"),
                        Role = "User",
                        CreatedAt = DateTime.UtcNow
                    }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}
