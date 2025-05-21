using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace EDP_WinProject
{
    public partial class FormPayments : Form
    {
        public FormPayments()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormPayments_Load);
            paymentmethodcomboBox.SelectedIndexChanged += new EventHandler(paymentmethodcomboBox_SelectedIndexChanged);
            statuscomboBox.SelectedIndexChanged += new EventHandler(statuscomboBox_SelectedIndexChanged);
            toolTip1.SetToolTip(exportbutton, "Export payments list");
        }

        private void FormPayments_Load(object sender, EventArgs e)
        {
            LoadPaymentMethodsFilter();
            LoadStatusFilter();
            LoadPayments();
        }

        private void LoadPayments()
        {
            string selectedMethod = paymentmethodcomboBox.SelectedItem?.ToString();
            string selectedStatus = statuscomboBox.SelectedItem?.ToString();

            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        p.payments_id AS ID,
                        o.orders_id AS `Order ID`,
                        oi.subtotal_price AS Amount,
                        pm.method_of_payment AS `Payment Method`,
                        ps.status AS Status
                    FROM payments p
                    LEFT JOIN orders o ON p.orders_id = o.orders_id 
                    LEFT JOIN orders_items oi ON p.ordersitems_id = oi.ordersitems_id
                    LEFT JOIN payment_method pm ON p.payment_method = pm.paymentmethod_id
                    LEFT JOIN payment_status ps ON p.payment_status = ps.paymentstatus_id
                    WHERE (@method = 'All' OR pm.method_of_payment = @method)
                      AND (@status = 'All' OR ps.status = @status)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@method", selectedMethod ?? "All");
                    cmd.Parameters.AddWithValue("@status", selectedStatus ?? "All");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    paymentsTable.AutoGenerateColumns = false;
                    paymentsTable.Columns.Clear();

                    paymentsTable.Columns.Add("ID", "ID");
                    paymentsTable.Columns["ID"].DataPropertyName = "ID";

                    paymentsTable.Columns.Add("OrderID", "Order ID");
                    paymentsTable.Columns["OrderID"].DataPropertyName = "Order ID";

                    paymentsTable.Columns.Add("Amount", "Amount");
                    paymentsTable.Columns["Amount"].DataPropertyName = "Amount";

                    paymentsTable.Columns.Add("PaymentMethod", "Payment Method");
                    paymentsTable.Columns["PaymentMethod"].DataPropertyName = "Payment Method";

                    paymentsTable.Columns.Add("Status", "Status");
                    paymentsTable.Columns["Status"].DataPropertyName = "Status";

                    paymentsTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading payments: " + ex.Message);
                }
            }
        }

        private void LoadPaymentMethodsFilter()
        {
            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT method_of_payment FROM payment_method", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                paymentmethodcomboBox.Items.Clear();
                paymentmethodcomboBox.Items.Add("All");
                while (reader.Read())
                {
                    paymentmethodcomboBox.Items.Add(reader.GetString(0));
                }
                paymentmethodcomboBox.SelectedIndex = 0;
            }
        }

        private void LoadStatusFilter()
        {
            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT status FROM payment_status", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                statuscomboBox.Items.Clear();
                statuscomboBox.Items.Add("All");
                while (reader.Read())
                {
                    statuscomboBox.Items.Add(reader.GetString(0));
                }
                statuscomboBox.SelectedIndex = 0;
            }
        }

        private void paymentmethodcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void statuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayments();
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

                    for (int col = 1; col <= 5; col++)
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
            string templatePath = @"C:\Users\KathrynJoy\Documents\3rd Year\2nd Semester\Event Driven Programming\ListofPayments.xlsx";

            DateTime now = DateTime.Now;
            string mydate = now.ToString("yyyy-MM-dd-HH-mm-ss");

            string newFilePath = @"C:\Users\KathrynJoy\Documents\3rd Year\2nd Semester\Event Driven Programming\Reports\List of Payments Report-" + mydate + ".xlsx";

            ExportDataGridViewToExcelTemplate(paymentsTable, templatePath, newFilePath);
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
            if (paymentsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow row = paymentsTable.SelectedRows[0];
                string orderId = row.Cells["OrderID"].Value.ToString();
                string amount = row.Cells["Amount"].Value.ToString();
                string paymentMethod = row.Cells["PaymentMethod"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                FormEditPayments editForm = new FormEditPayments(orderId, amount, paymentMethod, status);
                editForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a payment to edit.");
            }
        }
    }
}
