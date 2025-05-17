using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace EDP_WinProject
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormOrders_Load);
            ordersTable.CellValueChanged += OrdersTable_CellValueChanged;
            ordersTable.CurrentCellDirtyStateChanged += OrdersTable_CurrentCellDirtyStateChanged;
            searchtextBox.TextChanged += new EventHandler(SearchTextBox_TextChanged);
            statuscomboBox.SelectedIndexChanged += new EventHandler(StatusComboBox_SelectedIndexChanged);
            toolTip1.SetToolTip(exportbutton, "Export orders list");
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // Populate the statusComboBox with status options
            statuscomboBox.Items.Add("All");
            statuscomboBox.Items.Add("Pending");
            statuscomboBox.Items.Add("Completed");
            statuscomboBox.Items.Add("Canceled");
            statuscomboBox.SelectedItem = "All"; // Default to "All"

            LoadOrders();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string customerNameFilter = searchtextBox.Text.Trim();
            LoadOrders(customerNameFilter);
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = statuscomboBox.SelectedItem.ToString();
            LoadOrders(status: selectedStatus);
        }


        private void LoadOrders(string customerNameFilter = "", string status = "All")
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    o.orders_id AS ID,
                    CONCAT(c.fname, ' ', c.lname) AS Customer,
                    GROUP_CONCAT(p.product_name SEPARATOR ', ') AS `Order Items`,
                    o.order_date AS Date,
                    calculate_order_total(o.orders_id) AS Amount,
                    o.status AS Status
                FROM orders o
                LEFT JOIN customers c ON o.customers_id = c.customers_id
                LEFT JOIN orders_items oi ON o.orders_id = oi.orders_id
                LEFT JOIN products p ON oi.products_id = p.products_id
                WHERE CONCAT(c.fname, ' ', c.lname) LIKE @customerNameFilter";

                    if (status != "All")
                    {
                        query += " AND o.status = @status";
                    }

                    query += @"
                GROUP BY o.orders_id
                ORDER BY o.order_date DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@customerNameFilter", "%" + customerNameFilter + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@status", status);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    ordersTable.AutoGenerateColumns = false;
                    ordersTable.Columns.Clear();

                    // Add ID, Customer, Order Items, Date, Amount columns
                    ordersTable.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "ID",
                        HeaderText = "ID",
                        DataPropertyName = "ID",
                        ReadOnly = true
                    });

                    ordersTable.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Customer",
                        HeaderText = "Customer",
                        DataPropertyName = "Customer",
                        ReadOnly = true
                    });

                    ordersTable.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "OrderItems",
                        HeaderText = "Order Items",
                        DataPropertyName = "Order Items",
                        ReadOnly = true
                    });

                    ordersTable.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Date",
                        HeaderText = "Date",
                        DataPropertyName = "Date",
                        ReadOnly = true
                    });

                    ordersTable.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Amount",
                        HeaderText = "Amount",
                        DataPropertyName = "Amount",
                        ReadOnly = true
                    });

                    // Add ComboBox column for Status
                    var statusCol = new DataGridViewComboBoxColumn
                    {
                        Name = "Status",
                        HeaderText = "Status",
                        DataPropertyName = "Status",
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                        FlatStyle = FlatStyle.Flat
                    };
                    statusCol.Items.AddRange("Pending", "Completed", "Canceled");
                    ordersTable.Columns.Add(statusCol);

                    ordersTable.DataSource = dt;

                    // Set all columns ReadOnly
                    ordersTable.ReadOnly = false;
                    foreach (DataGridViewColumn column in ordersTable.Columns)
                    {
                        if (column.Name != "Status") // Only allow editing on Status column
                            column.ReadOnly = true;
                    }

                    ordersTable.EditMode = DataGridViewEditMode.EditOnEnter;
                    ordersTable.Columns["Status"].ReadOnly = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }

        private void OrdersTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (ordersTable.IsCurrentCellDirty)
            {
                ordersTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void OrdersTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ordersTable.Columns[e.ColumnIndex].Name == "Status")
            {
                int orderId = Convert.ToInt32(ordersTable.Rows[e.RowIndex].Cells["ID"].Value);
                string newStatus = ordersTable.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                UpdateOrderStatus(orderId, newStatus);
            }
        }

        private void UpdateOrderStatus(int orderId, string newStatus)
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE orders SET status = @status WHERE orders_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", orderId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message);
                }
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
            string templatePath = @"C:\Users\KathrynJoy\Documents\3rd Year\2nd Semester\Event Driven Programming\ListofOrders.xlsx";

            // Get the current date-time for the export filename
            DateTime now = DateTime.Now;
            string mydate = now.ToString("yyyy-MM-dd-HH-mm-ss");

            // Define the path for the exported file
            string newFilePath = @"C:\Users\KathrynJoy\Documents\3rd Year\2nd Semester\Event Driven Programming\Reports\List of Orders Report-" + mydate + ".xlsx";

            // Call the export method with the correct DataGridView (replace 'ordersTable' with your DataGridView name)
            ExportDataGridViewToExcelTemplate(ordersTable, templatePath, newFilePath);
        }

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEditOrders myform = new FormEditOrders();
            myform.Show();
            this.Hide();
        }
    }
}
