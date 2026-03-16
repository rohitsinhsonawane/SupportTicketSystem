using System.Text.Json;
using SupportTicketSystem.Api.DTOs;

namespace SupportTicketSystem.Api.Middleware;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception occurred while processing request.");

            context.Response.ContentType = "application/json";

            // Map some common exception types to appropriate status codes
            int statusCode = StatusCodes.Status500InternalServerError;
            string message = "An unexpected error occurred.";

            if (ex is ArgumentException || ex is InvalidOperationException)
            {
                statusCode = StatusCodes.Status400BadRequest;
                message = ex.Message;
            }

            context.Response.StatusCode = statusCode;

            var apiResponse = new ApiResponse<object>(false, message, null);

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var json = JsonSerializer.Serialize(apiResponse, options);

            await context.Response.WriteAsync(json);
        }
    }
}
