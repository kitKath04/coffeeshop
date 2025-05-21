using System;
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

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower(); 
            }
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

            string hashedPassword = ComputeSha256Hash(password);

            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT customers_id FROM customers WHERE email = @Email AND password = @Password AND status = 'Active'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int customerId = Convert.ToInt32(result);

                        string updateQuery = "UPDATE customers SET last_login = NOW() WHERE customers_id = @Id";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@Id", customerId);
                        updateCmd.ExecuteNonQuery();

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

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp myform = new FormSignUp();
            myform.Show();
            this.Hide();
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormForgotPassword forgotPasswordForm = new FormForgotPassword();
            forgotPasswordForm.ShowDialog();
        }
    }
}
