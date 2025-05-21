using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace EDP_WinProject
{
    public partial class FormEditEmployees : Form
    {
        private int employeeId;

        public FormEditEmployees(int id, string name, string email, string phone, string position)
        {
            InitializeComponent();

            employeeId = id;
            textBoxName.Text = name;
            textBoxEmail.Text = email;
            textBoxPhoneNo.Text = phone;
            textBoxPosition.Text = position;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxPhoneNo.Text.Trim();
            string position = textBoxPosition.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Name and Email cannot be empty.");
                return;
            }

            string[] nameParts = name.Split(' ');
            string fname = nameParts[0];
            string lname = nameParts.Length > 1 ? nameParts[1] : "";

            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE employees
                        SET fname = @fname,
                            lname = @lname,
                            email = @Email,
                            phone_num = @Phone,
                            position = @Position
                        WHERE employees_id = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", fname);
                        cmd.Parameters.AddWithValue("@lname", lname);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Position", position);
                        cmd.Parameters.AddWithValue("@ID", employeeId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee updated successfully.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating employee: " + ex.Message);
                }
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
