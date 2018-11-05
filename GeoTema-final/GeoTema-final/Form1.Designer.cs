namespace GeoTema_final
{
    partial class LoginScreenStandard
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GeoTemaLogoLabel
            // 
            this.GeoTemaLogoLabel.AutoSize = true;
            this.GeoTemaLogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.GeoTemaLogoLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.GeoTemaLogoLabel.ForeColor = System.Drawing.Color.White;
            this.GeoTemaLogoLabel.Location = new System.Drawing.Point(53, 13);
            this.GeoTemaLogoLabel.Name = "GeoTemaLogoLabel";
            this.GeoTemaLogoLabel.Size = new System.Drawing.Size(157, 32);
            this.GeoTemaLogoLabel.TabIndex = 0;
            this.GeoTemaLogoLabel.Text = "GeoTema";
            // 
            // LoginScreenLabel
            // 
            this.LoginScreenLabel.AutoSize = true;
            this.LoginScreenLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginScreenLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.LoginScreenLabel.ForeColor = System.Drawing.Color.White;
            this.LoginScreenLabel.Location = new System.Drawing.Point(78, 44);
            this.LoginScreenLabel.Name = "LoginScreenLabel";
            this.LoginScreenLabel.Size = new System.Drawing.Size(109, 17);
            this.LoginScreenLabel.TabIndex = 0;
            this.LoginScreenLabel.Text = "Login Screen";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(25, 110);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(81, 17);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username :";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(29, 152);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(77, 17);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(107, 204);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(57, 24);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // LoginScreenStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginScreenLabel);
            this.Controls.Add(this.GeoTemaLogoLabel);
            this.Name = "LoginScreenStandard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GeoTemaLogoLabel;
        private System.Windows.Forms.Label LoginScreenLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button LoginButton;
    }
}

