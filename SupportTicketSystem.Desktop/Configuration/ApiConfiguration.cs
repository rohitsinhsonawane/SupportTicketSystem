using Microsoft.Extensions.Configuration;
using System;

namespace SupportTicketSystem.Desktop.Configuration
{
    public class ApiConfiguration
    {
        private readonly IConfiguration _configuration;
        private static ApiConfiguration _instance;
        private static readonly object _lock = new object();

        private ApiConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static ApiConfiguration Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            var builder = new ConfigurationBuilder()
                                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                            var configuration = builder.Build();
                            _instance = new ApiConfiguration(configuration);
                        }
                    }
                }
                return _instance;
            }
        }

        public string BaseUrl => _configuration["ApiSettings:BaseUrl"];

        public string LoginEndpoint => _configuration["ApiSettings:Endpoints:Login"];

        public string LogoutEndpoint => _configuration["ApiSettings:Endpoints:Logout"];

        public string DashboardEndpoint => _configuration["ApiSettings:Endpoints:Dashboard"];

        public string GetTicketsEndpoint => _configuration["ApiSettings:Endpoints:GetTickets"];

        public string CreateTicketEndpoint => _configuration["ApiSettings:Endpoints:CreateTicket"];

        public string GetTicketDetailsEndpoint => _configuration["ApiSettings:Endpoints:GetTicketDetails"];

        public string GetTicketCommentsEndpoint => _configuration["ApiSettings:Endpoints:GetTicketComments"];

        public string AddCommentEndpoint => _configuration["ApiSettings:Endpoints:AddComment"];
    }
}
