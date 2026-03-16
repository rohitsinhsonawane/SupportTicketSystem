using SupportTicketSystem.Desktop.DTOs;
using System;
using System.Windows.Forms;

namespace SupportTicketSystem.Desktop.Forms
{
    public partial class CreateTicketForm : Form
    {
        private readonly ApiClient _apiClient = new ApiClient();

        public CreateTicketForm()
        {
            InitializeComponent();
        }

        private async void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSubject.Text))
                {
                    MessageBox.Show("Please enter a subject.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please enter a description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btnCreate.Enabled = false;
                btnCreate.Text = "Creating...";

                var request = new CreateTicketRequestDto
                {
                    Subject = txtSubject.Text,
                    Description = txtDescription.Text,
                    Priority = cmbPriority.SelectedItem?.ToString() ?? "Low"
                };

                var result = await _apiClient.CreateTicketAsync(request);

                if (result?.Success == true)
                {
                    MessageBox.Show("Ticket created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Failed to create ticket: {result?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCreate.Enabled = true;
                btnCreate.Text = "Create Ticket";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
