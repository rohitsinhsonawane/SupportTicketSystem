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
        private System.Windows.Forms.Button btnLogout;
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
            btnCreateTicket = new Button();
            btnRefresh = new Button();
            btnLogout = new Button();
            dataGridViewTickets = new DataGridView();
            panelTopSection = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            panelTopSection.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateTicket
            // 
            btnCreateTicket.BackColor = Color.Green;
            btnCreateTicket.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCreateTicket.ForeColor = Color.White;
            btnCreateTicket.Location = new Point(10, 10);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.Size = new Size(120, 40);
            btnCreateTicket.TabIndex = 0;
            btnCreateTicket.Text = "Create Ticket";
            btnCreateTicket.UseVisualStyleBackColor = false;
            btnCreateTicket.Click += BtnCreateTicket_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnRefresh.Location = new Point(140, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 40);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLogout.Location = new Point(860, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.AllowUserToAddRows = false;
            dataGridViewTickets.AllowUserToDeleteRows = false;
            dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTickets.ColumnHeadersHeight = 29;
            dataGridViewTickets.Dock = DockStyle.Fill;
            dataGridViewTickets.Location = new Point(0, 60);
            dataGridViewTickets.MultiSelect = false;
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.ReadOnly = true;
            dataGridViewTickets.RowHeadersVisible = false;
            dataGridViewTickets.RowHeadersWidth = 51;
            dataGridViewTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTickets.Size = new Size(1000, 540);
            dataGridViewTickets.TabIndex = 0;
            dataGridViewTickets.DoubleClick += DataGridViewTickets_DoubleClick;
            // 
            // panelTopSection
            // 
            panelTopSection.BackColor = Color.LightGray;
            panelTopSection.Controls.Add(btnLogout);
            panelTopSection.Controls.Add(btnRefresh);
            panelTopSection.Controls.Add(btnCreateTicket);
            panelTopSection.Dock = DockStyle.Top;
            panelTopSection.Location = new Point(0, 0);
            panelTopSection.Name = "panelTopSection";
            panelTopSection.Padding = new Padding(10);
            panelTopSection.Size = new Size(1000, 60);
            panelTopSection.TabIndex = 0;
            // 
            // TicketsListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(dataGridViewTickets);
            Controls.Add(panelTopSection);
            Name = "TicketsListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Support Tickets";
            Load += TicketsListForm_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            panelTopSection.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
