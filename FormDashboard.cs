using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EDP_WinProject
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormDashboard_Load);
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            string connStr = "server=localhost;user=root;password=kath2003;database=coffeeshop;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Total Sales
                    MySqlCommand cmdTotalSales = new MySqlCommand("SELECT IFNULL(SUM(subtotal_price), 0) FROM orders_items", conn);
                    labelTotalSales.Text = "₱" + Convert.ToDecimal(cmdTotalSales.ExecuteScalar()).ToString("N2");

                    // Total Orders
                    MySqlCommand cmdTotalOrders = new MySqlCommand("SELECT COUNT(*) FROM orders", conn);
                    labelTotalOrders.Text = cmdTotalOrders.ExecuteScalar().ToString();

                    // Total Products Sold
                    MySqlCommand cmdProductsSold = new MySqlCommand("SELECT IFNULL(SUM(quantity), 0) FROM orders_items", conn);
                    labelTotalProductsSold.Text = cmdProductsSold.ExecuteScalar().ToString();

                    // Total Products
                    MySqlCommand cmdTotalProducts = new MySqlCommand("SELECT COUNT(*) FROM products", conn);
                    labelTotalProducts.Text = cmdTotalProducts.ExecuteScalar().ToString();

                    // Active Customers
                    MySqlCommand cmdActiveCustomers = new MySqlCommand("SELECT COUNT(*) FROM customers WHERE status = 'Active'", conn);
                    labelActiveCustomer.Text = cmdActiveCustomers.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dashboard data: " + ex.Message);
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
    }
}
