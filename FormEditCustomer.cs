using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP_WinProject
{
    public partial class FormEditCustomers : Form
    {
        private int customerId;

        public FormEditCustomers(int id, string fname, string lname, string email, string phone, string lastLogin, string status)
        {
            InitializeComponent();

            customerId = id;

            // Populate form fields
            textBoxFirstName.Text = fname;
            textBoxLastName.Text = lname;
            textBoxEmail.Text = email;
            textBoxPhoneNo.Text = phone;
            textBoxLastLogin.Text = lastLogin;
            textBoxLastLogin.ReadOnly = true;

            // Status options
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("Active");
            comboBoxStatus.Items.Add("Inactive");
            comboBoxStatus.SelectedItem = status;
        }

        // Discard button - return to customer list without saving
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save button - updates customer data
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = textBoxFirstName.Text.Trim();
            string lname = textBoxLastName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxPhoneNo.Text.Trim();
            string status = comboBoxStatus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string updateQuery = @"
                        UPDATE customers 
                        SET fname = @fname, lname = @lname, email = @email, phonenum = @phone, status = @status 
                        WHERE customers_id = @id";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", customerId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updated successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating customer: " + ex.Message);
                }
            }
        }
    }
}
