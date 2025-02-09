﻿using Npgsql;
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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }
        private void Button_Login_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Validasi untuk memastikan input tidak kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Data salah, isi kembali!");
                return; // Menghentikan eksekusi jika input kosong
            }

            if (IsValidUser(username, password))
            {
                HomePage homepage = new HomePage();

                homepage.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah, isi kembali!");
            }
        }
        private bool IsValidUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM akun WHERE nama_akun = @Username AND password_akun = @Password";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@Username", username),
                new NpgsqlParameter("@Password", password)
            };

            try
            {
                DataTable result = Database_FasilitasGym.queryExecutor(query, parameters);
                int userCount = Convert.ToInt32(result.Rows[0][0]);
                return userCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}

   
