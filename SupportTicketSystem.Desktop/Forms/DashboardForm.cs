using SupportTicketSystem.Desktop.DTOs;
using SupportTicketSystem.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupportTicketSystem.Desktop.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly ApiClient _apiClient = new ApiClient();
        private readonly int _userId;
        private readonly string _role;

        public DashboardForm(int userId, string role)
        {
            InitializeComponent();
            _userId = userId;
            _role = role;
        }

        [Obsolete("Use DashboardForm(int userId, string role) constructor instead.")]
        public DashboardForm()
        {
            InitializeComponent();
            _userId = 0;
            _role = string.Empty;
        }

        private async void DashboardForm_LoadAsync(object sender, EventArgs e)
        {
            await LoadDashboardAsync();
        }

        private async Task LoadDashboardAsync()
        {
            try
            {
                // Show loading state
                dataGridViewRecentTickets.Enabled = false;

                // Fetch dashboard data from API
                var dashboard = await _apiClient.GetDashboard();

                if (dashboard == null)
                {
                    MessageBox.Show("Unable to load dashboard data. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Populate summary labels
                lblTotalTickets.Text = dashboard.Summary.TotalTickets.ToString();
                lblOpenTickets.Text = dashboard.Summary.OpenTickets.ToString();
                lblInProgress.Text = dashboard.Summary.InProgressTickets.ToString();
                lblClosed.Text = dashboard.Summary.ClosedTickets.ToString();

                // Filter tickets based on user role
                var tickets = FilterTicketsByRole(dashboard.RecentTickets);

                // Bind filtered tickets to DataGridView
                BindTicketsToGrid(tickets);

                dataGridViewRecentTickets.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewRecentTickets.Enabled = true;
            }
        }

        private List<DashboardTicketDto> FilterTicketsByRole(List<DashboardTicketDto> tickets)
        {
            // If role is "User", filter tickets created by that user
            if (_role.Equals("User", StringComparison.OrdinalIgnoreCase))
            {
                return tickets?.Where(t => t.CreatedByUserId == _userId).ToList() ?? new List<DashboardTicketDto>();
            }

            // Admins can see all tickets
            return tickets ?? new List<DashboardTicketDto>();
        }

        private void BindTicketsToGrid(List<DashboardTicketDto> tickets)
        {
            dataGridViewRecentTickets.DataSource = null;
            dataGridViewRecentTickets.DataSource = tickets;

            // Configure grid columns for better display
            ConfigureGridColumns();
        }

        private void ConfigureGridColumns()
        {
            if (dataGridViewRecentTickets.Columns.Count == 0)
                return;

            // Set column header text and widths
            if (dataGridViewRecentTickets.Columns.Contains("TicketNumber"))
            {
                dataGridViewRecentTickets.Columns["TicketNumber"].HeaderText = "Ticket #";
            }

            if (dataGridViewRecentTickets.Columns.Contains("Subject"))
            {
                dataGridViewRecentTickets.Columns["Subject"].HeaderText = "Subject";
            }

            if (dataGridViewRecentTickets.Columns.Contains("Priority"))
            {
                dataGridViewRecentTickets.Columns["Priority"].HeaderText = "Priority";
            }

            if (dataGridViewRecentTickets.Columns.Contains("Status"))
            {
                dataGridViewRecentTickets.Columns["Status"].HeaderText = "Status";
            }

            if (dataGridViewRecentTickets.Columns.Contains("CreatedAt"))
            {
                dataGridViewRecentTickets.Columns["CreatedAt"].HeaderText = "Created";
                dataGridViewRecentTickets.Columns["CreatedAt"].DefaultCellStyle.Format = "g";
            }

            if (dataGridViewRecentTickets.Columns.Contains("AssignedAdminUsername"))
            {
                dataGridViewRecentTickets.Columns["AssignedAdminUsername"].HeaderText = "Assigned Admin";
            }

            // Hide internal columns that should not be displayed
            if (dataGridViewRecentTickets.Columns.Contains("Id"))
            {
                dataGridViewRecentTickets.Columns["Id"].Visible = false;
            }

            if (dataGridViewRecentTickets.Columns.Contains("CreatedByUserId"))
            {
                dataGridViewRecentTickets.Columns["CreatedByUserId"].Visible = false;
            }
        }

        private async void BtnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;

                await _apiClient.LogoutAsync();
                TokenManager.ClearToken();

                MessageBox.Show("Logged out successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close this form and open login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Logout failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
