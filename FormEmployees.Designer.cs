namespace EDP_WinProject
{
    partial class FormEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployees));
            this.employeesSidebar = new System.Windows.Forms.GroupBox();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportbutton = new System.Windows.Forms.Button();
            this.namecomboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.coffeeshoplabel = new System.Windows.Forms.Label();
            this.employeesSidebar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesSidebar
            // 
            this.employeesSidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.employeesSidebar.Controls.Add(this.coffeeshoplabel);
            this.employeesSidebar.Controls.Add(this.btnArchivedOrders);
            this.employeesSidebar.Controls.Add(this.btnLogout);
            this.employeesSidebar.Controls.Add(this.btnEmployees);
            this.employeesSidebar.Controls.Add(this.btnPayments);
            this.employeesSidebar.Controls.Add(this.btnCustomers);
            this.employeesSidebar.Controls.Add(this.btnProducts);
            this.employeesSidebar.Controls.Add(this.btnOrders);
            this.employeesSidebar.Controls.Add(this.btnDashboard);
            this.employeesSidebar.Location = new System.Drawing.Point(-1, 0);
            this.employeesSidebar.Name = "employeesSidebar";
            this.employeesSidebar.Size = new System.Drawing.Size(254, 762);
            this.employeesSidebar.TabIndex = 1;
            this.employeesSidebar.TabStop = false;
            this.employeesSidebar.Enter += new System.EventHandler(this.employeesSidebar_Enter);
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
            // btnDelete
            // 
            this.btnDelete.AllowDrop = true;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(1174, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1098, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 30);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelPhoneNo);
            this.groupBox1.Controls.Add(this.labelPosition);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(287, 546);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 200);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(95, 49);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(333, 30);
            this.textBox5.TabIndex = 15;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(24, 56);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 16);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "ID:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(604, 100);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(333, 30);
            this.textBox4.TabIndex = 13;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProduct.Location = new System.Drawing.Point(832, 157);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 31);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(604, 49);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(333, 30);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(95, 154);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 30);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(95, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 30);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Employee";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(24, 160);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 16);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNo.Location = new System.Drawing.Point(499, 56);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(83, 16);
            this.labelPhoneNo.TabIndex = 7;
            this.labelPhoneNo.Text = "Phone No.:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(499, 106);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(67, 16);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Position:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(24, 106);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name:";
            // 
            // labelEmployees
            // 
            this.labelEmployees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployees.Image = ((System.Drawing.Image)(resources.GetObject("labelEmployees.Image")));
            this.labelEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmployees.Location = new System.Drawing.Point(283, 9);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(160, 32);
            this.labelEmployees.TabIndex = 13;
            this.labelEmployees.Text = "Employees";
            this.labelEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeesTable
            // 
            this.employeesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.emailColumn,
            this.phonenoColumn,
            this.positionColumn});
            this.employeesTable.Location = new System.Drawing.Point(287, 83);
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.RowHeadersWidth = 51;
            this.employeesTable.RowTemplate.Height = 24;
            this.employeesTable.Size = new System.Drawing.Size(957, 462);
            this.employeesTable.TabIndex = 17;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            // 
            // phonenoColumn
            // 
            this.phonenoColumn.HeaderText = "Phone No.";
            this.phonenoColumn.MinimumWidth = 6;
            this.phonenoColumn.Name = "phonenoColumn";
            // 
            // positionColumn
            // 
            this.positionColumn.HeaderText = "Position";
            this.positionColumn.MinimumWidth = 6;
            this.positionColumn.Name = "positionColumn";
            // 
            // exportbutton
            // 
            this.exportbutton.BackColor = System.Drawing.Color.Black;
            this.exportbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exportbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportbutton.Image = ((System.Drawing.Image)(resources.GetObject("exportbutton.Image")));
            this.exportbutton.Location = new System.Drawing.Point(1053, 38);
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
            this.namecomboBox.Location = new System.Drawing.Point(670, 49);
            this.namecomboBox.Name = "namecomboBox";
            this.namecomboBox.Size = new System.Drawing.Size(183, 24);
            this.namecomboBox.TabIndex = 35;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(600, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 18);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "Name:";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchLabel.Location = new System.Drawing.Point(289, 51);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(59, 18);
            this.searchLabel.TabIndex = 33;
            this.searchLabel.Text = "Search:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(364, 50);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(202, 22);
            this.searchtextBox.TabIndex = 32;
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
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.namecomboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.exportbutton);
            this.Controls.Add(this.employeesTable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.employeesSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.employeesSidebar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox employeesSidebar;
        private System.Windows.Forms.Button btnArchivedOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.DataGridView employeesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.Button exportbutton;
        private System.Windows.Forms.ComboBox namecomboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Label coffeeshoplabel;
    }
}