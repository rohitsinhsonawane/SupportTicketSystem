using SupportTicketSystem.Desktop.DTOs;
using System;
using System.Windows.Forms;

namespace SupportTicketSystem.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ApiClient _apiClient;

        public LoginForm()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous error message
                lblError.Text = "";

                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    lblError.Text = "Username and password are required.";
                    return;
                }

                // Disable login button to prevent multiple clicks
                btnLogin.Enabled = false;
                btnLogin.Text = "Logging in...";

                // Create login request
                var loginRequest = new LoginRequestDto
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text
                };

                // Call API
                var response = await _apiClient.LoginAsync(loginRequest);

                if (response?.Success == true && response.Data != null)
                {
                    // Login successful
                    var userId = response.Data.UserId;
                    var role = response.Data.Role;

                    // Open TicketsListForm and pass user info
                    TicketsListForm ticketsList = new TicketsListForm(userId, role);
                    ticketsList.Show();

                    // Hide login form
                    this.Hide();
                }
                else
                {
                    // Login failed
                    lblError.Text = response?.Message ?? "Login failed. Please check your credentials.";
                    btnLogin.Enabled = true;
                    btnLogin.Text = "Login";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = $"An error occurred: {ex.Message}";
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
            }
        }
    }
}
