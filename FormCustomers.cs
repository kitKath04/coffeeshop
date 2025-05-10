using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EDP_WinProject
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormCustomers_Load);
            searchtextBox.TextChanged += new EventHandler(searchTextBox_TextChanged);
            statuscomboBox.SelectedIndexChanged += new EventHandler(statusComboBox_SelectedIndexChanged);
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            // Add "All", "Active", "Inactive" to the comboBox
            statuscomboBox.Items.Clear();
            statuscomboBox.Items.Add("All");
            statuscomboBox.Items.Add("Active");
            statuscomboBox.Items.Add("Inactive");
            statuscomboBox.SelectedIndex = 0;

            LoadData();
            customersTable.CellValueChanged += customersTable_CellValueChanged;
        }

        private void LoadData(string nameFilter = "", string statusFilter = "")
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                         SELECT 
                                customers_id AS ID, 
                                CONCAT(fname, ' ', lname) AS `Name`,
                                email AS `Email`,
                                phonenum AS `Phone No.`,
                                last_login AS `Last Login`,
                                status AS `Status`
                          FROM customers
                          WHERE CONCAT(fname, ' ', lname) LIKE @nameFilter
                          AND (@statusFilter = '' OR status = @statusFilter)";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@nameFilter", "%" + nameFilter + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@statusFilter", statusFilter);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    customersTable.AutoGenerateColumns = false;
                    customersTable.Columns.Clear();

                    var idCol = new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "ID", ReadOnly = true };
                    customersTable.Columns.Add(idCol);

                    var nameCol = new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Name", DataPropertyName = "Name", ReadOnly = true };
                    customersTable.Columns.Add(nameCol);

                    var emailCol = new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", DataPropertyName = "Email", ReadOnly = true };
                    customersTable.Columns.Add(emailCol);

                    var phoneCol = new DataGridViewTextBoxColumn { Name = "Phone", HeaderText = "Phone No.", DataPropertyName = "Phone No.", ReadOnly = true };
                    customersTable.Columns.Add(phoneCol);

                    var loginCol = new DataGridViewTextBoxColumn { Name = "LastLogin", HeaderText = "Last Login", DataPropertyName = "Last Login", ReadOnly = true };
                    customersTable.Columns.Add(loginCol);

                    var statusCol = new DataGridViewComboBoxColumn
                    {
                        Name = "Status",
                        HeaderText = "Status",
                        DataPropertyName = "Status",
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                        FlatStyle = FlatStyle.Flat
                    };
                    statusCol.Items.AddRange("Active", "Inactive");
                    customersTable.Columns.Add(statusCol);

                    customersTable.DataSource = dt;

                    // Enable editing for Status only
                    customersTable.ReadOnly = false;
                    foreach (DataGridViewColumn col in customersTable.Columns)
                    {
                        if (col.Name != "Status")
                            col.ReadOnly = true;
                    }

                    customersTable.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string nameFilter = searchtextBox.Text.Trim();
            string statusFilter = statuscomboBox.SelectedItem?.ToString() ?? "";

            if (statusFilter == "All") statusFilter = "";

            LoadData(nameFilter, statusFilter);
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameFilter = searchtextBox.Text.Trim();
            string statusFilter = statuscomboBox.SelectedItem?.ToString() ?? "";

            if (statusFilter == "All") statusFilter = "";

            LoadData(nameFilter, statusFilter);
        }

        private void customersTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (customersTable.Columns[e.ColumnIndex].Name == "Status")
            {
                string newStatus = customersTable.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
                int customerId = Convert.ToInt32(customersTable.Rows[e.RowIndex].Cells["ID"].Value);

                string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = "UPDATE customers SET status = @status WHERE customers_id = @id";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", customerId);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update status: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customersTable.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int customerId = Convert.ToInt32(customersTable.CurrentRow.Cells["ID"].Value);

                    string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM customers WHERE customers_id = @id";
                            MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                            cmd.Parameters.AddWithValue("@id", customerId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Customer deleted successfully.");
                            LoadData(); // Refresh table
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to delete customer: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        // Navigation buttons
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard myform = new FormDashboard();
            myform.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FormOrders myform = new FormOrders();
            myform.Show();
            this.Hide();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            FormPayments myform = new FormPayments();
            myform.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormProducts myform = new FormProducts();
            myform.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers myform = new FormCustomers();
            myform.Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormEmployees myform = new FormEmployees();
            myform.Show();
            this.Hide();
        }

        private void btnArchivedOrders_Click(object sender, EventArgs e)
        {
            FormArchivedOrders myform = new FormArchivedOrders();
            myform.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin myform = new FormLogin();
            myform.Show();
            this.Hide();
        }


    }
}
