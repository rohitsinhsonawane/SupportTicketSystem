namespace SupportTicketSystem.Desktop.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSummary;
        private System.Windows.Forms.Panel panelTotalTickets;
        private System.Windows.Forms.Panel panelOpenTickets;
        private System.Windows.Forms.Panel panelInProgress;
        private System.Windows.Forms.Panel panelClosed;

        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalTickets;

        private System.Windows.Forms.Label lblOpenTitle;
        private System.Windows.Forms.Label lblOpenTickets;

        private System.Windows.Forms.Label lblInProgressTitle;
        private System.Windows.Forms.Label lblInProgress;

        private System.Windows.Forms.Label lblClosedTitle;
        private System.Windows.Forms.Label lblClosed;

        private System.Windows.Forms.Label lblRecentTickets;
        private System.Windows.Forms.DataGridView dataGridViewRecentTickets;

        private System.Windows.Forms.Panel panelSummaryContainer;
        private System.Windows.Forms.Panel panelTicketsContainer;
        private System.Windows.Forms.Button btnLogout;

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
            tableLayoutPanelSummary = new TableLayoutPanel();
            panelTotalTickets = new Panel();
            lblTotalTitle = new Label();
            lblTotalTickets = new Label();
            panelOpenTickets = new Panel();
            lblOpenTitle = new Label();
            lblOpenTickets = new Label();
            panelInProgress = new Panel();
            lblInProgressTitle = new Label();
            lblInProgress = new Label();
            panelClosed = new Panel();
            lblClosedTitle = new Label();
            lblClosed = new Label();
            lblRecentTickets = new Label();
            dataGridViewRecentTickets = new DataGridView();
            panelSummaryContainer = new Panel();
            panelTicketsContainer = new Panel();
            btnLogout = new Button();
            tableLayoutPanelSummary.SuspendLayout();
            panelTotalTickets.SuspendLayout();
            panelOpenTickets.SuspendLayout();
            panelInProgress.SuspendLayout();
            panelClosed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentTickets).BeginInit();
            panelSummaryContainer.SuspendLayout();
            panelTicketsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelSummary
            // 
            tableLayoutPanelSummary.ColumnCount = 4;
            tableLayoutPanelSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelSummary.Controls.Add(panelTotalTickets, 0, 0);
            tableLayoutPanelSummary.Controls.Add(panelOpenTickets, 1, 0);
            tableLayoutPanelSummary.Controls.Add(panelInProgress, 2, 0);
            tableLayoutPanelSummary.Controls.Add(panelClosed, 3, 0);
            tableLayoutPanelSummary.Dock = DockStyle.Fill;
            tableLayoutPanelSummary.Location = new Point(10, 10);
            tableLayoutPanelSummary.Name = "tableLayoutPanelSummary";
            tableLayoutPanelSummary.RowCount = 1;
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSummary.Size = new Size(962, 130);
            tableLayoutPanelSummary.TabIndex = 0;
            // 
            // panelTotalTickets
            // 
            panelTotalTickets.BackColor = Color.White;
            panelTotalTickets.BorderStyle = BorderStyle.FixedSingle;
            panelTotalTickets.Controls.Add(lblTotalTitle);
            panelTotalTickets.Controls.Add(lblTotalTickets);
            panelTotalTickets.Dock = DockStyle.Fill;
            panelTotalTickets.Location = new Point(3, 3);
            panelTotalTickets.Name = "panelTotalTickets";
            panelTotalTickets.Padding = new Padding(10);
            panelTotalTickets.Size = new Size(234, 124);
            panelTotalTickets.TabIndex = 0;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Location = new Point(10, 10);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(91, 20);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total Tickets";
            // 
            // lblTotalTickets
            // 
            lblTotalTickets.AutoSize = true;
            lblTotalTickets.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTotalTickets.Location = new Point(10, 35);
            lblTotalTickets.Name = "lblTotalTickets";
            lblTotalTickets.Size = new Size(32, 35);
            lblTotalTickets.TabIndex = 1;
            lblTotalTickets.Text = "0";
            // 
            // panelOpenTickets
            // 
            panelOpenTickets.BackColor = Color.White;
            panelOpenTickets.BorderStyle = BorderStyle.FixedSingle;
            panelOpenTickets.Controls.Add(lblOpenTitle);
            panelOpenTickets.Controls.Add(lblOpenTickets);
            panelOpenTickets.Dock = DockStyle.Fill;
            panelOpenTickets.Location = new Point(243, 3);
            panelOpenTickets.Name = "panelOpenTickets";
            panelOpenTickets.Padding = new Padding(10);
            panelOpenTickets.Size = new Size(234, 124);
            panelOpenTickets.TabIndex = 1;
            // 
            // lblOpenTitle
            // 
            lblOpenTitle.AutoSize = true;
            lblOpenTitle.Location = new Point(10, 10);
            lblOpenTitle.Name = "lblOpenTitle";
            lblOpenTitle.Size = new Size(94, 20);
            lblOpenTitle.TabIndex = 0;
            lblOpenTitle.Text = "Open Tickets";
            // 
            // lblOpenTickets
            // 
            lblOpenTickets.AutoSize = true;
            lblOpenTickets.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblOpenTickets.Location = new Point(10, 35);
            lblOpenTickets.Name = "lblOpenTickets";
            lblOpenTickets.Size = new Size(32, 35);
            lblOpenTickets.TabIndex = 1;
            lblOpenTickets.Text = "0";
            // 
            // panelInProgress
            // 
            panelInProgress.BackColor = Color.White;
            panelInProgress.BorderStyle = BorderStyle.FixedSingle;
            panelInProgress.Controls.Add(lblInProgressTitle);
            panelInProgress.Controls.Add(lblInProgress);
            panelInProgress.Dock = DockStyle.Fill;
            panelInProgress.Location = new Point(483, 3);
            panelInProgress.Name = "panelInProgress";
            panelInProgress.Padding = new Padding(10);
            panelInProgress.Size = new Size(234, 124);
            panelInProgress.TabIndex = 2;
            // 
            // lblInProgressTitle
            // 
            lblInProgressTitle.AutoSize = true;
            lblInProgressTitle.Location = new Point(10, 10);
            lblInProgressTitle.Name = "lblInProgressTitle";
            lblInProgressTitle.Size = new Size(81, 20);
            lblInProgressTitle.TabIndex = 0;
            lblInProgressTitle.Text = "In Progress";
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblInProgress.Location = new Point(10, 35);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(32, 35);
            lblInProgress.TabIndex = 1;
            lblInProgress.Text = "0";
            // 
            // panelClosed
            // 
            panelClosed.BackColor = Color.White;
            panelClosed.BorderStyle = BorderStyle.FixedSingle;
            panelClosed.Controls.Add(lblClosedTitle);
            panelClosed.Controls.Add(lblClosed);
            panelClosed.Dock = DockStyle.Fill;
            panelClosed.Location = new Point(723, 3);
            panelClosed.Name = "panelClosed";
            panelClosed.Padding = new Padding(10);
            panelClosed.Size = new Size(236, 124);
            panelClosed.TabIndex = 3;
            // 
            // lblClosedTitle
            // 
            lblClosedTitle.AutoSize = true;
            lblClosedTitle.Location = new Point(10, 10);
            lblClosedTitle.Name = "lblClosedTitle";
            lblClosedTitle.Size = new Size(54, 20);
            lblClosedTitle.TabIndex = 0;
            lblClosedTitle.Text = "Closed";
            // 
            // lblClosed
            // 
            lblClosed.AutoSize = true;
            lblClosed.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblClosed.Location = new Point(10, 35);
            lblClosed.Name = "lblClosed";
            lblClosed.Size = new Size(32, 35);
            lblClosed.TabIndex = 1;
            lblClosed.Text = "0";
            // 
            // lblRecentTickets
            // 
            lblRecentTickets.AutoSize = true;
            lblRecentTickets.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblRecentTickets.Location = new Point(10, 10);
            lblRecentTickets.Name = "lblRecentTickets";
            lblRecentTickets.Size = new Size(151, 24);
            lblRecentTickets.TabIndex = 1;
            lblRecentTickets.Text = "Recent Tickets";
            // 
            // dataGridViewRecentTickets
            // 
            dataGridViewRecentTickets.AllowUserToAddRows = false;
            dataGridViewRecentTickets.AllowUserToDeleteRows = false;
            dataGridViewRecentTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecentTickets.ColumnHeadersHeight = 29;
            dataGridViewRecentTickets.Dock = DockStyle.Fill;
            dataGridViewRecentTickets.Location = new Point(10, 10);
            dataGridViewRecentTickets.MultiSelect = false;
            dataGridViewRecentTickets.Name = "dataGridViewRecentTickets";
            dataGridViewRecentTickets.ReadOnly = true;
            dataGridViewRecentTickets.RowHeadersVisible = false;
            dataGridViewRecentTickets.RowHeadersWidth = 51;
            dataGridViewRecentTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecentTickets.Size = new Size(962, 383);
            dataGridViewRecentTickets.TabIndex = 0;
            // 
            // panelSummaryContainer
            // 
            panelSummaryContainer.BackColor = Color.LightGray;
            panelSummaryContainer.Controls.Add(btnLogout);
            panelSummaryContainer.Controls.Add(tableLayoutPanelSummary);
            panelSummaryContainer.Dock = DockStyle.Top;
            panelSummaryContainer.Location = new Point(0, 0);
            panelSummaryContainer.Name = "panelSummaryContainer";
            panelSummaryContainer.Padding = new Padding(10);
            panelSummaryContainer.Size = new Size(982, 150);
            panelSummaryContainer.TabIndex = 1;

            // btnLogout
            btnLogout.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLogout.Location = new Point(860, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;
            // 
            // panelTicketsContainer
            // 
            panelTicketsContainer.BackColor = Color.LightGray;
            panelTicketsContainer.Controls.Add(dataGridViewRecentTickets);
            panelTicketsContainer.Controls.Add(lblRecentTickets);
            panelTicketsContainer.Dock = DockStyle.Fill;
            panelTicketsContainer.Location = new Point(0, 150);
            panelTicketsContainer.Name = "panelTicketsContainer";
            panelTicketsContainer.Padding = new Padding(10);
            panelTicketsContainer.Size = new Size(982, 403);
            panelTicketsContainer.TabIndex = 0;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(982, 553);
            Controls.Add(panelTicketsContainer);
            Controls.Add(panelSummaryContainer);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Support Ticket Dashboard";
            Load += DashboardForm_LoadAsync;
            tableLayoutPanelSummary.ResumeLayout(false);
            panelTotalTickets.ResumeLayout(false);
            panelTotalTickets.PerformLayout();
            panelOpenTickets.ResumeLayout(false);
            panelOpenTickets.PerformLayout();
            panelInProgress.ResumeLayout(false);
            panelInProgress.PerformLayout();
            panelClosed.ResumeLayout(false);
            panelClosed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentTickets).EndInit();
            panelSummaryContainer.ResumeLayout(false);
            panelTicketsContainer.ResumeLayout(false);
            panelTicketsContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}