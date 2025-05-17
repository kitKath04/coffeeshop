namespace EDP_WinProject
{
    partial class FormPayments
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayments));
            this.paymentsSidebar = new System.Windows.Forms.GroupBox();
            this.coffeeshoplabel = new System.Windows.Forms.Label();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelPayments = new System.Windows.Forms.Label();
            this.paymentsTable = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportbutton = new System.Windows.Forms.Button();
            this.paymentmethodLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.paymentmethodcomboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.paymentsSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsSidebar
            // 
            this.paymentsSidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.paymentsSidebar.Controls.Add(this.coffeeshoplabel);
            this.paymentsSidebar.Controls.Add(this.btnArchivedOrders);
            this.paymentsSidebar.Controls.Add(this.btnLogout);
            this.paymentsSidebar.Controls.Add(this.btnEmployees);
            this.paymentsSidebar.Controls.Add(this.btnPayments);
            this.paymentsSidebar.Controls.Add(this.btnCustomers);
            this.paymentsSidebar.Controls.Add(this.btnProducts);
            this.paymentsSidebar.Controls.Add(this.btnOrders);
            this.paymentsSidebar.Controls.Add(this.btnDashboard);
            this.paymentsSidebar.Location = new System.Drawing.Point(-1, 0);
            this.paymentsSidebar.Name = "paymentsSidebar";
            this.paymentsSidebar.Size = new System.Drawing.Size(254, 762);
            this.paymentsSidebar.TabIndex = 18;
            this.paymentsSidebar.TabStop = false;
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
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1165, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 30);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelPayments
            // 
            this.labelPayments.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayments.Image = ((System.Drawing.Image)(resources.GetObject("labelPayments.Image")));
            this.labelPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPayments.Location = new System.Drawing.Point(286, 28);
            this.labelPayments.Name = "labelPayments";
            this.labelPayments.Size = new System.Drawing.Size(149, 41);
            this.labelPayments.TabIndex = 23;
            this.labelPayments.Text = "Payments";
            this.labelPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymentsTable
            // 
            this.paymentsTable.AllowUserToAddRows = false;
            this.paymentsTable.AllowUserToDeleteRows = false;
            this.paymentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paymentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.orderidColumn,
            this.amountColumn,
            this.paymentmethodColumn,
            this.statusColumn});
            this.paymentsTable.Location = new System.Drawing.Point(290, 119);
            this.paymentsTable.Name = "paymentsTable";
            this.paymentsTable.ReadOnly = true;
            this.paymentsTable.RowHeadersWidth = 51;
            this.paymentsTable.RowTemplate.Height = 24;
            this.paymentsTable.Size = new System.Drawing.Size(945, 575);
            this.paymentsTable.TabIndex = 25;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // orderidColumn
            // 
            this.orderidColumn.HeaderText = "Order ID";
            this.orderidColumn.MinimumWidth = 6;
            this.orderidColumn.Name = "orderidColumn";
            this.orderidColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Amount";
            this.amountColumn.MinimumWidth = 6;
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            // 
            // paymentmethodColumn
            // 
            this.paymentmethodColumn.HeaderText = "Payment Method";
            this.paymentmethodColumn.MinimumWidth = 6;
            this.paymentmethodColumn.Name = "paymentmethodColumn";
            this.paymentmethodColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // exportbutton
            // 
            this.exportbutton.BackColor = System.Drawing.Color.Black;
            this.exportbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exportbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportbutton.Image = ((System.Drawing.Image)(resources.GetObject("exportbutton.Image")));
            this.exportbutton.Location = new System.Drawing.Point(1120, 71);
            this.exportbutton.Name = "exportbutton";
            this.exportbutton.Size = new System.Drawing.Size(39, 34);
            this.exportbutton.TabIndex = 27;
            this.exportbutton.UseVisualStyleBackColor = false;
            this.exportbutton.Click += new System.EventHandler(this.exportbutton_Click);
            // 
            // paymentmethodLabel
            // 
            this.paymentmethodLabel.AutoSize = true;
            this.paymentmethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentmethodLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentmethodLabel.Location = new System.Drawing.Point(287, 85);
            this.paymentmethodLabel.Name = "paymentmethodLabel";
            this.paymentmethodLabel.Size = new System.Drawing.Size(124, 18);
            this.paymentmethodLabel.TabIndex = 29;
            this.paymentmethodLabel.Text = "Payment Method:";
            this.paymentmethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(634, 85);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 18);
            this.statusLabel.TabIndex = 30;
            this.statusLabel.Text = "Status:";
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Items.AddRange(new object[] {
            "Pending",
            "Paid",
            "Failed"});
            this.statuscomboBox.Location = new System.Drawing.Point(704, 83);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(183, 24);
            this.statuscomboBox.TabIndex = 31;
            // 
            // paymentmethodcomboBox
            // 
            this.paymentmethodcomboBox.FormattingEnabled = true;
            this.paymentmethodcomboBox.Items.AddRange(new object[] {
            "Pending",
            "Paid",
            "Failed"});
            this.paymentmethodcomboBox.Location = new System.Drawing.Point(429, 83);
            this.paymentmethodcomboBox.Name = "paymentmethodcomboBox";
            this.paymentmethodcomboBox.Size = new System.Drawing.Size(183, 24);
            this.paymentmethodcomboBox.TabIndex = 32;
            // 
            // FormPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.paymentmethodcomboBox);
            this.Controls.Add(this.statuscomboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.paymentmethodLabel);
            this.Controls.Add(this.exportbutton);
            this.Controls.Add(this.paymentsTable);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelPayments);
            this.Controls.Add(this.paymentsSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.paymentsSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox paymentsSidebar;
        private System.Windows.Forms.Button btnArchivedOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelPayments;
        private System.Windows.Forms.DataGridView paymentsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.Button exportbutton;
        private System.Windows.Forms.Label paymentmethodLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.Label coffeeshoplabel;
        private System.Windows.Forms.ComboBox paymentmethodcomboBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}