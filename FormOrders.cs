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

namespace EDP_WinProject
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormOrders_Load);
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
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
                    SUM(oi.subtotal_price) AS Amount,
                    o.status AS Status
                FROM orders o
                LEFT JOIN customers c ON o.customers_id = c.customers_id
                LEFT JOIN orders_items oi ON o.orders_id = oi.orders_id
                LEFT JOIN products p ON oi.products_id = p.products_id
                GROUP BY o.orders_id
                ORDER BY o.order_date DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    ordersTable.AutoGenerateColumns = false;
                    ordersTable.Columns.Clear();

                    ordersTable.Columns.Add("ID", "ID");
                    ordersTable.Columns["ID"].DataPropertyName = "ID";

                    ordersTable.Columns.Add("Customer", "Customer");
                    ordersTable.Columns["Customer"].DataPropertyName = "Customer";

                    ordersTable.Columns.Add("OrderItems", "Order Items");
                    ordersTable.Columns["OrderItems"].DataPropertyName = "Order Items";

                    ordersTable.Columns.Add("Date", "Date");
                    ordersTable.Columns["Date"].DataPropertyName = "Date";

                    ordersTable.Columns.Add("Amount", "Amount");
                    ordersTable.Columns["Amount"].DataPropertyName = "Amount";

                    ordersTable.Columns.Add("Status", "Status");
                    ordersTable.Columns["Status"].DataPropertyName = "Status";

                    ordersTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
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
