using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EDP_WinProject
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormProducts_Load);
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

            productsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            searchtextBox.TextChanged += searchTextBox_TextChanged;

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(searchtextBox.Text);
        }


        private void LoadProducts(string search = "", int? categoryId = null)
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    p.products_id AS ID,
                    p.product_name AS `Product Name`,
                    c.category_name AS Category,
                    p.price AS Price,
                    p.stock AS Stock
                FROM products p
                LEFT JOIN category c ON p.category_id = c.category_id
                WHERE (@search = '' OR p.product_name LIKE @searchPattern)
                AND (@categoryId IS NULL OR p.category_id = @categoryId)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", search);
                        cmd.Parameters.AddWithValue("@searchPattern", "%" + search + "%");

                        if (categoryId.HasValue)
                            cmd.Parameters.AddWithValue("@categoryId", categoryId.Value);
                        else
                            cmd.Parameters.AddWithValue("@categoryId", DBNull.Value);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        productsTable.AutoGenerateColumns = false;
                        productsTable.Columns.Clear();

                        productsTable.Columns.Add("ID", "ID");
                        productsTable.Columns["ID"].DataPropertyName = "ID";

                        productsTable.Columns.Add("ProductName", "Product Name");
                        productsTable.Columns["ProductName"].DataPropertyName = "Product Name";

                        productsTable.Columns.Add("Category", "Category");
                        productsTable.Columns["Category"].DataPropertyName = "Category";

                        productsTable.Columns.Add("Price", "Price");
                        productsTable.Columns["Price"].DataPropertyName = "Price";

                        productsTable.Columns.Add("Stock", "Stock");
                        productsTable.Columns["Stock"].DataPropertyName = "Stock";

                        productsTable.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count > 0)
            {
                // Get the selected product ID
                int productId = Convert.ToInt32(productsTable.SelectedRows[0].Cells["ID"].Value);

                // Open the FormEditProducts with the selected product ID
                FormEditProducts myform = new FormEditProducts(productId);
                myform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
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

        private void LoadCategories()
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT category_id, category_name FROM category";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        categorycomboBox.DisplayMember = "category_name";   // what user sees
                        categorycomboBox.ValueMember = "category_id";       // actual ID
                        categorycomboBox.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load categories: " + ex.Message);
                }
            }
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductNametextBox.Text) ||
                string.IsNullOrWhiteSpace(PricetextBox.Text) ||
                string.IsNullOrWhiteSpace(StocktextBox.Text) ||
                categorycomboBox.SelectedValue == null)
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO products (product_name, category_id, price, stock) 
                             VALUES (@name, @categoryId, @price, @stock)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", ProductNametextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@categoryId", Convert.ToInt32(categorycomboBox.SelectedValue));
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(PricetextBox.Text.Trim()));
                        cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(StocktextBox.Text.Trim()));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product added successfully.");
                        LoadProducts();

                        // Clear text fields
                        ProductNametextBox.Text = "";
                        PricetextBox.Text = "";
                        StocktextBox.Text = "";

                        // Reset ComboBox to first item (optional)
                        if (categorycomboBox.Items.Count > 0)
                        {
                            categorycomboBox.SelectedIndex = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (productsTable.SelectedRows.Count > 0)
            {
                // Get the selected product's ID
                int productId = Convert.ToInt32(productsTable.SelectedRows[0].Cells["ID"].Value);

                // Ask the user for confirmation to delete
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Proceed with deleting the product
                    string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM products WHERE products_id = @productId";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@productId", productId);

                                // Execute the delete query
                                cmd.ExecuteNonQuery();

                                // Inform the user that the product has been deleted
                                MessageBox.Show("Product deleted successfully.");

                                // Reload the products in the DataGridView
                                LoadProducts();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                // If no row is selected, inform the user to select a product
                MessageBox.Show("Please select a product to delete.");
            }
        }
    }
}
