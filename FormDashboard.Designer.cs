namespace EDP_WinProject
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.dashboardSidebar = new System.Windows.Forms.GroupBox();
            this.coffeeshoplabel = new System.Windows.Forms.Label();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalSales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTotalOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelActiveCustomers = new System.Windows.Forms.Label();
            this.labelTotalProductsSold = new System.Windows.Forms.Label();
            this.labelTotalProducts = new System.Windows.Forms.Label();
            this.labelActiveCustomer = new System.Windows.Forms.Label();
            this.dashboardSidebar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardSidebar
            // 
            this.dashboardSidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.dashboardSidebar.Controls.Add(this.coffeeshoplabel);
            this.dashboardSidebar.Controls.Add(this.btnArchivedOrders);
            this.dashboardSidebar.Controls.Add(this.btnLogout);
            this.dashboardSidebar.Controls.Add(this.btnEmployees);
            this.dashboardSidebar.Controls.Add(this.btnPayments);
            this.dashboardSidebar.Controls.Add(this.btnCustomers);
            this.dashboardSidebar.Controls.Add(this.btnProducts);
            this.dashboardSidebar.Controls.Add(this.btnOrders);
            this.dashboardSidebar.Controls.Add(this.btnDashboard);
            this.dashboardSidebar.Location = new System.Drawing.Point(-1, 0);
            this.dashboardSidebar.Name = "dashboardSidebar";
            this.dashboardSidebar.Size = new System.Drawing.Size(254, 762);
            this.dashboardSidebar.TabIndex = 2;
            this.dashboardSidebar.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.labelTotalSales);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(270, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalSales
            // 
            this.labelTotalSales.AutoSize = true;
            this.labelTotalSales.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSales.Location = new System.Drawing.Point(60, 78);
            this.labelTotalSales.Name = "labelTotalSales";
            this.labelTotalSales.Size = new System.Drawing.Size(190, 42);
            this.labelTotalSales.TabIndex = 1;
            this.labelTotalSales.Text = "Php 10,000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Sales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTotalOrders);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(603, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.AutoSize = true;
            this.labelTotalOrders.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrders.Location = new System.Drawing.Point(136, 78);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(56, 42);
            this.labelTotalOrders.TabIndex = 2;
            this.labelTotalOrders.Text = "22";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Orders";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelTotalProductsSold);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(936, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 188);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Products Sold";
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.Location = new System.Drawing.Point(266, 33);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(102, 22);
            this.labelDashboard.TabIndex = 14;
            this.labelDashboard.Text = "Dashboard";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelTotalProducts);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(271, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 234);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Products";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelActiveCustomer);
            this.groupBox5.Controls.Add(this.labelActiveCustomers);
            this.groupBox5.Location = new System.Drawing.Point(769, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(488, 234);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // labelActiveCustomers
            // 
            this.labelActiveCustomers.AutoSize = true;
            this.labelActiveCustomers.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveCustomers.Location = new System.Drawing.Point(6, 30);
            this.labelActiveCustomers.Name = "labelActiveCustomers";
            this.labelActiveCustomers.Size = new System.Drawing.Size(158, 23);
            this.labelActiveCustomers.TabIndex = 2;
            this.labelActiveCustomers.Text = "Active Customers";
            // 
            // labelTotalProductsSold
            // 
            this.labelTotalProductsSold.AutoSize = true;
            this.labelTotalProductsSold.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProductsSold.Location = new System.Drawing.Point(128, 78);
            this.labelTotalProductsSold.Name = "labelTotalProductsSold";
            this.labelTotalProductsSold.Size = new System.Drawing.Size(56, 42);
            this.labelTotalProductsSold.TabIndex = 3;
            this.labelTotalProductsSold.Text = "22";
            // 
            // labelTotalProducts
            // 
            this.labelTotalProducts.AutoSize = true;
            this.labelTotalProducts.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProducts.Location = new System.Drawing.Point(193, 105);
            this.labelTotalProducts.Name = "labelTotalProducts";
            this.labelTotalProducts.Size = new System.Drawing.Size(56, 42);
            this.labelTotalProducts.TabIndex = 4;
            this.labelTotalProducts.Text = "22";
            // 
            // labelActiveCustomer
            // 
            this.labelActiveCustomer.AutoSize = true;
            this.labelActiveCustomer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveCustomer.Location = new System.Drawing.Point(204, 105);
            this.labelActiveCustomer.Name = "labelActiveCustomer";
            this.labelActiveCustomer.Size = new System.Drawing.Size(56, 42);
            this.labelActiveCustomer.TabIndex = 5;
            this.labelActiveCustomer.Text = "22";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelDashboard);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dashboardSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.dashboardSidebar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dashboardSidebar;
        private System.Windows.Forms.Button btnArchivedOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelActiveCustomers;
        private System.Windows.Forms.Label coffeeshoplabel;
        private System.Windows.Forms.Label labelTotalSales;
        private System.Windows.Forms.Label labelTotalOrders;
        private System.Windows.Forms.Label labelTotalProductsSold;
        private System.Windows.Forms.Label labelTotalProducts;
        private System.Windows.Forms.Label labelActiveCustomer;
    }
}