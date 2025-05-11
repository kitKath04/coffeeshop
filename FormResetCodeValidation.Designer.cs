namespace EDP_WinProject
{
    partial class FormResetCodeValidation
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
            this.labelCodeValidation = new System.Windows.Forms.Label();
            this.btnValidateCode = new System.Windows.Forms.Button();
            this.textBoxResetCode = new System.Windows.Forms.TextBox();
            this.labelResetCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCodeValidation
            // 
            this.labelCodeValidation.AutoSize = true;
            this.labelCodeValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeValidation.Location = new System.Drawing.Point(146, 44);
            this.labelCodeValidation.Name = "labelCodeValidation";
            this.labelCodeValidation.Size = new System.Drawing.Size(260, 22);
            this.labelCodeValidation.TabIndex = 24;
            this.labelCodeValidation.Text = "RESET CODE VALIDATION";
            // 
            // btnValidateCode
            // 
            this.btnValidateCode.BackColor = System.Drawing.Color.SteelBlue;
            this.btnValidateCode.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnValidateCode.Location = new System.Drawing.Point(172, 217);
            this.btnValidateCode.Name = "btnValidateCode";
            this.btnValidateCode.Size = new System.Drawing.Size(199, 40);
            this.btnValidateCode.TabIndex = 23;
            this.btnValidateCode.Text = "Validate Code";
            this.btnValidateCode.UseVisualStyleBackColor = false;
            this.btnValidateCode.Click += new System.EventHandler(this.btnValidateCode_Click);
            // 
            // textBoxResetCode
            // 
            this.textBoxResetCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResetCode.Location = new System.Drawing.Point(81, 139);
            this.textBoxResetCode.Multiline = true;
            this.textBoxResetCode.Name = "textBoxResetCode";
            this.textBoxResetCode.Size = new System.Drawing.Size(389, 32);
            this.textBoxResetCode.TabIndex = 22;
            // 
            // labelResetCode
            // 
            this.labelResetCode.AutoSize = true;
            this.labelResetCode.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResetCode.Location = new System.Drawing.Point(77, 117);
            this.labelResetCode.Name = "labelResetCode";
            this.labelResetCode.Size = new System.Drawing.Size(132, 19);
            this.labelResetCode.TabIndex = 21;
            this.labelResetCode.Text = "Enter Reset Code:";
            // 
            // FormResetCodeValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 300);
            this.Controls.Add(this.labelCodeValidation);
            this.Controls.Add(this.btnValidateCode);
            this.Controls.Add(this.textBoxResetCode);
            this.Controls.Add(this.labelResetCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResetCodeValidation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Code Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodeValidation;
        private System.Windows.Forms.Button btnValidateCode;
        private System.Windows.Forms.TextBox textBoxResetCode;
        private System.Windows.Forms.Label labelResetCode;
    }
}