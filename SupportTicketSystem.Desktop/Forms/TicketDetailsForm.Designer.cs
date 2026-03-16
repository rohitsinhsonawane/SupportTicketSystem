namespace SupportTicketSystem.Desktop.Forms
{
    partial class TicketDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelTicketDetails;
        private System.Windows.Forms.Label lblTicketNumberValue;
        private System.Windows.Forms.Label lblSubjectValue;
        private System.Windows.Forms.Label lblDescriptionValue;
        private System.Windows.Forms.Label lblPriorityValue;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblCreatedDateValue;
        private System.Windows.Forms.Label lblAssignedAdminValue;

        private System.Windows.Forms.Label lblTicketNumber;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblAssignedAdmin;

        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Panel panelCommentSection;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTopBar = new System.Windows.Forms.Panel();
            btnLogout = new System.Windows.Forms.Button();
            panelTicketDetails = new System.Windows.Forms.Panel();
            lblTicketNumber = new System.Windows.Forms.Label();
            lblTicketNumberValue = new System.Windows.Forms.Label();
            lblSubject = new System.Windows.Forms.Label();
            lblSubjectValue = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblDescriptionValue = new System.Windows.Forms.Label();
            lblPriority = new System.Windows.Forms.Label();
            lblPriorityValue = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblStatusValue = new System.Windows.Forms.Label();
            lblCreatedDate = new System.Windows.Forms.Label();
            lblCreatedDateValue = new System.Windows.Forms.Label();
            lblAssignedAdmin = new System.Windows.Forms.Label();
            lblAssignedAdminValue = new System.Windows.Forms.Label();

            lblComments = new System.Windows.Forms.Label();
            dataGridViewComments = new System.Windows.Forms.DataGridView();
            panelCommentSection = new System.Windows.Forms.Panel();
            txtComment = new System.Windows.Forms.TextBox();
            btnAddComment = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)dataGridViewComments).BeginInit();
            panelTopBar.SuspendLayout();
            panelTicketDetails.SuspendLayout();
            panelCommentSection.SuspendLayout();
            SuspendLayout();

            // panelTopBar
            panelTopBar.BackColor = System.Drawing.Color.LightGray;
            panelTopBar.Controls.Add(btnLogout);
            panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTopBar.Location = new System.Drawing.Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Padding = new System.Windows.Forms.Padding(10);
            panelTopBar.Size = new System.Drawing.Size(1000, 60);
            panelTopBar.TabIndex = 0;

            // btnLogout
            btnLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnLogout.Location = new System.Drawing.Point(860, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(120, 40);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;

            // panelTicketDetails
            panelTicketDetails.BackColor = System.Drawing.Color.White;
            panelTicketDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelTicketDetails.Dock = System.Windows.Forms.DockStyle.Top;
            panelTicketDetails.Padding = new System.Windows.Forms.Padding(15);
            panelTicketDetails.Location = new System.Drawing.Point(0, 60);
            panelTicketDetails.Name = "panelTicketDetails";
            panelTicketDetails.Size = new System.Drawing.Size(1000, 220);
            panelTicketDetails.TabIndex = 1;

            // lblTicketNumber
            lblTicketNumber.AutoSize = true;
            lblTicketNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblTicketNumber.Location = new System.Drawing.Point(15, 15);
            lblTicketNumber.Name = "lblTicketNumber";
            lblTicketNumber.Size = new System.Drawing.Size(105, 16);
            lblTicketNumber.Text = "Ticket Number:";

            lblTicketNumberValue.AutoSize = true;
            lblTicketNumberValue.Font = new System.Drawing.Font("Arial", 10F);
            lblTicketNumberValue.Location = new System.Drawing.Point(150, 15);
            lblTicketNumberValue.Name = "lblTicketNumberValue";
            lblTicketNumberValue.Size = new System.Drawing.Size(0, 16);
            lblTicketNumberValue.Text = "";

            // lblSubject
            lblSubject.AutoSize = true;
            lblSubject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblSubject.Location = new System.Drawing.Point(15, 45);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new System.Drawing.Size(63, 16);
            lblSubject.Text = "Subject:";

            lblSubjectValue.AutoSize = true;
            lblSubjectValue.Font = new System.Drawing.Font("Arial", 10F);
            lblSubjectValue.Location = new System.Drawing.Point(150, 45);
            lblSubjectValue.Name = "lblSubjectValue";
            lblSubjectValue.Size = new System.Drawing.Size(0, 16);
            lblSubjectValue.Text = "";

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblDescription.Location = new System.Drawing.Point(15, 75);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(86, 16);
            lblDescription.Text = "Description:";

            lblDescriptionValue.AutoSize = false;
            lblDescriptionValue.Font = new System.Drawing.Font("Arial", 10F);
            lblDescriptionValue.Location = new System.Drawing.Point(150, 75);
            lblDescriptionValue.Name = "lblDescriptionValue";
            lblDescriptionValue.Size = new System.Drawing.Size(800, 80);
            lblDescriptionValue.Text = "";

            // lblPriority
            lblPriority.AutoSize = true;
            lblPriority.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblPriority.Location = new System.Drawing.Point(15, 165);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new System.Drawing.Size(61, 16);
            lblPriority.Text = "Priority:";

            lblPriorityValue.AutoSize = true;
            lblPriorityValue.Font = new System.Drawing.Font("Arial", 10F);
            lblPriorityValue.Location = new System.Drawing.Point(150, 165);
            lblPriorityValue.Name = "lblPriorityValue";
            lblPriorityValue.Size = new System.Drawing.Size(0, 16);
            lblPriorityValue.Text = "";

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblStatus.Location = new System.Drawing.Point(350, 165);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(53, 16);
            lblStatus.Text = "Status:";

            lblStatusValue.AutoSize = true;
            lblStatusValue.Font = new System.Drawing.Font("Arial", 10F);
            lblStatusValue.Location = new System.Drawing.Point(450, 165);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new System.Drawing.Size(0, 16);
            lblStatusValue.Text = "";

            // lblCreatedDate
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblCreatedDate.Location = new System.Drawing.Point(15, 195);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new System.Drawing.Size(95, 16);
            lblCreatedDate.Text = "Created Date:";

            lblCreatedDateValue.AutoSize = true;
            lblCreatedDateValue.Font = new System.Drawing.Font("Arial", 10F);
            lblCreatedDateValue.Location = new System.Drawing.Point(150, 195);
            lblCreatedDateValue.Name = "lblCreatedDateValue";
            lblCreatedDateValue.Size = new System.Drawing.Size(0, 16);
            lblCreatedDateValue.Text = "";

            // lblAssignedAdmin
            lblAssignedAdmin.AutoSize = true;
            lblAssignedAdmin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblAssignedAdmin.Location = new System.Drawing.Point(350, 195);
            lblAssignedAdmin.Name = "lblAssignedAdmin";
            lblAssignedAdmin.Size = new System.Drawing.Size(114, 16);
            lblAssignedAdmin.Text = "Assigned Admin:";

            lblAssignedAdminValue.AutoSize = true;
            lblAssignedAdminValue.Font = new System.Drawing.Font("Arial", 10F);
            lblAssignedAdminValue.Location = new System.Drawing.Point(500, 195);
            lblAssignedAdminValue.Name = "lblAssignedAdminValue";
            lblAssignedAdminValue.Size = new System.Drawing.Size(0, 16);
            lblAssignedAdminValue.Text = "";

            // Add labels to panelTicketDetails
            panelTicketDetails.Controls.Add(lblTicketNumber);
            panelTicketDetails.Controls.Add(lblTicketNumberValue);
            panelTicketDetails.Controls.Add(lblSubject);
            panelTicketDetails.Controls.Add(lblSubjectValue);
            panelTicketDetails.Controls.Add(lblDescription);
            panelTicketDetails.Controls.Add(lblDescriptionValue);
            panelTicketDetails.Controls.Add(lblPriority);
            panelTicketDetails.Controls.Add(lblPriorityValue);
            panelTicketDetails.Controls.Add(lblStatus);
            panelTicketDetails.Controls.Add(lblStatusValue);
            panelTicketDetails.Controls.Add(lblCreatedDate);
            panelTicketDetails.Controls.Add(lblCreatedDateValue);
            panelTicketDetails.Controls.Add(lblAssignedAdmin);
            panelTicketDetails.Controls.Add(lblAssignedAdminValue);

            // btnLogout
            btnLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnLogout.Location = new System.Drawing.Point(850, 230);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(120, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;

            // lblComments
            lblComments.AutoSize = true;
            lblComments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            lblComments.Location = new System.Drawing.Point(15, 15);
            lblComments.Name = "lblComments";
            lblComments.Size = new System.Drawing.Size(94, 19);
            lblComments.TabIndex = 0;
            lblComments.Text = "Comments";

            // dataGridViewComments
            dataGridViewComments.AllowUserToAddRows = false;
            dataGridViewComments.AllowUserToDeleteRows = false;
            dataGridViewComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComments.ColumnHeadersHeight = 29;
            dataGridViewComments.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewComments.Location = new System.Drawing.Point(10, 45);
            dataGridViewComments.MultiSelect = false;
            dataGridViewComments.Name = "dataGridViewComments";
            dataGridViewComments.ReadOnly = true;
            dataGridViewComments.RowHeadersVisible = false;
            dataGridViewComments.RowHeadersWidth = 51;
            dataGridViewComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewComments.Size = new System.Drawing.Size(980, 200);
            dataGridViewComments.TabIndex = 1;

            // txtComment
            txtComment.Font = new System.Drawing.Font("Arial", 10F);
            txtComment.Location = new System.Drawing.Point(10, 10);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.PlaceholderText = "Enter your comment here...";
            txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtComment.Size = new System.Drawing.Size(850, 70);
            txtComment.TabIndex = 0;

            // btnAddComment
            btnAddComment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnAddComment.Location = new System.Drawing.Point(870, 10);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new System.Drawing.Size(110, 70);
            btnAddComment.TabIndex = 1;
            btnAddComment.Text = "Add Comment";
            btnAddComment.UseVisualStyleBackColor = true;
            btnAddComment.Click += BtnAddComment_Click;

            // panelCommentSection
            panelCommentSection.BackColor = System.Drawing.Color.LightGray;
            panelCommentSection.Controls.Add(dataGridViewComments);
            panelCommentSection.Controls.Add(lblComments);
            panelCommentSection.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCommentSection.Location = new System.Drawing.Point(0, 280);
            panelCommentSection.Name = "panelCommentSection";
            panelCommentSection.Padding = new System.Windows.Forms.Padding(10);
            panelCommentSection.Size = new System.Drawing.Size(1000, 260);
            panelCommentSection.TabIndex = 2;

            // Panel for comment input
            var panelCommentInput = new System.Windows.Forms.Panel();
            panelCommentInput.BackColor = System.Drawing.Color.White;
            panelCommentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCommentInput.Controls.Add(btnAddComment);
            panelCommentInput.Controls.Add(txtComment);
            panelCommentInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelCommentInput.Location = new System.Drawing.Point(10, 245);
            panelCommentInput.Name = "panelCommentInput";
            panelCommentInput.Padding = new System.Windows.Forms.Padding(10);
            panelCommentInput.Size = new System.Drawing.Size(980, 95);
            panelCommentInput.TabIndex = 2;
            panelCommentSection.Controls.Add(panelCommentInput);

            // TicketDetailsForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1000, 600);
            Controls.Add(panelCommentSection);
            Controls.Add(panelTicketDetails);
            Controls.Add(panelTopBar);
            Name = "TicketDetailsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ticket Details";
            Load += TicketDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewComments).EndInit();
            panelTopBar.ResumeLayout(false);
            panelTicketDetails.ResumeLayout(false);
            panelTicketDetails.PerformLayout();
            panelCommentSection.ResumeLayout(false);
            panelCommentSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
