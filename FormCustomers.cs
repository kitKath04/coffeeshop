using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
            statuscomboBox.Items.Clear();
            statuscomboBox.Items.Add("All");
            statuscomboBox.Items.Add("Active");
            statuscomboBox.Items.Add("Inactive");
            statuscomboBox.SelectedIndex = 0;

            LoadData();
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

                    var statusCol = new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "Status", ReadOnly = true };
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string fname = FirstNametextBox.Text.Trim();
            string lname = LastNametextBox.Text.Trim();
            string phone = PhoneNotextBox.Text.Trim();
            string email = EmailtextBox.Text.Trim();
            string password = PasswordtextBox.Text;
            string confirmPass = ConfirmPasstextBox.Text;

            // Check if all fields are filled
            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if passwords match
            if (password != confirmPass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Hash the password using SHA256
            string hashedPassword = HashPassword(password);

            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Prepare the insert query
                    string insertQuery = @"
                    INSERT INTO customers (fname, lname, phonenum, email, password, status) 
                    VALUES (@fname, @lname, @phone, @email, @password, 'Active')";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully.");

                    // Clear fields
                    FirstNametextBox.Clear();
                    LastNametextBox.Clear();
                    PhoneNotextBox.Clear();
                    EmailtextBox.Clear();
                    PasswordtextBox.Clear();
                    ConfirmPasstextBox.Clear();

                    LoadData(); // Refresh the table
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add customer: " + ex.Message);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (customersTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = customersTable.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["customers_id"].Value);
                string fname = selectedRow.Cells["fname"].Value.ToString();
                string lname = selectedRow.Cells["lname"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string phone = selectedRow.Cells["phonenum"].Value.ToString();
                string lastLogin = selectedRow.Cells["last_login"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();

                FormEditCustomers editForm = new FormEditCustomers(id, fname, lname, email, phone, lastLogin, status);
                editForm.ShowDialog();

                LoadData(); // Optional: refresh the table after editing
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }


        private void ExportDataGridViewToExcelTemplate(DataGridView dgv, string templatePath, string newfilepath)
        {
            var excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!");
                return;
            }

            excelApp.Visible = false;

            Excel.Workbook workbook = excelApp.Workbooks.Open(templatePath);
            Excel.Worksheet worksheet = workbook.Worksheets[1] as Excel.Worksheet;

            int rowIndex = 4;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        worksheet.Cells[rowIndex, col + 1] = row.Cells[col].Value?.ToString();
                    }

                    for (int col = 1; col <= 6; col++) // Loop through the 7 columns
                    {
                        worksheet.Cells[rowIndex, col].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    }

                    rowIndex++;
                }
            }

            MessageBox.Show($"Data exported to {newfilepath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            excelApp.Visible = true;
            workbook.SaveAs(newfilepath);
            workbook.PrintPreview();
        }

        private void exportbutton_Click(object sender, EventArgs e)
        {
            // Define the template path
            string templatePath = @"C:\Users\KathrynJoy\Documents\3rd Year\2nd Semester\Event Driven Programming\ListofCustomers.xlsx";

            // Get the current date-time for the export filename
            DateTime now = DateTime.Now;
            string mydate = now.ToString("yyyy-MM-dd-HH-mm-ss");

            // Define the path for the exported file
            string newFilePath = @"C:\Users\KathrynJoy\Documents\3rd Year\2nd Semester\Event Driven Programming\Reports\List of Customers Report-" + mydate + ".xlsx";

            // Call the export method with the correct DataGridView (replace 'ordersTable' with your DataGridView name)
            ExportDataGridViewToExcelTemplate(customersTable, templatePath, newFilePath);
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
