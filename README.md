# SupportTicketSystem

A modern ticket management system built with .NET 8 and .NET 10. This application helps organizations track, manage, and resolve support tickets efficiently.

## Features
- Ticket creation, assignment, and resolution
- User authentication and authorization
- Desktop and API projects
- Database migrations

## Project Structure
- `SupportTicketSystem.Api`: Backend API for ticket operations
- `SupportTicketSystem.Desktop`: Desktop client for end-users

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) (if available)
- SQL Server or compatible database

### Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/rohitsinhsonawane/SupportTicketSystem.git
   ```
2. Navigate to the project directory:
   ```bash
   cd SupportTicketSystem
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Apply database migrations (from the API project):
   ```bash
   dotnet ef database update --project SupportTicketSystem.Api
   ```
5. Build and run the projects:
   ```bash
   dotnet build
   dotnet run --project SupportTicketSystem.Api
   dotnet run --project SupportTicketSystem.Desktop
   ```

## Usage
- Access the API via HTTP endpoints (see API documentation or code).
- Use the desktop client for ticket management.

## License
This project is licensed under the MIT License.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Contact
For support or questions, contact the repository owner via GitHub.
