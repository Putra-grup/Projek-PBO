namespace PBO_Gymly
{
    partial class LoginCustomer
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
            label1 = new Label();
            textBoxUsername = new TextBox();
            Password = new Label();
            textBoxPassword = new TextBox();
            Button_Login = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(555, 138);
            Username.Name = "Username";
            Username.Size = new Size(106, 28);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 211);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.WindowFrame;
            textBoxUsername.Location = new Point(555, 200);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(233, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(555, 260);
            Password.Name = "Password";
            Password.Size = new Size(101, 28);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.WindowFrame;
            textBoxPassword.Location = new Point(555, 317);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(233, 27);
            textBoxPassword.TabIndex = 5;
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
            Button_Login.TabIndex = 8;
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
            buttonExit.Location = new Point(567, 389);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 48);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // LoginCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(Button_Login);
            Controls.Add(textBoxPassword);
            Controls.Add(Password);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(Username);
            Name = "LoginCustomer";
            Text = "LoginCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label label1;
        private TextBox textBoxUsername;
        private Label Password;
        private TextBox textBoxPassword;
        private Button Button_Login;
        private Button buttonExit;
    }
}