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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArchivedOrders));
            this.archivedordersSidebar = new System.Windows.Forms.GroupBox();
            this.coffeeshoplabel = new System.Windows.Forms.Label();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.labelArchivedOrders = new System.Windows.Forms.Label();
            this.archivedordersTable = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveddateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportbutton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.archivedordersSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivedordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // archivedordersSidebar
            // 
            this.archivedordersSidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.archivedordersSidebar.Controls.Add(this.coffeeshoplabel);
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
            // labelArchivedOrders
            // 
            this.labelArchivedOrders.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArchivedOrders.Image = ((System.Drawing.Image)(resources.GetObject("labelArchivedOrders.Image")));
            this.labelArchivedOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelArchivedOrders.Location = new System.Drawing.Point(286, 31);
            this.labelArchivedOrders.Name = "labelArchivedOrders";
            this.labelArchivedOrders.Size = new System.Drawing.Size(215, 26);
            this.labelArchivedOrders.TabIndex = 18;
            this.labelArchivedOrders.Text = "Archived Orders";
            this.labelArchivedOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // archivedordersTable
            // 
            this.archivedordersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archivedordersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.archivedordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivedordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.customerColumn,
            this.orderitemsColumn,
            this.orderdateColumn,
            this.amountColumn,
            this.statusColumn,
            this.archiveddateColumn});
            this.archivedordersTable.Location = new System.Drawing.Point(290, 116);
            this.archivedordersTable.Name = "archivedordersTable";
            this.archivedordersTable.RowHeadersWidth = 51;
            this.archivedordersTable.RowTemplate.Height = 24;
            this.archivedordersTable.Size = new System.Drawing.Size(945, 575);
            this.archivedordersTable.TabIndex = 19;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Order ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            // 
            // customerColumn
            // 
            this.customerColumn.HeaderText = "Customer";
            this.customerColumn.MinimumWidth = 6;
            this.customerColumn.Name = "customerColumn";
            // 
            // orderitemsColumn
            // 
            this.orderitemsColumn.HeaderText = "Order Items";
            this.orderitemsColumn.MinimumWidth = 6;
            this.orderitemsColumn.Name = "orderitemsColumn";
            // 
            // orderdateColumn
            // 
            this.orderdateColumn.HeaderText = "Order Date";
            this.orderdateColumn.MinimumWidth = 6;
            this.orderdateColumn.Name = "orderdateColumn";
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Amount";
            this.amountColumn.MinimumWidth = 6;
            this.amountColumn.Name = "amountColumn";
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            // 
            // archiveddateColumn
            // 
            this.archiveddateColumn.HeaderText = "Archived Date";
            this.archiveddateColumn.MinimumWidth = 6;
            this.archiveddateColumn.Name = "archiveddateColumn";
            // 
            // exportbutton
            // 
            this.exportbutton.BackColor = System.Drawing.Color.Black;
            this.exportbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exportbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportbutton.Image = ((System.Drawing.Image)(resources.GetObject("exportbutton.Image")));
            this.exportbutton.Location = new System.Drawing.Point(1196, 69);
            this.exportbutton.Name = "exportbutton";
            this.exportbutton.Size = new System.Drawing.Size(39, 34);
            this.exportbutton.TabIndex = 22;
            this.exportbutton.UseVisualStyleBackColor = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchLabel.Location = new System.Drawing.Point(288, 77);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(59, 18);
            this.searchLabel.TabIndex = 33;
            this.searchLabel.Text = "Search:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(363, 76);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(202, 22);
            this.searchtextBox.TabIndex = 32;
            // 
            // FormArchivedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.exportbutton);
            this.Controls.Add(this.archivedordersTable);
            this.Controls.Add(this.labelArchivedOrders);
            this.Controls.Add(this.archivedordersSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArchivedOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archived Orders";
            this.archivedordersSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.archivedordersTable)).EndInit();
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
        private System.Windows.Forms.DataGridView archivedordersTable;
        private System.Windows.Forms.Button exportbutton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Label coffeeshoplabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderitemsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveddateColumn;
    }
}