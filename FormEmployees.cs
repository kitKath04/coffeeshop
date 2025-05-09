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
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormEmployees_Load);
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            LoadData(); // Call data loader
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
                            employees_id AS ID,
                            CONCAT(fname, ' ', lname) AS Name,
                            email AS Email,
                            phone_num AS `Phone No.`,
                            position AS Position
                        FROM employees";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    employeesTable.AutoGenerateColumns = false;
                    employeesTable.Columns.Clear();

                    employeesTable.Columns.Add("ID", "ID");
                    employeesTable.Columns["ID"].DataPropertyName = "ID";

                    employeesTable.Columns.Add("Name", "Name");
                    employeesTable.Columns["Name"].DataPropertyName = "Name";

                    employeesTable.Columns.Add("Email", "Email");
                    employeesTable.Columns["Email"].DataPropertyName = "Email";

                    employeesTable.Columns.Add("Phone", "Phone No.");
                    employeesTable.Columns["Phone"].DataPropertyName = "Phone No.";

                    employeesTable.Columns.Add("Position", "Position");
                    employeesTable.Columns["Position"].DataPropertyName = "Position";

                    employeesTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee data: " + ex.Message);
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
            FormEditEmployees myform = new FormEditEmployees();
            myform.Show();
            this.Hide();
        }

        private void employeesSidebar_Enter(object sender, EventArgs e)
        {

        }
    }
}
