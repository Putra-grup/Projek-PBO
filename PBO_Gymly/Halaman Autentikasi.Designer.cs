namespace PBO_Gymly
{
    partial class Autentikasi
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
            Button_Register = new Button();
            Button_Login = new Button();
            Label_Username = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Button_Register
            // 
            Button_Register.BackColor = Color.FromArgb(127, 200, 248);
            Button_Register.FlatAppearance.BorderSize = 0;
            Button_Register.FlatStyle = FlatStyle.Flat;
            Button_Register.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Register.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Register.Location = new Point(299, 127);
            Button_Register.Margin = new Padding(3, 4, 3, 4);
            Button_Register.Name = "Button_Register";
            Button_Register.Size = new Size(166, 53);
            Button_Register.TabIndex = 6;
            Button_Register.Text = "Register";
            Button_Register.UseVisualStyleBackColor = true;
            Button_Register.Click += Button_Customer_Click;
            // 
            // Button_Login
            // 
            Button_Login.BackColor = Color.FromArgb(127, 200, 248);
            Button_Login.FlatAppearance.BorderSize = 0;
            Button_Login.FlatStyle = FlatStyle.Flat;
            Button_Login.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Login.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Login.Location = new Point(299, 222);
            Button_Login.Margin = new Padding(3, 4, 3, 4);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(166, 53);
            Button_Login.TabIndex = 7;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = true;
            Button_Login.Click += Button_Login_Click;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.BackColor = Color.Transparent;
            Label_Username.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_Username.ForeColor = Color.Black;
            Label_Username.Location = new Point(33, 127);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(0, 35);
            Label_Username.TabIndex = 8;
            Label_Username.Click += Label_Username_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 240);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(322, 50);
            label2.Name = "label2";
            label2.Size = new Size(124, 35);
            label2.TabIndex = 10;
            label2.Text = "Pilih Satu";
            // 
            // Autentikasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Label_Username);
            Controls.Add(Button_Login);
            Controls.Add(Button_Register);
            Name = "Autentikasi";
            Text = "Halaman Autentikasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Register;
        private Button Button_Login;
        private Label Label_Username;
        private Label label1;
        private Label label2;
    }
}