namespace WindowsFormsDoctor
{
    partial class Login
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
            this.RegStatusLabel = new System.Windows.Forms.Label();
            this.RegConfirmPassLabel = new System.Windows.Forms.Label();
            this.RegPassLabel = new System.Windows.Forms.Label();
            this.RegUsernameLabel = new System.Windows.Forms.Label();
            this.RegLastnameLabel = new System.Windows.Forms.Label();
            this.RegStatusBox = new System.Windows.Forms.ComboBox();
            this.RegUsername = new System.Windows.Forms.TextBox();
            this.RegConfirmPassBox = new System.Windows.Forms.TextBox();
            this.RegLastnameBox = new System.Windows.Forms.TextBox();
            this.RegPassBox = new System.Windows.Forms.TextBox();
            this.RegFirstnameBox = new System.Windows.Forms.TextBox();
            this.LogPassBox = new System.Windows.Forms.TextBox();
            this.LogUsernameBox = new System.Windows.Forms.TextBox();
            this.RegFirstnameLabel = new System.Windows.Forms.Label();
            this.LogPasswordLabel = new System.Windows.Forms.Label();
            this.LogUsernameLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.Register_Label = new System.Windows.Forms.Label();
            this.LogIn_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegStatusLabel
            // 
            this.RegStatusLabel.AutoSize = true;
            this.RegStatusLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.RegStatusLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegStatusLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RegStatusLabel.Location = new System.Drawing.Point(838, 387);
            this.RegStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegStatusLabel.Name = "RegStatusLabel";
            this.RegStatusLabel.Size = new System.Drawing.Size(69, 21);
            this.RegStatusLabel.TabIndex = 46;
            this.RegStatusLabel.Text = "Status";
            // 
            // RegConfirmPassLabel
            // 
            this.RegConfirmPassLabel.AutoSize = true;
            this.RegConfirmPassLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.RegConfirmPassLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegConfirmPassLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RegConfirmPassLabel.Location = new System.Drawing.Point(834, 303);
            this.RegConfirmPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegConfirmPassLabel.Name = "RegConfirmPassLabel";
            this.RegConfirmPassLabel.Size = new System.Drawing.Size(175, 21);
            this.RegConfirmPassLabel.TabIndex = 45;
            this.RegConfirmPassLabel.Text = "Confirm Password";
            // 
            // RegPassLabel
            // 
            this.RegPassLabel.AutoSize = true;
            this.RegPassLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.RegPassLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPassLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RegPassLabel.Location = new System.Drawing.Point(838, 223);
            this.RegPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegPassLabel.Name = "RegPassLabel";
            this.RegPassLabel.Size = new System.Drawing.Size(97, 21);
            this.RegPassLabel.TabIndex = 44;
            this.RegPassLabel.Text = "Password";
            // 
            // RegUsernameLabel
            // 
            this.RegUsernameLabel.AutoSize = true;
            this.RegUsernameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.RegUsernameLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegUsernameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RegUsernameLabel.Location = new System.Drawing.Point(487, 387);
            this.RegUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegUsernameLabel.Name = "RegUsernameLabel";
            this.RegUsernameLabel.Size = new System.Drawing.Size(101, 21);
            this.RegUsernameLabel.TabIndex = 43;
            this.RegUsernameLabel.Text = "Username";
            // 
            // RegLastnameLabel
            // 
            this.RegLastnameLabel.AutoSize = true;
            this.RegLastnameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.RegLastnameLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLastnameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RegLastnameLabel.Location = new System.Drawing.Point(487, 303);
            this.RegLastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegLastnameLabel.Name = "RegLastnameLabel";
            this.RegLastnameLabel.Size = new System.Drawing.Size(99, 21);
            this.RegLastnameLabel.TabIndex = 42;
            this.RegLastnameLabel.Text = "Lastname";
            // 
            // RegStatusBox
            // 
            this.RegStatusBox.FormattingEnabled = true;
            this.RegStatusBox.Items.AddRange(new object[] {
            "C#"});
            this.RegStatusBox.Location = new System.Drawing.Point(838, 410);
            this.RegStatusBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegStatusBox.Name = "RegStatusBox";
            this.RegStatusBox.Size = new System.Drawing.Size(160, 24);
            this.RegStatusBox.TabIndex = 41;
            // 
            // RegUsername
            // 
            this.RegUsername.Location = new System.Drawing.Point(491, 410);
            this.RegUsername.Margin = new System.Windows.Forms.Padding(4);
            this.RegUsername.Multiline = true;
            this.RegUsername.Name = "RegUsername";
            this.RegUsername.Size = new System.Drawing.Size(259, 24);
            this.RegUsername.TabIndex = 40;
            // 
            // RegConfirmPassBox
            // 
            this.RegConfirmPassBox.Location = new System.Drawing.Point(838, 326);
            this.RegConfirmPassBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegConfirmPassBox.Multiline = true;
            this.RegConfirmPassBox.Name = "RegConfirmPassBox";
            this.RegConfirmPassBox.Size = new System.Drawing.Size(263, 24);
            this.RegConfirmPassBox.TabIndex = 39;
            // 
            // RegLastnameBox
            // 
            this.RegLastnameBox.Location = new System.Drawing.Point(487, 326);
            this.RegLastnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegLastnameBox.Multiline = true;
            this.RegLastnameBox.Name = "RegLastnameBox";
            this.RegLastnameBox.Size = new System.Drawing.Size(263, 24);
            this.RegLastnameBox.TabIndex = 38;
            // 
            // RegPassBox
            // 
            this.RegPassBox.Location = new System.Drawing.Point(842, 246);
            this.RegPassBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegPassBox.Multiline = true;
            this.RegPassBox.Name = "RegPassBox";
            this.RegPassBox.Size = new System.Drawing.Size(263, 24);
            this.RegPassBox.TabIndex = 37;
            // 
            // RegFirstnameBox
            // 
            this.RegFirstnameBox.Location = new System.Drawing.Point(487, 246);
            this.RegFirstnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegFirstnameBox.Multiline = true;
            this.RegFirstnameBox.Name = "RegFirstnameBox";
            this.RegFirstnameBox.Size = new System.Drawing.Size(263, 24);
            this.RegFirstnameBox.TabIndex = 36;
            // 
            // LogPassBox
            // 
            this.LogPassBox.Location = new System.Drawing.Point(59, 375);
            this.LogPassBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogPassBox.Multiline = true;
            this.LogPassBox.Name = "LogPassBox";
            this.LogPassBox.Size = new System.Drawing.Size(263, 24);
            this.LogPassBox.TabIndex = 35;
            // 
            // LogUsernameBox
            // 
            this.LogUsernameBox.Location = new System.Drawing.Point(59, 284);
            this.LogUsernameBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogUsernameBox.Multiline = true;
            this.LogUsernameBox.Name = "LogUsernameBox";
            this.LogUsernameBox.Size = new System.Drawing.Size(263, 24);
            this.LogUsernameBox.TabIndex = 34;
            // 
            // RegFirstnameLabel
            // 
            this.RegFirstnameLabel.AutoSize = true;
            this.RegFirstnameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.RegFirstnameLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegFirstnameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RegFirstnameLabel.Location = new System.Drawing.Point(487, 223);
            this.RegFirstnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegFirstnameLabel.Name = "RegFirstnameLabel";
            this.RegFirstnameLabel.Size = new System.Drawing.Size(102, 21);
            this.RegFirstnameLabel.TabIndex = 33;
            this.RegFirstnameLabel.Text = "Firstname";
            // 
            // LogPasswordLabel
            // 
            this.LogPasswordLabel.AutoSize = true;
            this.LogPasswordLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.LogPasswordLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogPasswordLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LogPasswordLabel.Location = new System.Drawing.Point(55, 352);
            this.LogPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogPasswordLabel.Name = "LogPasswordLabel";
            this.LogPasswordLabel.Size = new System.Drawing.Size(97, 21);
            this.LogPasswordLabel.TabIndex = 32;
            this.LogPasswordLabel.Text = "Password";
            // 
            // LogUsernameLabel
            // 
            this.LogUsernameLabel.AutoSize = true;
            this.LogUsernameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.LogUsernameLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogUsernameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LogUsernameLabel.Location = new System.Drawing.Point(54, 261);
            this.LogUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogUsernameLabel.Name = "LogUsernameLabel";
            this.LogUsernameLabel.Size = new System.Drawing.Size(101, 21);
            this.LogUsernameLabel.TabIndex = 31;
            this.LogUsernameLabel.Text = "Username";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.DarkRed;
            this.SignUpButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SignUpButton.Location = new System.Drawing.Point(491, 494);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(176, 78);
            this.SignUpButton.TabIndex = 30;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.DarkRed;
            this.LogInButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogInButton.Location = new System.Drawing.Point(58, 494);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(177, 78);
            this.LogInButton.TabIndex = 29;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            // 
            // Register_Label
            // 
            this.Register_Label.AutoSize = true;
            this.Register_Label.BackColor = System.Drawing.Color.Transparent;
            this.Register_Label.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.Register_Label.Location = new System.Drawing.Point(485, 135);
            this.Register_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Register_Label.Name = "Register_Label";
            this.Register_Label.Size = new System.Drawing.Size(126, 38);
            this.Register_Label.TabIndex = 28;
            this.Register_Label.Text = "Sign Up";
            // 
            // LogIn_Label
            // 
            this.LogIn_Label.AutoSize = true;
            this.LogIn_Label.BackColor = System.Drawing.Color.Transparent;
            this.LogIn_Label.Cursor = System.Windows.Forms.Cursors.Cross;
            this.LogIn_Label.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.LogIn_Label.Location = new System.Drawing.Point(53, 135);
            this.LogIn_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogIn_Label.Name = "LogIn_Label";
            this.LogIn_Label.Size = new System.Drawing.Size(102, 38);
            this.LogIn_Label.TabIndex = 27;
            this.LogIn_Label.Text = "Log In";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsDoctor.Properties.Resources.Anatomy_Engravings_Set;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1210, 687);
            this.Controls.Add(this.RegStatusLabel);
            this.Controls.Add(this.RegConfirmPassLabel);
            this.Controls.Add(this.RegPassLabel);
            this.Controls.Add(this.RegUsernameLabel);
            this.Controls.Add(this.RegLastnameLabel);
            this.Controls.Add(this.RegStatusBox);
            this.Controls.Add(this.RegUsername);
            this.Controls.Add(this.RegConfirmPassBox);
            this.Controls.Add(this.RegLastnameBox);
            this.Controls.Add(this.RegPassBox);
            this.Controls.Add(this.RegFirstnameBox);
            this.Controls.Add(this.LogPassBox);
            this.Controls.Add(this.LogUsernameBox);
            this.Controls.Add(this.RegFirstnameLabel);
            this.Controls.Add(this.LogPasswordLabel);
            this.Controls.Add(this.LogUsernameLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.Register_Label);
            this.Controls.Add(this.LogIn_Label);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegStatusLabel;
        private System.Windows.Forms.Label RegConfirmPassLabel;
        private System.Windows.Forms.Label RegPassLabel;
        private System.Windows.Forms.Label RegUsernameLabel;
        private System.Windows.Forms.Label RegLastnameLabel;
        private System.Windows.Forms.ComboBox RegStatusBox;
        private System.Windows.Forms.TextBox RegUsername;
        private System.Windows.Forms.TextBox RegConfirmPassBox;
        private System.Windows.Forms.TextBox RegLastnameBox;
        private System.Windows.Forms.TextBox RegPassBox;
        private System.Windows.Forms.TextBox RegFirstnameBox;
        private System.Windows.Forms.TextBox LogPassBox;
        private System.Windows.Forms.TextBox LogUsernameBox;
        private System.Windows.Forms.Label RegFirstnameLabel;
        private System.Windows.Forms.Label LogPasswordLabel;
        private System.Windows.Forms.Label LogUsernameLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label Register_Label;
        private System.Windows.Forms.Label LogIn_Label;
    }
}

