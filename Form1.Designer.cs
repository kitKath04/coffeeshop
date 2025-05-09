﻿namespace EDP_WinProject
{
    partial class formProducts
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
            this.productsSidebar = new System.Windows.Forms.GroupBox();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.tableProducts = new System.Windows.Forms.DataGridView();
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
            this.columnAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.productsSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsSidebar
            // 
            this.productsSidebar.BackColor = System.Drawing.Color.SteelBlue;
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
            this.btnArchivedOrders.Location = new System.Drawing.Point(41, 542);
            this.btnArchivedOrders.Name = "btnArchivedOrders";
            this.btnArchivedOrders.Size = new System.Drawing.Size(170, 36);
            this.btnArchivedOrders.TabIndex = 7;
            this.btnArchivedOrders.Text = "Archived Orders";
            this.btnArchivedOrders.UseVisualStyleBackColor = true;
            this.btnArchivedOrders.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(41, 689);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 36);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(41, 465);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(170, 36);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(41, 239);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(170, 36);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(41, 388);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(170, 36);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(41, 314);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(170, 36);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(41, 161);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(170, 36);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(41, 87);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 36);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableProducts
            // 
            this.tableProducts.AllowUserToDeleteRows = false;
            this.tableProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnProductName,
            this.columnCategory,
            this.columnPrice,
            this.columnStock,
            this.columnAction});
            this.tableProducts.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tableProducts.Location = new System.Drawing.Point(316, 43);
            this.tableProducts.Name = "tableProducts";
            this.tableProducts.RowHeadersWidth = 51;
            this.tableProducts.RowTemplate.Height = 24;
            this.tableProducts.Size = new System.Drawing.Size(903, 476);
            this.tableProducts.TabIndex = 1;
            this.tableProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(312, 18);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(85, 22);
            this.labelProducts.TabIndex = 2;
            this.labelProducts.Text = "Products";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProduct.Location = new System.Drawing.Point(783, 157);
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
            this.labelProductName.Location = new System.Drawing.Point(9, 106);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(109, 16);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "Product Name:";
            this.labelProductName.Click += new System.EventHandler(this.labelProductName_Click);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(511, 106);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 16);
            this.labelStock.TabIndex = 6;
            this.labelStock.Text = "Stock:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(511, 58);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 16);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price:";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(9, 160);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(74, 16);
            this.labelCategory.TabIndex = 8;
            this.labelCategory.Text = "Category:";
            this.labelCategory.Click += new System.EventHandler(this.labelCategory_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(316, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(134, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(302, 22);
            this.textBox5.TabIndex = 15;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(9, 52);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 16);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "ID:";
            this.labelID.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(586, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(302, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(586, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Product";
            // 
            // columnAction
            // 
            this.columnAction.FillWeight = 503.7433F;
            this.columnAction.HeaderText = "Action";
            this.columnAction.MinimumWidth = 6;
            this.columnAction.Name = "columnAction";
            // 
            // columnStock
            // 
            this.columnStock.FillWeight = 80.81844F;
            this.columnStock.HeaderText = "Stock";
            this.columnStock.MinimumWidth = 6;
            this.columnStock.Name = "columnStock";
            // 
            // columnPrice
            // 
            this.columnPrice.FillWeight = 12.96568F;
            this.columnPrice.HeaderText = "Price";
            this.columnPrice.MinimumWidth = 6;
            this.columnPrice.Name = "columnPrice";
            // 
            // columnCategory
            // 
            this.columnCategory.FillWeight = 2.080209F;
            this.columnCategory.HeaderText = "Category";
            this.columnCategory.MinimumWidth = 6;
            this.columnCategory.Name = "columnCategory";
            // 
            // columnProductName
            // 
            this.columnProductName.FillWeight = 0.1796614F;
            this.columnProductName.HeaderText = "Product Name";
            this.columnProductName.MinimumWidth = 6;
            this.columnProductName.Name = "columnProductName";
            // 
            // columnID
            // 
            this.columnID.FillWeight = 0.2126608F;
            this.columnID.HeaderText = "ID";
            this.columnID.MinimumWidth = 6;
            this.columnID.Name = "columnID";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(1088, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AllowDrop = true;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1143, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // formProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.tableProducts);
            this.Controls.Add(this.productsSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.productsSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView tableProducts;
        private System.Windows.Forms.Label labelProducts;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAction;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

