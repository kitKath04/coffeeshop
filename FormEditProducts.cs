using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EDP_WinProject
{
    public partial class FormEditProducts : Form
    {
        private int productId;

        public FormEditProducts(int id)
        {
            InitializeComponent();
            productId = id;
            LoadCategories();
            LoadProductDetails();
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

                        categorycomboBox.DisplayMember = "category_name";
                        categorycomboBox.ValueMember = "category_id";
                        categorycomboBox.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load categories: " + ex.Message);
                }
            }
        }

        private void LoadProductDetails()
        {
            string connectionString = "server=localhost;user=root;password=kath2003;database=coffeeshop;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT product_name, category_id, price, stock 
                                     FROM products 
                                     WHERE products_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxProductName.Text = reader["product_name"].ToString();
                                categorycomboBox.SelectedValue = Convert.ToInt32(reader["category_id"]);
                                textBoxPrice.Text = reader["price"].ToString();
                                textBoxStock.Text = reader["stock"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxProductName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(textBoxStock.Text) ||
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

                    string query = @"UPDATE products 
                                     SET product_name = @name, 
                                         category_id = @categoryId, 
                                         price = @price, 
                                         stock = @stock 
                                     WHERE products_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBoxProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("@categoryId", Convert.ToInt32(categorycomboBox.SelectedValue));
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(textBoxPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(textBoxStock.Text.Trim()));
                        cmd.Parameters.AddWithValue("@id", productId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product updated successfully.");
                        FormProducts form = new FormProducts();
                        form.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product: " + ex.Message);
                }
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            FormProducts myform = new FormProducts();
            myform.Show();
            this.Hide();
        }
    }
}
