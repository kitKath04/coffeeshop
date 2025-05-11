using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace EDP_WinProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            // Hash the entered password
            string hashedPassword = ComputeSha256Hash(password);

            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // Query to fetch the hashed password stored in the database
                    string query = "SELECT password FROM customers WHERE email = @Email AND status = 'Active'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    string storedHash = cmd.ExecuteScalar() as string;

                    if (storedHash != null && storedHash == hashedPassword)
                    {
                        // Correct password entered, show the dashboard
                        FormDashboard dashboard = new FormDashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password, or account is inactive.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during login: " + ex.Message);
                }
            }
        }


        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                return Convert.ToBase64String(bytes); // This matches what's stored in DB
            }
        }


        private void labelSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp myform = new FormSignUp();
            myform.Show();
            this.Hide();
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            // Show the forgot password form
            FormForgotPassword forgotPasswordForm = new FormForgotPassword();
            forgotPasswordForm.ShowDialog();
        }

    }
}
