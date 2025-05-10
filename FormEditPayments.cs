using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP_WinProject
{
    public partial class FormEditPayments : Form
    {
        private string orderId;
        private string amount;
        private string currentPaymentMethod;
        private string currentStatus;

        public FormEditPayments(string orderId, string amount, string paymentMethod, string status)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.amount = amount;
            this.currentPaymentMethod = paymentMethod;
            this.currentStatus = status;

            Load += FormEditPayments_Load;
        }

        private void FormEditPayments_Load(object sender, EventArgs e)
        {
            textBoxOrderID.Text = orderId;
            textBoxAmount.Text = amount;
            textBoxOrderID.Enabled = false;
            textBoxAmount.Enabled = false;

            LoadPaymentMethods();
            LoadStatuses();
        }

        private void LoadPaymentMethods()
        {
            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT method_of_payment FROM payment_method", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    paymentmethodcomboBox.Items.Add(reader.GetString(0));
                }
            }

            paymentmethodcomboBox.SelectedItem = currentPaymentMethod;
        }

        private void LoadStatuses()
        {
            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT status FROM payment_status", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    statuscomboBox.Items.Add(reader.GetString(0));
                }
            }

            statuscomboBox.SelectedItem = currentStatus;
        }

        private int GetIdFromValue(MySqlConnection conn, string table, string valueColumn, string value, string idColumn)
        {
            string query = $"SELECT {idColumn} FROM {table} WHERE {valueColumn} = @value LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@value", value);
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    return id;
                }
                else
                {
                    throw new Exception($"'{value}' not found in {table}.{valueColumn}");
                }
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            FormPayments form = new FormPayments();
            form.Show();
            this.Close(); // or this.Hide() if you want to keep it alive
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedPaymentMethod = paymentmethodcomboBox.SelectedItem?.ToString();
            string selectedStatus = statuscomboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPaymentMethod) || string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Please select both payment method and status.");
                return;
            }

            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    int paymentMethodId = GetIdFromValue(conn, "payment_method", "method_of_payment", selectedPaymentMethod, "paymentmethod_id");
                    int statusId = GetIdFromValue(conn, "payment_status", "status", selectedStatus, "paymentstatus_id");

                    string updateQuery = @"
                        UPDATE payments 
                        SET payment_method = @methodId, payment_status = @statusId 
                        WHERE orders_id = @orderId";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@methodId", paymentMethodId);
                        cmd.Parameters.AddWithValue("@statusId", statusId);
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment updated successfully.");
                    FormPayments form = new FormPayments();
                    form.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving changes: " + ex.Message);
                }
            }
        }
    }
}
