using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // Required for MySQL connection
using System.Security.Cryptography;
using System.Text;

namespace EDP_WinProject
{
    public partial class FormResetPassword : Form
    {
        private string userEmail;

        public FormResetPassword(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPass.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();

            // Check if either field is empty
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the new password
            string hashedPassword = HashPassword(newPassword);

            // Update the password in the database
            if (UpdatePasswordInDatabase(userEmail, hashedPassword))
            {
                MessageBox.Show("Password has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the reset password form
                this.Hide();

                // Show the login form after resetting the password
                FormLogin loginForm = new FormLogin();
                loginForm.Show(); // Show the login form
            }
            else
            {
                MessageBox.Show("Failed to reset the password. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to hash the password using SHA-256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Method to update the password in the database
        private bool UpdatePasswordInDatabase(string email, string hashedPassword)
        {
            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // SQL query to update the password
                    string query = "UPDATE customers SET password = @Password WHERE email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;  // Return true if update was successful
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
