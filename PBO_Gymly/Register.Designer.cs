namespace PBO_Gymly
{
    partial class Register
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
            TextBoxUsername = new TextBox();
            textBox_Password = new TextBox();
            Label_Username = new Label();
            Password = new Label();
            Button_Daftar = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.BackColor = Color.FromArgb(109, 106, 117);
            TextBoxUsername.BorderStyle = BorderStyle.None;
            TextBoxUsername.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxUsername.ForeColor = Color.FromArgb(249, 249, 249);
            TextBoxUsername.Location = new Point(480, 190);
            TextBoxUsername.Margin = new Padding(3, 4, 3, 4);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(286, 29);
            TextBoxUsername.TabIndex = 3;
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = Color.FromArgb(109, 106, 117);
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            textBox_Password.ForeColor = Color.FromArgb(249, 249, 249);
            textBox_Password.Location = new Point(480, 302);
            textBox_Password.Margin = new Padding(3, 4, 3, 4);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(286, 29);
            textBox_Password.TabIndex = 4;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.BackColor = Color.Transparent;
            Label_Username.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_Username.ForeColor = Color.Black;
            Label_Username.Location = new Point(480, 140);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(129, 35);
            Label_Username.TabIndex = 5;
            Label_Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Password.ForeColor = Color.Black;
            Password.Location = new Point(480, 248);
            Password.Name = "Password";
            Password.Size = new Size(122, 35);
            Password.TabIndex = 6;
            Password.Text = "Password";
            // 
            // Button_Daftar
            // 
            Button_Daftar.BackColor = Color.FromArgb(127, 200, 248);
            Button_Daftar.FlatAppearance.BorderSize = 0;
            Button_Daftar.FlatStyle = FlatStyle.Flat;
            Button_Daftar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Daftar.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Daftar.Location = new Point(667, 370);
            Button_Daftar.Margin = new Padding(3, 4, 3, 4);
            Button_Daftar.Name = "Button_Daftar";
            Button_Daftar.Size = new Size(99, 47);
            Button_Daftar.TabIndex = 7;
            Button_Daftar.Text = "Daftar";
            Button_Daftar.UseVisualStyleBackColor = true;
            Button_Daftar.Click += Button_Daftar_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(127, 200, 248);
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit.ForeColor = Color.FromArgb(249, 249, 249);
            button_exit.Location = new Point(510, 370);
            button_exit.Margin = new Padding(3, 4, 3, 4);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(99, 47);
            button_exit.TabIndex = 8;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_exit);
            Controls.Add(Button_Daftar);
            Controls.Add(Password);
            Controls.Add(Label_Username);
            Controls.Add(textBox_Password);
            Controls.Add(TextBoxUsername);
            Name = "Register";
            Text = "Form Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxUsername;
        private TextBox textBox_Password;
        private Label Label_Username;
        private Label Password;
        private Button Button_Daftar;
        private Button button_exit;
    }
}