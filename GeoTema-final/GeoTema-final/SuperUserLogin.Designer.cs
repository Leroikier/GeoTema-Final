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
            this.ModifyUserButton = new System.Windows.Forms.Button();
            this.ShowUsersButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SuperUserLoginLabel
            // 
            this.SuperUserLoginLabel.AutoSize = true;
            this.SuperUserLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.SuperUserLoginLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.SuperUserLoginLabel.ForeColor = System.Drawing.Color.White;
            this.SuperUserLoginLabel.Location = new System.Drawing.Point(103, 44);
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
            this.GeoTemaLogoLabel.Location = new System.Drawing.Point(92, 11);
            this.GeoTemaLogoLabel.Name = "GeoTemaLogoLabel";
            this.GeoTemaLogoLabel.Size = new System.Drawing.Size(157, 32);
            this.GeoTemaLogoLabel.TabIndex = 3;
            this.GeoTemaLogoLabel.Text = "GeoTema";
            this.GeoTemaLogoLabel.Click += new System.EventHandler(this.GeoTemaLogoLabel_Click);
            // 
            // ModifyUserButton
            // 
            this.ModifyUserButton.Location = new System.Drawing.Point(35, 118);
            this.ModifyUserButton.Name = "ModifyUserButton";
            this.ModifyUserButton.Size = new System.Drawing.Size(102, 32);
            this.ModifyUserButton.TabIndex = 5;
            this.ModifyUserButton.Text = "Modify User";
            this.ModifyUserButton.UseVisualStyleBackColor = true;
            // 
            // ShowUsersButton
            // 
            this.ShowUsersButton.Location = new System.Drawing.Point(35, 160);
            this.ShowUsersButton.Name = "ShowUsersButton";
            this.ShowUsersButton.Size = new System.Drawing.Size(102, 32);
            this.ShowUsersButton.TabIndex = 6;
            this.ShowUsersButton.Text = "Show Users";
            this.ShowUsersButton.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(210, 237);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(62, 22);
            this.LogOutButton.TabIndex = 7;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SuperUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ShowUsersButton);
            this.Controls.Add(this.ModifyUserButton);
            this.Controls.Add(this.SuperUserLoginLabel);
            this.Controls.Add(this.GeoTemaLogoLabel);
            this.Name = "SuperUserLogin";
            this.Text = "SuperUserLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuperUserLoginLabel;
        private System.Windows.Forms.Label GeoTemaLogoLabel;
        private System.Windows.Forms.Button ModifyUserButton;
        private System.Windows.Forms.Button ShowUsersButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}