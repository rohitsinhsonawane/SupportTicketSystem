namespace SupportTicketSystem.Desktop.Forms
{
    partial class TicketsListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Panel panelTopSection;

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
            btnCreateTicket = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            dataGridViewTickets = new System.Windows.Forms.DataGridView();
            panelTopSection = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            panelTopSection.SuspendLayout();
            SuspendLayout();

            // panelTopSection
            panelTopSection.BackColor = System.Drawing.Color.LightGray;
            panelTopSection.Controls.Add(btnRefresh);
            panelTopSection.Controls.Add(btnCreateTicket);
            panelTopSection.Dock = System.Windows.Forms.DockStyle.Top;
            panelTopSection.Location = new System.Drawing.Point(0, 0);
            panelTopSection.Name = "panelTopSection";
            panelTopSection.Padding = new System.Windows.Forms.Padding(10);
            panelTopSection.Size = new System.Drawing.Size(1000, 60);
            panelTopSection.TabIndex = 0;

            // btnCreateTicket
            btnCreateTicket.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnCreateTicket.Location = new System.Drawing.Point(10, 10);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.Size = new System.Drawing.Size(120, 40);
            btnCreateTicket.TabIndex = 0;
            btnCreateTicket.Text = "Create Ticket";
            btnCreateTicket.UseVisualStyleBackColor = true;
            btnCreateTicket.Click += BtnCreateTicket_Click;

            // btnRefresh
            btnRefresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnRefresh.Location = new System.Drawing.Point(140, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(100, 40);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;

            // dataGridViewTickets
            dataGridViewTickets.AllowUserToAddRows = false;
            dataGridViewTickets.AllowUserToDeleteRows = false;
            dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTickets.ColumnHeadersHeight = 29;
            dataGridViewTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewTickets.Location = new System.Drawing.Point(0, 60);
            dataGridViewTickets.MultiSelect = false;
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.ReadOnly = true;
            dataGridViewTickets.RowHeadersVisible = false;
            dataGridViewTickets.RowHeadersWidth = 51;
            dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTickets.Size = new System.Drawing.Size(1000, 540);
            dataGridViewTickets.TabIndex = 0;
            dataGridViewTickets.DoubleClick += DataGridViewTickets_DoubleClick;

            // TicketsListForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1000, 600);
            Controls.Add(dataGridViewTickets);
            Controls.Add(panelTopSection);
            Name = "TicketsListForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Support Tickets";
            Load += TicketsListForm_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            panelTopSection.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
