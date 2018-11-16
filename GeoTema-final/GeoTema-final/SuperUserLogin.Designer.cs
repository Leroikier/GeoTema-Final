namespace GeoTema_final
{
    partial class SuperUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperUserLogin));
            this.SuperUserLoginLabel = new System.Windows.Forms.Label();
            this.GeoTemaLogoLabel = new System.Windows.Forms.Label();
            this.ShowUsersButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ModifyUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SuperUserLoginLabel
            // 
            this.SuperUserLoginLabel.AutoSize = true;
            this.SuperUserLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.SuperUserLoginLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.SuperUserLoginLabel.ForeColor = System.Drawing.Color.White;
            this.SuperUserLoginLabel.Location = new System.Drawing.Point(109, 57);
            this.SuperUserLoginLabel.Name = "SuperUserLoginLabel";
            this.SuperUserLoginLabel.Size = new System.Drawing.Size(136, 17);
            this.SuperUserLoginLabel.TabIndex = 4;
            this.SuperUserLoginLabel.Text = "Super user login";
            this.SuperUserLoginLabel.Click += new System.EventHandler(this.LoginScreenLabel_Click);
            // 
            // GeoTemaLogoLabel
            // 
            this.GeoTemaLogoLabel.AutoSize = true;
            this.GeoTemaLogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.GeoTemaLogoLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.GeoTemaLogoLabel.ForeColor = System.Drawing.Color.White;
            this.GeoTemaLogoLabel.Location = new System.Drawing.Point(98, 24);
            this.GeoTemaLogoLabel.Name = "GeoTemaLogoLabel";
            this.GeoTemaLogoLabel.Size = new System.Drawing.Size(157, 32);
            this.GeoTemaLogoLabel.TabIndex = 3;
            this.GeoTemaLogoLabel.Text = "GeoTema";
            this.GeoTemaLogoLabel.Click += new System.EventHandler(this.GeoTemaLogoLabel_Click);
            // 
            // ShowUsersButton
            // 
            this.ShowUsersButton.Location = new System.Drawing.Point(35, 175);
            this.ShowUsersButton.Name = "ShowUsersButton";
            this.ShowUsersButton.Size = new System.Drawing.Size(102, 32);
            this.ShowUsersButton.TabIndex = 6;
            this.ShowUsersButton.Text = "Show Data";
            this.ShowUsersButton.UseVisualStyleBackColor = true;
            this.ShowUsersButton.Click += new System.EventHandler(this.ShowUsersButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(210, 252);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(62, 22);
            this.LogOutButton.TabIndex = 7;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(139, 252);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(62, 22);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ModifyUserButton
            // 
            this.ModifyUserButton.Location = new System.Drawing.Point(35, 133);
            this.ModifyUserButton.Name = "ModifyUserButton";
            this.ModifyUserButton.Size = new System.Drawing.Size(102, 32);
            this.ModifyUserButton.TabIndex = 5;
            this.ModifyUserButton.Text = "Insert data";
            this.ModifyUserButton.UseVisualStyleBackColor = true;
            this.ModifyUserButton.Click += new System.EventHandler(this.ModifyUserButton_Click);
            // 
            // SuperUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ShowUsersButton);
            this.Controls.Add(this.ModifyUserButton);
            this.Controls.Add(this.SuperUserLoginLabel);
            this.Controls.Add(this.GeoTemaLogoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuperUserLogin";
            this.Text = "SuperUserLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuperUserLoginLabel;
        private System.Windows.Forms.Label GeoTemaLogoLabel;
        private System.Windows.Forms.Button ShowUsersButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ModifyUserButton;
    }
}