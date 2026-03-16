using SupportTicketSystem.Desktop.DTOs;
using SupportTicketSystem.Desktop.Models;
using SupportTicketSystem.Desktop.Configuration;
using System.Text;
using System.Text.Json;

public class ApiClient
{
    private readonly HttpClient _client;
    private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly ApiConfiguration _config;

    public ApiClient()
    {
        _config = ApiConfiguration.Instance;
        _client = new HttpClient();
        if (_client.BaseAddress == null)
        {
            _client.BaseAddress = new Uri(_config.BaseUrl);
        }
    }

    public ApiClient(HttpClient client)
    {
        _config = ApiConfiguration.Instance;
        _client = client ?? new HttpClient();
        if (_client.BaseAddress == null)
        {
            _client.BaseAddress = new Uri(_config.BaseUrl);
        }
    }

    public async Task<ApiResponse<LoginResponseDto>?> LoginAsync(LoginRequestDto request)
    {
        try
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(_config.LoginEndpoint, content);

            var responseJson = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ApiResponse<LoginResponseDto>>(responseJson, _jsonOptions);

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

            var result = JsonSerializer.Deserialize<ApiResponse<DashboardResponseDto>>(json, _jsonOptions);
            return result?.Data;
    }

    public async Task<List<TicketListDto>?> GetTickets()
    {
        try
        {
            var response = await _client.GetAsync(_config.GetTicketsEndpoint);

            var json = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ApiResponse<List<TicketListDto>>>(json, _jsonOptions);
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

            var result = JsonSerializer.Deserialize<ApiResponse<TicketDetailsDto>>(json, _jsonOptions);
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

            var result = JsonSerializer.Deserialize<ApiResponse<List<TicketCommentDto>>>(json, _jsonOptions);
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
                var errorResult = JsonSerializer.Deserialize<ApiResponse<object>>(errorJson, _jsonOptions);
                throw new Exception(errorResult?.Message ?? "Failed to add comment");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to add comment: {ex.Message}", ex);
        }
    }

    public async Task<bool> LogoutAsync()
    {
        try
        {
            var response = await _client.PostAsync(_config.LogoutEndpoint, null);
            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            throw new Exception($"Logout failed: {ex.Message}", ex);
        }
    }

    public async Task<ApiResponse<object>?> CreateTicketAsync(CreateTicketRequestDto request)
    {
        try
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(_config.CreateTicketEndpoint, content);

            var responseJson = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ApiResponse<object>>(responseJson, _jsonOptions);

            return result;
        }
        catch (Exception ex)
        {
            return new ApiResponse<object>
            {
                Success = false,
                Message = $"Create ticket failed: {ex.Message}",
                Data = null
            };
        }
    }
}
