namespace EDP_WinProject
{
    partial class FormEditPayments
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelPymentMethod = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.labelEditPayment = new System.Windows.Forms.Label();
            this.paymentmethodcomboBox = new System.Windows.Forms.ComboBox();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(362, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.Location = new System.Drawing.Point(256, 406);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(100, 33);
            this.btnDiscard.TabIndex = 35;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = false;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(41, 184);
            this.textBoxAmount.Multiline = true;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(421, 35);
            this.textBoxAmount.TabIndex = 32;
            this.textBoxAmount.Text = "Php 350.00";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(37, 157);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 19);
            this.labelAmount.TabIndex = 30;
            this.labelAmount.Text = "Amount:";
            // 
            // labelPymentMethod
            // 
            this.labelPymentMethod.AutoSize = true;
            this.labelPymentMethod.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPymentMethod.Location = new System.Drawing.Point(37, 244);
            this.labelPymentMethod.Name = "labelPymentMethod";
            this.labelPymentMethod.Size = new System.Drawing.Size(134, 19);
            this.labelPymentMethod.TabIndex = 29;
            this.labelPymentMethod.Text = "Payment Method:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(37, 321);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 19);
            this.labelStatus.TabIndex = 28;
            this.labelStatus.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 27;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderID.Location = new System.Drawing.Point(37, 72);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(73, 19);
            this.labelOrderID.TabIndex = 26;
            this.labelOrderID.Text = "Order ID:";
            // 
            // labelEditPayment
            // 
            this.labelEditPayment.AutoSize = true;
            this.labelEditPayment.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditPayment.Location = new System.Drawing.Point(203, 30);
            this.labelEditPayment.Name = "labelEditPayment";
            this.labelEditPayment.Size = new System.Drawing.Size(117, 22);
            this.labelEditPayment.TabIndex = 25;
            this.labelEditPayment.Text = "Edit Payment";
            // 
            // paymentmethodcomboBox
            // 
            this.paymentmethodcomboBox.FormattingEnabled = true;
            this.paymentmethodcomboBox.Location = new System.Drawing.Point(41, 273);
            this.paymentmethodcomboBox.Name = "paymentmethodcomboBox";
            this.paymentmethodcomboBox.Size = new System.Drawing.Size(421, 24);
            this.paymentmethodcomboBox.TabIndex = 37;
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Location = new System.Drawing.Point(41, 350);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(421, 24);
            this.statuscomboBox.TabIndex = 38;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderID.Location = new System.Drawing.Point(41, 99);
            this.textBoxOrderID.Multiline = true;
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(421, 35);
            this.textBoxOrderID.TabIndex = 31;
            this.textBoxOrderID.Text = "1";
            // 
            // FormEditPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 472);
            this.Controls.Add(this.statuscomboBox);
            this.Controls.Add(this.paymentmethodcomboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxOrderID);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelPymentMethod);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.labelEditPayment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelPymentMethod;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.Label labelEditPayment;
        private System.Windows.Forms.ComboBox paymentmethodcomboBox;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.TextBox textBoxOrderID;
    }
}