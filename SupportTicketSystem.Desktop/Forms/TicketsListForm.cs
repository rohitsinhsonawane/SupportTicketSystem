using SupportTicketSystem.Desktop.DTOs;
using SupportTicketSystem.Desktop.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SupportTicketSystem.Desktop.Forms
{
    public partial class TicketsListForm : Form
    {
        private readonly ApiClient _apiClient;
        private readonly int _userId;
        private readonly string _role;

        public TicketsListForm(int userId, string role)
        {
            InitializeComponent();
            _userId = userId;
            _role = role;
            _apiClient = new ApiClient();
        }

        private async void TicketsListForm_LoadAsync(object sender, EventArgs e)
        {
            await LoadTicketsAsync();
        }

        private async Task LoadTicketsAsync()
        {
            try
            {
                // Disable grid during load
                dataGridViewTickets.Enabled = false;

                // Fetch tickets from API
                var tickets = await _apiClient.GetTickets();

                if (tickets == null || tickets.Count == 0)
                {
                    MessageBox.Show("No tickets found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewTickets.DataSource = new List<TicketListDto>();
                }
                else
                {
                    // Bind tickets to grid
                    BindTicketsToGrid(tickets);
                }

                dataGridViewTickets.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tickets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewTickets.Enabled = true;
            }
        }

        private void BindTicketsToGrid(List<TicketListDto> tickets)
        {
            dataGridViewTickets.DataSource = null;
            dataGridViewTickets.DataSource = tickets;

            // Configure grid columns for better display
            ConfigureGridColumns();
        }

        private void ConfigureGridColumns()
        {
            if (dataGridViewTickets.Columns.Count == 0)
                return;

            // Set column header text and configure visibility
            if (dataGridViewTickets.Columns.Contains("TicketNumber"))
            {
                dataGridViewTickets.Columns["TicketNumber"].HeaderText = "Ticket #";
            }

            if (dataGridViewTickets.Columns.Contains("Subject"))
            {
                dataGridViewTickets.Columns["Subject"].HeaderText = "Subject";
            }

            if (dataGridViewTickets.Columns.Contains("Priority"))
            {
                dataGridViewTickets.Columns["Priority"].HeaderText = "Priority";
            }

            if (dataGridViewTickets.Columns.Contains("Status"))
            {
                dataGridViewTickets.Columns["Status"].HeaderText = "Status";
            }

            if (dataGridViewTickets.Columns.Contains("CreatedAt"))
            {
                dataGridViewTickets.Columns["CreatedAt"].HeaderText = "Created";
                dataGridViewTickets.Columns["CreatedAt"].DefaultCellStyle.Format = "g";
            }

            if (dataGridViewTickets.Columns.Contains("AssignedAdminUsername"))
            {
                dataGridViewTickets.Columns["AssignedAdminUsername"].HeaderText = "Assigned Admin";
            }

            // Hide internal columns
            if (dataGridViewTickets.Columns.Contains("Id"))
            {
                dataGridViewTickets.Columns["Id"].Visible = false;
            }
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await LoadTicketsAsync();
        }

        private void BtnCreateTicket_Click(object sender, EventArgs e)
        {
            CreateTicketForm createForm = new CreateTicketForm();
            createForm.ShowDialog();

            // Refresh the tickets list after closing the create form
            _ = LoadTicketsAsync();
        }

        private void DataGridViewTickets_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTickets.SelectedRows.Count == 0)
                    return;

                // Get the selected row
                var selectedRow = dataGridViewTickets.SelectedRows[0];

                // Extract ticket ID from the row
                if (selectedRow.DataBoundItem is TicketListDto ticket)
                {
                    // Open TicketDetailsForm with the selected ticket ID
                    TicketDetailsForm detailsForm = new TicketDetailsForm(ticket.Id, _userId, _role);
                    detailsForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening ticket details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
