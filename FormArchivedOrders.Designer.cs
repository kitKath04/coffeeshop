namespace EDP_WinProject
{
    partial class FormArchivedOrders
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
            this.archivedordersSidebar = new System.Windows.Forms.GroupBox();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.labelArchivedOrders = new System.Windows.Forms.Label();
            this.tableOrders = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOrderItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnArchivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivedordersSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // archivedordersSidebar
            // 
            this.archivedordersSidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.archivedordersSidebar.Controls.Add(this.btnArchivedOrders);
            this.archivedordersSidebar.Controls.Add(this.btnLogout);
            this.archivedordersSidebar.Controls.Add(this.btnEmployees);
            this.archivedordersSidebar.Controls.Add(this.btnPayments);
            this.archivedordersSidebar.Controls.Add(this.btnCustomers);
            this.archivedordersSidebar.Controls.Add(this.btnProducts);
            this.archivedordersSidebar.Controls.Add(this.btnOrders);
            this.archivedordersSidebar.Controls.Add(this.btnDashboard);
            this.archivedordersSidebar.Location = new System.Drawing.Point(-1, 0);
            this.archivedordersSidebar.Name = "archivedordersSidebar";
            this.archivedordersSidebar.Size = new System.Drawing.Size(254, 762);
            this.archivedordersSidebar.TabIndex = 13;
            this.archivedordersSidebar.TabStop = false;
            // 
            // btnArchivedOrders
            // 
            this.btnArchivedOrders.Location = new System.Drawing.Point(41, 542);
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
            this.btnEmployees.Location = new System.Drawing.Point(41, 465);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(170, 36);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(41, 239);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(170, 36);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(41, 388);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(170, 36);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(41, 314);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(170, 36);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(41, 161);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(170, 36);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(41, 87);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 36);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // labelArchivedOrders
            // 
            this.labelArchivedOrders.AutoSize = true;
            this.labelArchivedOrders.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArchivedOrders.Location = new System.Drawing.Point(283, 41);
            this.labelArchivedOrders.Name = "labelArchivedOrders";
            this.labelArchivedOrders.Size = new System.Drawing.Size(145, 22);
            this.labelArchivedOrders.TabIndex = 18;
            this.labelArchivedOrders.Text = "Archived Orders";
            // 
            // tableOrders
            // 
            this.tableOrders.AllowUserToDeleteRows = false;
            this.tableOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tableOrders.BackgroundColor = System.Drawing.Color.White;
            this.tableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnCustomer,
            this.columnOrderItems,
            this.columnOrderDate,
            this.columnAmount,
            this.columnStatus,
            this.columnArchivedDate});
            this.tableOrders.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tableOrders.Location = new System.Drawing.Point(287, 75);
            this.tableOrders.Name = "tableOrders";
            this.tableOrders.RowHeadersWidth = 51;
            this.tableOrders.RowTemplate.Height = 24;
            this.tableOrders.Size = new System.Drawing.Size(958, 584);
            this.tableOrders.TabIndex = 17;
            // 
            // columnID
            // 
            this.columnID.FillWeight = 0.2126608F;
            this.columnID.HeaderText = "ID";
            this.columnID.MinimumWidth = 100;
            this.columnID.Name = "columnID";
            this.columnID.Width = 125;
            // 
            // columnCustomer
            // 
            this.columnCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCustomer.FillWeight = 458.4813F;
            this.columnCustomer.HeaderText = "Customer";
            this.columnCustomer.MinimumWidth = 130;
            this.columnCustomer.Name = "columnCustomer";
            // 
            // columnOrderItems
            // 
            this.columnOrderItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnOrderItems.FillWeight = 0.7174977F;
            this.columnOrderItems.HeaderText = "Order Items";
            this.columnOrderItems.MinimumWidth = 130;
            this.columnOrderItems.Name = "columnOrderItems";
            // 
            // columnOrderDate
            // 
            this.columnOrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnOrderDate.FillWeight = 4.472073F;
            this.columnOrderDate.HeaderText = "Order Date";
            this.columnOrderDate.MinimumWidth = 130;
            this.columnOrderDate.Name = "columnOrderDate";
            // 
            // columnAmount
            // 
            this.columnAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnAmount.FillWeight = 27.87559F;
            this.columnAmount.HeaderText = "Amount";
            this.columnAmount.MinimumWidth = 130;
            this.columnAmount.Name = "columnAmount";
            // 
            // columnStatus
            // 
            this.columnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnStatus.FillWeight = 173.7492F;
            this.columnStatus.HeaderText = "Status";
            this.columnStatus.MinimumWidth = 130;
            this.columnStatus.Name = "columnStatus";
            // 
            // columnArchivedDate
            // 
            this.columnArchivedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnArchivedDate.FillWeight = 34.49162F;
            this.columnArchivedDate.HeaderText = "Archived Date";
            this.columnArchivedDate.MinimumWidth = 130;
            this.columnArchivedDate.Name = "columnArchivedDate";
            // 
            // FormArchivedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.labelArchivedOrders);
            this.Controls.Add(this.tableOrders);
            this.Controls.Add(this.archivedordersSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArchivedOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archived Orders";
            this.archivedordersSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox archivedordersSidebar;
        private System.Windows.Forms.Button btnArchivedOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label labelArchivedOrders;
        private System.Windows.Forms.DataGridView tableOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnArchivedDate;
    }
}