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

        private void LoadData(string search = "")
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
                FROM employees
                WHERE CONCAT(fname, ' ', lname) LIKE @search";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

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

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            LoadData(searchtextBox.Text.Trim());
        }


        private void AddEmployee()
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            string fullName = nametextBox.Text.Trim();
            string[] names = fullName.Split(' ');

            if (names.Length < 2)
            {
                MessageBox.Show("Please enter both first and last name.");
                return;
            }

            string fname = names[0];
            string lname = string.Join(" ", names.Skip(1));
            string email = emailtextBox.Text.Trim();
            string phone = phonenotextBox.Text.Trim();
            string position = positiontextBox.Text.Trim();

            if (fname == "" || lname == "" || email == "" || phone == "" || position == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                INSERT INTO employees (fname, lname, email, phone_num, position)
                VALUES (@fname, @lname, @email, @phone, @position)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@position", position);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee added successfully.");
                        LoadData(); // Refresh table
                        ClearInputs(); // Optionally clear textboxes
                    }
                    else
                    {
                        MessageBox.Show("Failed to add employee.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding employee: " + ex.Message);
                }
            }
        }

        private void ClearInputs()
        {
            nametextBox.Text = "";
            emailtextBox.Text = "";
            phonenotextBox.Text = "";
            positiontextBox.Text = "";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee();
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

                    for (int col = 1; col <= 5; col++) // Loop through the 7 columns
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

        private void Exportbutton_Click(object sender, EventArgs e)
        {
            // Define the template path
            string templatePath = @"C:\Users\KathrynJoy\Documents\3rd Year\2nd Semester\Event Driven Programming\ListofEmployees.xlsx";

            // Get the current date-time for the export filename
            DateTime now = DateTime.Now;
            string mydate = now.ToString("yyyy-MM-dd-HH-mm-ss");

            // Define the path for the exported file
            string newFilePath = @"C:\Users\KathrynJoy\Documents\3rd Year\2nd Semester\Event Driven Programming\Reports\List of Employees Report-" + mydate + ".xlsx";

            // Call the export method with the correct DataGridView (replace 'ordersTable' with your DataGridView name)
            ExportDataGridViewToExcelTemplate(employeesTable, templatePath, newFilePath);
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
            if (employeesTable.CurrentRow != null)
            {
                int id = Convert.ToInt32(employeesTable.CurrentRow.Cells["ID"].Value);
                string name = employeesTable.CurrentRow.Cells["Name"].Value.ToString();
                string email = employeesTable.CurrentRow.Cells["Email"].Value.ToString();
                string phone = employeesTable.CurrentRow.Cells["Phone"].Value.ToString();
                string position = employeesTable.CurrentRow.Cells["Position"].Value.ToString();

                FormEditEmployees editForm = new FormEditEmployees(id, name, email, phone, position);
                editForm.ShowDialog();
                LoadData(); // Refresh after editing
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (employeesTable.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(employeesTable.CurrentRow.Cells["ID"].Value);
                    string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM employees WHERE employees_id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Employee deleted successfully.");
                                    LoadData(); // Refresh the table
                                }
                                else
                                {
                                    MessageBox.Show("Deletion failed. Employee not found.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting employee: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }



    }
}
