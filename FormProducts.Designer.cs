namespace EDP_WinProject
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.productsSidebar = new System.Windows.Forms.GroupBox();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.labelProducts = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportbutton = new System.Windows.Forms.Button();
            this.namecomboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.coffeeshoplabel = new System.Windows.Forms.Label();
            this.productsSidebar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // productsSidebar
            // 
            this.productsSidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.productsSidebar.Controls.Add(this.coffeeshoplabel);
            this.productsSidebar.Controls.Add(this.btnArchivedOrders);
            this.productsSidebar.Controls.Add(this.btnLogout);
            this.productsSidebar.Controls.Add(this.btnEmployees);
            this.productsSidebar.Controls.Add(this.btnPayments);
            this.productsSidebar.Controls.Add(this.btnCustomers);
            this.productsSidebar.Controls.Add(this.btnProducts);
            this.productsSidebar.Controls.Add(this.btnOrders);
            this.productsSidebar.Controls.Add(this.btnDashboard);
            this.productsSidebar.Location = new System.Drawing.Point(-1, 0);
            this.productsSidebar.Name = "productsSidebar";
            this.productsSidebar.Size = new System.Drawing.Size(254, 762);
            this.productsSidebar.TabIndex = 0;
            this.productsSidebar.TabStop = false;
            // 
            // btnArchivedOrders
            // 
            this.btnArchivedOrders.Location = new System.Drawing.Point(41, 567);
            this.btnArchivedOrders.Name = "btnArchivedOrders";
            this.btnArchivedOrders.Size = new System.Drawing.Size(170, 36);
            this.btnArchivedOrders.TabIndex = 7;
            this.btnArchivedOrders.Text = "Archived Orders";
            this.btnArchivedOrders.UseVisualStyleBackColor = true;
            this.btnArchivedOrders.Click += new System.EventHandler(this.btnArchivedOrders_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(41, 689);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 36);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(41, 490);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(170, 36);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(41, 264);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(170, 36);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(41, 413);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(170, 36);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(41, 339);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(170, 36);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(41, 186);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(170, 36);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(41, 112);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 36);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // labelProducts
            // 
            this.labelProducts.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Image = ((System.Drawing.Image)(resources.GetObject("labelProducts.Image")));
            this.labelProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelProducts.Location = new System.Drawing.Point(281, 9);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(138, 39);
            this.labelProducts.TabIndex = 2;
            this.labelProducts.Text = "Products";
            this.labelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProduct.Location = new System.Drawing.Point(834, 152);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 31);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(18, 105);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(109, 16);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "Product Name:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(543, 100);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 16);
            this.labelStock.TabIndex = 6;
            this.labelStock.Text = "Stock:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(543, 54);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 16);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(18, 160);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(74, 16);
            this.labelCategory.TabIndex = 8;
            this.labelCategory.Text = "Category:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelCategory);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.labelProductName);
            this.groupBox1.Location = new System.Drawing.Point(285, 545);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(146, 48);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(333, 30);
            this.textBox5.TabIndex = 15;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(18, 55);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 16);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "ID:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(606, 95);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(333, 30);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(606, 47);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(333, 30);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(146, 153);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 30);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 30);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Product";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1096, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AllowDrop = true;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(1172, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // productsTable
            // 
            this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.productnameColumn,
            this.categoryColumn,
            this.priceColumn,
            this.stockColumn});
            this.productsTable.Location = new System.Drawing.Point(285, 83);
            this.productsTable.Name = "productsTable";
            this.productsTable.RowHeadersWidth = 51;
            this.productsTable.RowTemplate.Height = 24;
            this.productsTable.Size = new System.Drawing.Size(957, 462);
            this.productsTable.TabIndex = 12;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 6;
            this.IDColumn.Name = "IDColumn";
            // 
            // productnameColumn
            // 
            this.productnameColumn.HeaderText = "Product Name";
            this.productnameColumn.MinimumWidth = 6;
            this.productnameColumn.Name = "productnameColumn";
            // 
            // categoryColumn
            // 
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.MinimumWidth = 6;
            this.categoryColumn.Name = "categoryColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            // 
            // stockColumn
            // 
            this.stockColumn.HeaderText = "Stock";
            this.stockColumn.MinimumWidth = 6;
            this.stockColumn.Name = "stockColumn";
            // 
            // exportbutton
            // 
            this.exportbutton.BackColor = System.Drawing.Color.Black;
            this.exportbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exportbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportbutton.Image = ((System.Drawing.Image)(resources.GetObject("exportbutton.Image")));
            this.exportbutton.Location = new System.Drawing.Point(1051, 42);
            this.exportbutton.Name = "exportbutton";
            this.exportbutton.Size = new System.Drawing.Size(39, 34);
            this.exportbutton.TabIndex = 21;
            this.exportbutton.UseVisualStyleBackColor = false;
            // 
            // namecomboBox
            // 
            this.namecomboBox.FormattingEnabled = true;
            this.namecomboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.namecomboBox.Location = new System.Drawing.Point(664, 52);
            this.namecomboBox.Name = "namecomboBox";
            this.namecomboBox.Size = new System.Drawing.Size(183, 24);
            this.namecomboBox.TabIndex = 39;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(594, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 18);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Name:";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchLabel.Location = new System.Drawing.Point(283, 54);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(59, 18);
            this.searchLabel.TabIndex = 37;
            this.searchLabel.Text = "Search:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(358, 53);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(202, 22);
            this.searchtextBox.TabIndex = 36;
            // 
            // coffeeshoplabel
            // 
            this.coffeeshoplabel.BackColor = System.Drawing.Color.Transparent;
            this.coffeeshoplabel.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeshoplabel.Image = ((System.Drawing.Image)(resources.GetObject("coffeeshoplabel.Image")));
            this.coffeeshoplabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coffeeshoplabel.Location = new System.Drawing.Point(18, 10);
            this.coffeeshoplabel.Name = "coffeeshoplabel";
            this.coffeeshoplabel.Size = new System.Drawing.Size(218, 60);
            this.coffeeshoplabel.TabIndex = 9;
            this.coffeeshoplabel.Text = "Coffee Shop";
            this.coffeeshoplabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.namecomboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.exportbutton);
            this.Controls.Add(this.productsTable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.productsSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.productsSidebar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox productsSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnArchivedOrders;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockColumn;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button exportbutton;
        private System.Windows.Forms.ComboBox namecomboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Label coffeeshoplabel;
    }
}

