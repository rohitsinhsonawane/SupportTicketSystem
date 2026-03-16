namespace SupportTicketSystem.Desktop.Forms
{
    partial class CreateTicketForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSubject = new System.Windows.Forms.Label();
            txtSubject = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            lblPriority = new System.Windows.Forms.Label();
            cmbPriority = new System.Windows.Forms.ComboBox();
            btnCreate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panelButtons = new System.Windows.Forms.Panel();
            panelButtons.SuspendLayout();
            SuspendLayout();

            // lblSubject
            lblSubject.AutoSize = true;
            lblSubject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblSubject.Location = new System.Drawing.Point(20, 20);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new System.Drawing.Size(64, 16);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject:";

            // txtSubject
            txtSubject.Font = new System.Drawing.Font("Arial", 10F);
            txtSubject.Location = new System.Drawing.Point(20, 40);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new System.Drawing.Size(440, 26);
            txtSubject.TabIndex = 1;

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblDescription.Location = new System.Drawing.Point(20, 75);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(89, 16);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";

            // txtDescription
            txtDescription.Font = new System.Drawing.Font("Arial", 10F);
            txtDescription.Location = new System.Drawing.Point(20, 95);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(440, 120);
            txtDescription.TabIndex = 3;

            // lblPriority
            lblPriority.AutoSize = true;
            lblPriority.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            lblPriority.Location = new System.Drawing.Point(20, 225);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new System.Drawing.Size(62, 16);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority:";

            // cmbPriority
            cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPriority.Font = new System.Drawing.Font("Arial", 10F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            cmbPriority.Location = new System.Drawing.Point(20, 245);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new System.Drawing.Size(440, 26);
            cmbPriority.TabIndex = 5;
            cmbPriority.SelectedIndex = 0;

            // panelButtons
            panelButtons.BackColor = System.Drawing.Color.LightGray;
            panelButtons.Controls.Add(btnCreate);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelButtons.Location = new System.Drawing.Point(0, 300);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new System.Windows.Forms.Padding(10);
            panelButtons.Size = new System.Drawing.Size(480, 60);
            panelButtons.TabIndex = 6;

            // btnCreate
            btnCreate.BackColor = System.Drawing.Color.Green;
            btnCreate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnCreate.ForeColor = System.Drawing.Color.White;
            btnCreate.Location = new System.Drawing.Point(300, 8);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(80, 44);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += BtnCreate_Click;

            // btnCancel
            btnCancel.BackColor = System.Drawing.Color.Gray;
            btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(390, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;

            // CreateTicketForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(480, 360);
            Controls.Add(panelButtons);
            Controls.Add(cmbPriority);
            Controls.Add(lblPriority);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtSubject);
            Controls.Add(lblSubject);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateTicketForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Create New Ticket";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
