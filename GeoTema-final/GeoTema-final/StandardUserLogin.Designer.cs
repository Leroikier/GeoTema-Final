namespace GeoTema_final
{
    partial class StandardUserLogin
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
            this.LoginScreenLabel = new System.Windows.Forms.Label();
            this.GeoTemaLogoLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ShowUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginScreenLabel
            // 
            this.LoginScreenLabel.AutoSize = true;
            this.LoginScreenLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginScreenLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.LoginScreenLabel.ForeColor = System.Drawing.Color.White;
            this.LoginScreenLabel.Location = new System.Drawing.Point(35, 41);
            this.LoginScreenLabel.Name = "LoginScreenLabel";
            this.LoginScreenLabel.Size = new System.Drawing.Size(217, 17);
            this.LoginScreenLabel.TabIndex = 6;
            this.LoginScreenLabel.Text = "Standard user login screen";
            // 
            // GeoTemaLogoLabel
            // 
            this.GeoTemaLogoLabel.AutoSize = true;
            this.GeoTemaLogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.GeoTemaLogoLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.GeoTemaLogoLabel.ForeColor = System.Drawing.Color.White;
            this.GeoTemaLogoLabel.Location = new System.Drawing.Point(66, 9);
            this.GeoTemaLogoLabel.Name = "GeoTemaLogoLabel";
            this.GeoTemaLogoLabel.Size = new System.Drawing.Size(157, 32);
            this.GeoTemaLogoLabel.TabIndex = 5;
            this.GeoTemaLogoLabel.Text = "GeoTema";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(210, 237);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(62, 22);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            // 
            // ShowUsersButton
            // 
            this.ShowUsersButton.Location = new System.Drawing.Point(37, 138);
            this.ShowUsersButton.Name = "ShowUsersButton";
            this.ShowUsersButton.Size = new System.Drawing.Size(102, 32);
            this.ShowUsersButton.TabIndex = 8;
            this.ShowUsersButton.Text = "Show Users";
            this.ShowUsersButton.UseVisualStyleBackColor = true;
            // 
            // StandardUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ShowUsersButton);
            this.Controls.Add(this.LoginScreenLabel);
            this.Controls.Add(this.GeoTemaLogoLabel);
            this.Name = "StandardUserLogin";
            this.Text = "StandardUserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginScreenLabel;
        private System.Windows.Forms.Label GeoTemaLogoLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ShowUsersButton;
    }
}