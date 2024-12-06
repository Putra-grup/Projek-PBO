namespace PBO_Gymly
{
    partial class LandingPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Button_Customer = new Button();
            buttonAdmin = new Button();
            Label_Username = new Label();
            SuspendLayout();
            // 
            // Button_Customer
            // 
            Button_Customer.BackColor = Color.FromArgb(127, 200, 248);
            Button_Customer.FlatAppearance.BorderSize = 0;
            Button_Customer.FlatStyle = FlatStyle.Flat;
            Button_Customer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Customer.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Customer.Location = new Point(318, 250);
            Button_Customer.Margin = new Padding(3, 4, 3, 4);
            Button_Customer.Name = "Button_Customer";
            Button_Customer.Size = new Size(166, 53);
            Button_Customer.TabIndex = 5;
            Button_Customer.Text = "Customer";
            Button_Customer.UseVisualStyleBackColor = true;
            Button_Customer.Click += Button_Customer_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.FromArgb(127, 200, 248);
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdmin.ForeColor = Color.FromArgb(249, 249, 249);
            buttonAdmin.Location = new Point(318, 163);
            buttonAdmin.Margin = new Padding(3, 4, 3, 4);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(166, 53);
            buttonAdmin.TabIndex = 6;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.BackColor = Color.Transparent;
            Label_Username.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_Username.ForeColor = Color.Black;
            Label_Username.Location = new Point(275, 61);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(245, 35);
            Label_Username.TabIndex = 7;
            Label_Username.Text = "Pilih Masuk Sebagai";
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_Username);
            Controls.Add(buttonAdmin);
            Controls.Add(Button_Customer);
            Name = "LandingPage";
            Text = "LandingPage";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button Button_Customer;
        private Button buttonAdmin;
        private Label Label_Username;
    }
}
