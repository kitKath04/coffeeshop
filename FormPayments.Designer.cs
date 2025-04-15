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
            this.paymentsSidebar = new System.Windows.Forms.GroupBox();
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
            this.tableCustomers = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsSidebar
            // 
            this.paymentsSidebar.BackColor = System.Drawing.Color.SteelBlue;
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
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1141, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelPayments
            // 
            this.labelPayments.AutoSize = true;
            this.labelPayments.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayments.Location = new System.Drawing.Point(282, 42);
            this.labelPayments.Name = "labelPayments";
            this.labelPayments.Size = new System.Drawing.Size(92, 22);
            this.labelPayments.TabIndex = 23;
            this.labelPayments.Text = "Payments";
            // 
            // tableCustomers
            // 
            this.tableCustomers.AllowUserToDeleteRows = false;
            this.tableCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tableCustomers.BackgroundColor = System.Drawing.Color.White;
            this.tableCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnName,
            this.columnEmail,
            this.columnPhoneNo,
            this.columnStatus,
            this.columnAction});
            this.tableCustomers.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tableCustomers.Location = new System.Drawing.Point(286, 76);
            this.tableCustomers.Name = "tableCustomers";
            this.tableCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tableCustomers.RowTemplate.Height = 24;
            this.tableCustomers.Size = new System.Drawing.Size(958, 584);
            this.tableCustomers.TabIndex = 22;
            // 
            // columnID
            // 
            this.columnID.FillWeight = 0.2126608F;
            this.columnID.Frozen = true;
            this.columnID.HeaderText = "ID";
            this.columnID.MinimumWidth = 152;
            this.columnID.Name = "columnID";
            this.columnID.Width = 152;
            // 
            // columnName
            // 
            this.columnName.FillWeight = 458.4813F;
            this.columnName.Frozen = true;
            this.columnName.HeaderText = "Order ID";
            this.columnName.MinimumWidth = 152;
            this.columnName.Name = "columnName";
            this.columnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnName.Width = 152;
            // 
            // columnEmail
            // 
            this.columnEmail.FillWeight = 0.7174977F;
            this.columnEmail.Frozen = true;
            this.columnEmail.HeaderText = "Amount";
            this.columnEmail.MinimumWidth = 152;
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.Width = 152;
            // 
            // columnPhoneNo
            // 
            this.columnPhoneNo.FillWeight = 4.472073F;
            this.columnPhoneNo.Frozen = true;
            this.columnPhoneNo.HeaderText = "Payment Method";
            this.columnPhoneNo.MinimumWidth = 155;
            this.columnPhoneNo.Name = "columnPhoneNo";
            this.columnPhoneNo.Width = 155;
            // 
            // columnStatus
            // 
            this.columnStatus.FillWeight = 173.7492F;
            this.columnStatus.Frozen = true;
            this.columnStatus.HeaderText = "Status";
            this.columnStatus.MinimumWidth = 152;
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.Width = 152;
            // 
            // columnAction
            // 
            this.columnAction.FillWeight = 34.49162F;
            this.columnAction.Frozen = true;
            this.columnAction.HeaderText = "Action";
            this.columnAction.MinimumWidth = 152;
            this.columnAction.Name = "columnAction";
            this.columnAction.Width = 152;
            // 
            // FormPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelPayments);
            this.Controls.Add(this.tableCustomers);
            this.Controls.Add(this.paymentsSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayments";
            this.paymentsSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomers)).EndInit();
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
        private System.Windows.Forms.DataGridView tableCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAction;
    }
}