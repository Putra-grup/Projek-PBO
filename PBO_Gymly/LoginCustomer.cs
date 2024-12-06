using Npgsql;
using PBO_Gymly.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Gymly
{
    public partial class LoginCustomer : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=putra23;Database=Project PBO Gymly";
        public LoginCustomer()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT password FROM users WHERE username = @username";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string storedPassword = result.ToString(); // Ambil password dari database

                            // Periksa kecocokan password secara langsung
                            if (password == storedPassword)
                            {
                                MessageBox.Show("Login berhasil!");
                                // Redirect ke halaman utama
                                HomePage homePage = new HomePage(); // Ganti dengan form halaman utama Anda
                                this.Hide();
                                homePage.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Password salah.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username tidak ditemukan.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
