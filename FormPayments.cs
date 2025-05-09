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
    public partial class FormPayments : Form
    {
        public FormPayments()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormPayments_Load);
        }

        private void FormPayments_Load(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void LoadPayments()
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
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
                        LEFT JOIN payment_status ps ON p.payment_status = ps.paymentstatus_id";


                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
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
            FormEditPayments myform = new FormEditPayments();
            myform.Show();
            this.Hide();
        }
    }
}
