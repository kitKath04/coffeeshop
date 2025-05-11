using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Make sure to include this for MySQL

namespace EDP_WinProject
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        // Method to hash passwords
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                // Convert the password to bytes and compute the hash
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Convert byte array to hex string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // Event handler for Sign-Up button
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneNo.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Check if passwords match
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(textBoxPassword.Text);

            // Create the connection string
            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            // Establish the connection
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Define the SQL query to insert new customer
                    string query = @"
                        INSERT INTO customers (fname, lname, phonenum, email, password, status)
                        VALUES (@fname, @lname, @phonenum, @email, @password, 'Active');";

                    // Prepare the command
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fname", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@phonenum", textBoxPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Inform the user
                    MessageBox.Show("Sign-up successful! Please sign in.");

                    // Optionally, you can navigate to another form like the login form after sign-up
                    FormLogin loginForm = new FormLogin();
                    loginForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
