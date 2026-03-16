using SupportTicketSystem.Desktop.DTOs;
using SupportTicketSystem.Desktop.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SupportTicketSystem.Desktop.Forms
{
    public partial class TicketDetailsForm : Form
    {
        private readonly int _ticketId;
        private readonly int _userId;
        private readonly string _role;
        private readonly ApiClient _apiClient;

        public TicketDetailsForm(int ticketId, int userId, string role)
        {
            InitializeComponent();
            _ticketId = ticketId;
            _userId = userId;
            _role = role;
            _apiClient = new ApiClient();
        }

        private async void TicketDetailsForm_Load(object sender, EventArgs e)
        {
            await LoadTicketDetailsAsync();
        }

        private async Task LoadTicketDetailsAsync()
        {
            try
            {
                // Load ticket details
                var ticket = await _apiClient.GetTicketDetails(_ticketId);

                if (ticket == null)
                {
                    MessageBox.Show("Ticket not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                // Populate ticket details
                PopulateTicketDetails(ticket);

                // Load and bind comments
                await LoadCommentsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load ticket details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void PopulateTicketDetails(TicketDetailsDto ticket)
        {
            this.Text = $"Ticket Details - {ticket.TicketNumber}";
            lblTicketNumberValue.Text = ticket.TicketNumber;
            lblSubjectValue.Text = ticket.Subject;
            lblDescriptionValue.Text = ticket.Description;
            lblPriorityValue.Text = ticket.Priority;
            lblStatusValue.Text = ticket.Status;
            lblCreatedDateValue.Text = ticket.CreatedAt.ToString("g");
            lblAssignedAdminValue.Text = ticket.AssignedAdminUsername ?? "Not Assigned";
        }

        private async Task LoadCommentsAsync()
        {
            try
            {
                dataGridViewComments.Enabled = false;

                var comments = await _apiClient.GetTicketComments(_ticketId);

                if (comments == null || comments.Count == 0)
                {
                    dataGridViewComments.DataSource = new List<TicketCommentDto>();
                }
                else
                {
                    BindCommentsToGrid(comments);
                }

                dataGridViewComments.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load comments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewComments.Enabled = true;
            }
        }

        private void BindCommentsToGrid(List<TicketCommentDto> comments)
        {
            dataGridViewComments.DataSource = null;
            dataGridViewComments.DataSource = comments;

            // Configure grid columns
            ConfigureCommentsGridColumns();
        }

        private void ConfigureCommentsGridColumns()
        {
            if (dataGridViewComments.Columns.Count == 0)
                return;

            if (dataGridViewComments.Columns.Contains("CreatedByUsername"))
            {
                dataGridViewComments.Columns["CreatedByUsername"].HeaderText = "Author";
            }

            if (dataGridViewComments.Columns.Contains("Comment"))
            {
                dataGridViewComments.Columns["Comment"].HeaderText = "Comment";
            }

            if (dataGridViewComments.Columns.Contains("CreatedAt"))
            {
                dataGridViewComments.Columns["CreatedAt"].HeaderText = "Date";
                dataGridViewComments.Columns["CreatedAt"].DefaultCellStyle.Format = "g";
            }

            if (dataGridViewComments.Columns.Contains("IsInternal"))
            {
                dataGridViewComments.Columns["IsInternal"].HeaderText = "Internal";
            }

            // Hide internal columns
            if (dataGridViewComments.Columns.Contains("Id"))
            {
                dataGridViewComments.Columns["Id"].Visible = false;
            }

            if (dataGridViewComments.Columns.Contains("TicketId"))
            {
                dataGridViewComments.Columns["TicketId"].Visible = false;
            }

            if (dataGridViewComments.Columns.Contains("CreatedByUserId"))
            {
                dataGridViewComments.Columns["CreatedByUserId"].Visible = false;
            }
        }

        private async void BtnAddComment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtComment.Text))
                {
                    MessageBox.Show("Please enter a comment.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Disable button and textbox during submission
                btnAddComment.Enabled = false;
                txtComment.Enabled = false;
                btnAddComment.Text = "Adding...";

                // Call API to add comment
                var isInternal = _role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
                await _apiClient.AddComment(_ticketId, txtComment.Text, isInternal);

                // Clear textbox
                txtComment.Clear();

                // Reload comments
                await LoadCommentsAsync();

                MessageBox.Show("Comment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add comment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Re-enable controls
                btnAddComment.Enabled = true;
                txtComment.Enabled = true;
                btnAddComment.Text = "Add Comment";
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

