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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormCustomers_Load);
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
            FormEditCustomers myform = new FormEditCustomers();
            myform.Show();
            this.Hide();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            LoadData(); // Load customer data when form loads
        }
        private void LoadData()
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
                    CONCAT(fname, ' ', lname) AS Name,
                    email AS Email,
                    phonenum AS `Phone No.`,
                    last_login AS `Last Login`,
                    status AS Status
                FROM customers";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    customersTable.AutoGenerateColumns = false;
                    customersTable.Columns.Clear();

                    customersTable.Columns.Add("ID", "ID");
                    customersTable.Columns["ID"].DataPropertyName = "ID";

                    customersTable.Columns.Add("Name", "Name");
                    customersTable.Columns["Name"].DataPropertyName = "Name";

                    customersTable.Columns.Add("Email", "Email");
                    customersTable.Columns["Email"].DataPropertyName = "Email";

                    customersTable.Columns.Add("Phone", "Phone No.");
                    customersTable.Columns["Phone"].DataPropertyName = "Phone No.";

                    customersTable.Columns.Add("LastLogin", "Last Login");
                    customersTable.Columns["LastLogin"].DataPropertyName = "Last Login";

                    customersTable.Columns.Add("Status", "Status");
                    customersTable.Columns["Status"].DataPropertyName = "Status";

                    customersTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


    }
}
