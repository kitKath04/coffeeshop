namespace EDP_WinProject
{
    partial class FormOrders
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelOrders = new System.Windows.Forms.Label();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.ordersSidebar = new System.Windows.Forms.GroupBox();
            this.tableOrders = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOrderItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1157, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrders.Location = new System.Drawing.Point(282, 44);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(67, 22);
            this.labelOrders.TabIndex = 14;
            this.labelOrders.Text = "Orders";
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
            // ordersSidebar
            // 
            this.ordersSidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.ordersSidebar.Controls.Add(this.btnArchivedOrders);
            this.ordersSidebar.Controls.Add(this.btnLogout);
            this.ordersSidebar.Controls.Add(this.btnEmployees);
            this.ordersSidebar.Controls.Add(this.btnPayments);
            this.ordersSidebar.Controls.Add(this.btnCustomers);
            this.ordersSidebar.Controls.Add(this.btnProducts);
            this.ordersSidebar.Controls.Add(this.btnOrders);
            this.ordersSidebar.Controls.Add(this.btnDashboard);
            this.ordersSidebar.Location = new System.Drawing.Point(-1, 0);
            this.ordersSidebar.Name = "ordersSidebar";
            this.ordersSidebar.Size = new System.Drawing.Size(254, 762);
            this.ordersSidebar.TabIndex = 12;
            this.ordersSidebar.TabStop = false;
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
            this.columnDate,
            this.columnAmount,
            this.columnStatus,
            this.columnAction});
            this.tableOrders.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tableOrders.Location = new System.Drawing.Point(286, 78);
            this.tableOrders.Name = "tableOrders";
            this.tableOrders.RowHeadersWidth = 51;
            this.tableOrders.RowTemplate.Height = 24;
            this.tableOrders.Size = new System.Drawing.Size(958, 584);
            this.tableOrders.TabIndex = 13;
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
            // columnDate
            // 
            this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDate.FillWeight = 4.472073F;
            this.columnDate.HeaderText = "Date";
            this.columnDate.MinimumWidth = 130;
            this.columnDate.Name = "columnDate";
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
            // columnAction
            // 
            this.columnAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnAction.FillWeight = 34.49162F;
            this.columnAction.HeaderText = "Action";
            this.columnAction.MinimumWidth = 130;
            this.columnAction.Name = "columnAction";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.ordersSidebar);
            this.Controls.Add(this.tableOrders);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.ordersSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Button btnArchivedOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.GroupBox ordersSidebar;
        private System.Windows.Forms.DataGridView tableOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAction;
    }
}