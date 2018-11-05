namespace GeoTema_final
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.GeoTemaLogoLabel = new System.Windows.Forms.Label();
            this.LoginScreenLabel = new System.Windows.Forms.Label();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.ResetPasswordButton = new System.Windows.Forms.Button();
            this.ModifyUserButton = new System.Windows.Forms.Button();
            this.ShowUsersButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GeoTemaLogoLabel
            // 
            this.GeoTemaLogoLabel.AutoSize = true;
            this.GeoTemaLogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.GeoTemaLogoLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.GeoTemaLogoLabel.ForeColor = System.Drawing.Color.White;
            this.GeoTemaLogoLabel.Location = new System.Drawing.Point(61, 10);
            this.GeoTemaLogoLabel.Name = "GeoTemaLogoLabel";
            this.GeoTemaLogoLabel.Size = new System.Drawing.Size(157, 32);
            this.GeoTemaLogoLabel.TabIndex = 1;
            this.GeoTemaLogoLabel.Text = "GeoTema";
            this.GeoTemaLogoLabel.Click += new System.EventHandler(this.GeoTemaLogoLabel_Click);
            // 
            // LoginScreenLabel
            // 
            this.LoginScreenLabel.AutoSize = true;
            this.LoginScreenLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginScreenLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.LoginScreenLabel.ForeColor = System.Drawing.Color.White;
            this.LoginScreenLabel.Location = new System.Drawing.Point(42, 43);
            this.LoginScreenLabel.Name = "LoginScreenLabel";
            this.LoginScreenLabel.Size = new System.Drawing.Size(195, 17);
            this.LoginScreenLabel.TabIndex = 2;
            this.LoginScreenLabel.Text = "Admin user login screen";
            this.LoginScreenLabel.Click += new System.EventHandler(this.LoginScreenLabel_Click);
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(42, 81);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(102, 32);
            this.CreateUserButton.TabIndex = 3;
            this.CreateUserButton.Text = "Create User";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.Location = new System.Drawing.Point(42, 121);
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.Size = new System.Drawing.Size(102, 32);
            this.ResetPasswordButton.TabIndex = 3;
            this.ResetPasswordButton.Text = "Reset Password";
            this.ResetPasswordButton.UseVisualStyleBackColor = true;
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // ModifyUserButton
            // 
            this.ModifyUserButton.Location = new System.Drawing.Point(42, 162);
            this.ModifyUserButton.Name = "ModifyUserButton";
            this.ModifyUserButton.Size = new System.Drawing.Size(102, 32);
            this.ModifyUserButton.TabIndex = 3;
            this.ModifyUserButton.Text = "Modify User";
            this.ModifyUserButton.UseVisualStyleBackColor = true;
            this.ModifyUserButton.Click += new System.EventHandler(this.ModifyUserButton_Click);
            // 
            // ShowUsersButton
            // 
            this.ShowUsersButton.Location = new System.Drawing.Point(43, 203);
            this.ShowUsersButton.Name = "ShowUsersButton";
            this.ShowUsersButton.Size = new System.Drawing.Size(102, 32);
            this.ShowUsersButton.TabIndex = 3;
            this.ShowUsersButton.Text = "Show Users";
            this.ShowUsersButton.UseVisualStyleBackColor = true;
            this.ShowUsersButton.Click += new System.EventHandler(this.ShowUsersButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(210, 237);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(62, 22);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.ShowUsersButton);
            this.Controls.Add(this.ModifyUserButton);
            this.Controls.Add(this.ResetPasswordButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.LoginScreenLabel);
            this.Controls.Add(this.GeoTemaLogoLabel);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GeoTemaLogoLabel;
        private System.Windows.Forms.Label LoginScreenLabel;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Button ResetPasswordButton;
        private System.Windows.Forms.Button ModifyUserButton;
        private System.Windows.Forms.Button ShowUsersButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}