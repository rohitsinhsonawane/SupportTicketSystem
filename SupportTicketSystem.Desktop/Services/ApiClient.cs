using SupportTicketSystem.Desktop.DTOs;
using SupportTicketSystem.Desktop.Models;
using SupportTicketSystem.Desktop.Configuration;
using System.Text;
using System.Text.Json;

public class ApiClient
{
    private readonly HttpClient _client;
    private readonly ApiConfiguration _config;

    public ApiClient()
    {
        _config = ApiConfiguration.Instance;
        _client = new HttpClient();
        _client.BaseAddress = new Uri(_config.BaseUrl);
    }

    public async Task<ApiResponse<LoginResponseDto>?> LoginAsync(LoginRequestDto request)
    {
        try
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(_config.LoginEndpoint, content);

            var responseJson = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ApiResponse<LoginResponseDto>>(
                responseJson,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return result;
        }
        catch (Exception ex)
        {
            return new ApiResponse<LoginResponseDto>
            {
                Success = false,
                Message = $"Login failed: {ex.Message}",
                Data = null
            };
        }
    }

    public async Task<DashboardResponseDto?> GetDashboard()
    {
        var response = await _client.GetAsync(_config.DashboardEndpoint);

        var json = await response.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<ApiResponse<DashboardResponseDto>>(
            json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

        return result?.Data;
    }

    public async Task<List<TicketListDto>?> GetTickets()
    {
        try
        {
            var response = await _client.GetAsync(_config.GetTicketsEndpoint);

            var json = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ApiResponse<List<TicketListDto>>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return result?.Data;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to fetch tickets: {ex.Message}", ex);
        }
    }

    public async Task<TicketDetailsDto?> GetTicketDetails(int ticketId)
    {
        try
        {
            var endpoint = _config.GetTicketDetailsEndpoint.Replace("{ticketId}", ticketId.ToString());
            var response = await _client.GetAsync(endpoint);

            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ApiResponse<TicketDetailsDto>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return result?.Data;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to fetch ticket details: {ex.Message}", ex);
        }
    }

    public async Task<List<TicketCommentDto>?> GetTicketComments(int ticketId)
    {
        try
        {
            var endpoint = _config.GetTicketCommentsEndpoint.Replace("{ticketId}", ticketId.ToString());
            var response = await _client.GetAsync(endpoint);

            if (!response.IsSuccessStatusCode)
                return new List<TicketCommentDto>();

            var json = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ApiResponse<List<TicketCommentDto>>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return result?.Data ?? new List<TicketCommentDto>();
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to fetch ticket comments: {ex.Message}", ex);
        }
    }

    public async Task AddComment(int ticketId, string comment, bool isInternal)
    {
        try
        {
            var request = new
            {
                Comment = comment,
                IsInternal = isInternal
            };

            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var endpoint = _config.AddCommentEndpoint.Replace("{ticketId}", ticketId.ToString());
            var response = await _client.PostAsync(endpoint, content);

            if (!response.IsSuccessStatusCode)
            {
                var errorJson = await response.Content.ReadAsStringAsync();
                var errorResult = JsonSerializer.Deserialize<ApiResponse<object>>(
                    errorJson,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                throw new Exception(errorResult?.Message ?? "Failed to add comment");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to add comment: {ex.Message}", ex);
        }
    }
}
