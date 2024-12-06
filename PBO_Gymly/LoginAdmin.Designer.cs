namespace PBO_Gymly
{
    partial class LoginAdmin
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
            Username = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            Password = new Label();
            Button_Login = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(550, 156);
            Username.Name = "Username";
            Username.Size = new Size(106, 28);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.WindowFrame;
            textBoxUsername.Location = new Point(550, 201);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(245, 27);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.WindowFrame;
            textBoxPassword.Location = new Point(550, 313);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(245, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(550, 270);
            Password.Name = "Password";
            Password.Size = new Size(101, 28);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // Button_Login
            // 
            Button_Login.BackColor = Color.FromArgb(127, 200, 248);
            Button_Login.FlatAppearance.BorderSize = 0;
            Button_Login.FlatStyle = FlatStyle.Flat;
            Button_Login.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Login.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Login.Location = new Point(698, 389);
            Button_Login.Margin = new Padding(3, 4, 3, 4);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(90, 48);
            Button_Login.TabIndex = 7;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = true;
            Button_Login.Click += Button_Login_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(127, 200, 248);
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.FromArgb(249, 249, 249);
            buttonExit.Location = new Point(562, 389);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 48);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(Button_Login);
            Controls.Add(Password);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(Username);
            Name = "LoginAdmin";
            Text = "Login Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label Password;
        private Button Button_Login;
        private Button buttonExit;
    }
}