﻿using MySql.Data.MySqlClient;
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
    public partial class FormArchivedOrders : Form
    {
        public FormArchivedOrders()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormArchivedOrders_Load);
            searchtextBox.TextChanged += new EventHandler(searchtextBox_TextChanged);
            toolTip1.SetToolTip(exportbutton, "Export archived orders list");
        }

        private void FormArchivedOrders_Load(object sender, EventArgs e)
        {
            LoadArchivedOrders();
        }

        private void LoadArchivedOrders(string nameFilter = "")
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    ao.orders_id AS `Order ID`,
                    CONCAT(c.fname, ' ', c.lname) AS Customer,
                    GROUP_CONCAT(p.product_name SEPARATOR ', ') AS `Order Items`,
                    ao.order_date AS `Order Date`,
                    SUM(oi.subtotal_price) AS Amount,
                    ao.status AS Status,
                    ao.archived_date AS `Archived Date`
                FROM archived_orders ao
                LEFT JOIN customers c ON ao.customers_id = c.customers_id
                LEFT JOIN orders_items oi ON ao.orders_id = oi.orders_id
                LEFT JOIN products p ON oi.products_id = p.products_id
                WHERE CONCAT(c.fname, ' ', c.lname) LIKE @nameFilter
                GROUP BY ao.orders_id
                ORDER BY ao.archived_date DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@nameFilter", "%" + nameFilter + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    archivedordersTable.AutoGenerateColumns = false;
                    archivedordersTable.Columns.Clear();

                    archivedordersTable.Columns.Add("OrderID", "Order ID");
                    archivedordersTable.Columns["OrderID"].DataPropertyName = "Order ID";

                    archivedordersTable.Columns.Add("Customer", "Customer");
                    archivedordersTable.Columns["Customer"].DataPropertyName = "Customer";

                    archivedordersTable.Columns.Add("OrderItems", "Order Items");
                    archivedordersTable.Columns["OrderItems"].DataPropertyName = "Order Items";

                    archivedordersTable.Columns.Add("OrderDate", "Order Date");
                    archivedordersTable.Columns["OrderDate"].DataPropertyName = "Order Date";

                    archivedordersTable.Columns.Add("Amount", "Amount");
                    archivedordersTable.Columns["Amount"].DataPropertyName = "Amount";

                    archivedordersTable.Columns.Add("Status", "Status");
                    archivedordersTable.Columns["Status"].DataPropertyName = "Status";

                    archivedordersTable.Columns.Add("ArchivedDate", "Archived Date");
                    archivedordersTable.Columns["ArchivedDate"].DataPropertyName = "Archived Date";

                    archivedordersTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading archived orders: " + ex.Message);
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (archivedordersTable.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(archivedordersTable.SelectedRows[0].Cells["OrderID"].Value);

                string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand("restore_archived_order", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@archived_id", orderId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Order restored successfully.");

                        LoadArchivedOrders();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error restoring order: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an order to restore.");
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

                    for (int col = 1; col <= 7; col++)
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
            string templatePath = Application.StartupPath + @"\reportTemplate\ListofArchivedOrders.xlsx";

            DateTime now = DateTime.Now;
            string mydate = now.ToString("yyyy-MM-dd-HH-mm-ss");

            string newFilePath = Application.StartupPath + @"\generatedReports\List of Archived Orders Report-" + mydate + ".xlsx";

            ExportDataGridViewToExcelTemplate(archivedordersTable, templatePath, newFilePath);
        }


        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string nameFilter = searchtextBox.Text.Trim();
            LoadArchivedOrders(nameFilter);
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
    }
}
