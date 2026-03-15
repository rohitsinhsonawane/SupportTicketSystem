namespace SupportTicketSystem.Desktop.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;

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
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            lblError = new System.Windows.Forms.Label();
            SuspendLayout();

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Arial", 10F);
            lblUsername.Location = new System.Drawing.Point(50, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(75, 16);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";

            // txtUsername
            txtUsername.Font = new System.Drawing.Font("Arial", 10F);
            txtUsername.Location = new System.Drawing.Point(50, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(250, 23);
            txtUsername.TabIndex = 1;

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Arial", 10F);
            lblPassword.Location = new System.Drawing.Point(50, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(70, 16);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";

            // txtPassword
            txtPassword.Font = new System.Drawing.Font("Arial", 10F);
            txtPassword.Location = new System.Drawing.Point(50, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(250, 23);
            txtPassword.TabIndex = 3;

            // btnLogin
            btnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btnLogin.Location = new System.Drawing.Point(50, 180);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(250, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;

            // lblError
            lblError.AutoSize = true;
            lblError.Font = new System.Drawing.Font("Arial", 9F);
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(50, 230);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(0, 15);
            lblError.TabIndex = 5;
            lblError.Text = "";

            // LoginForm
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(350, 280);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Support Ticket System - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
