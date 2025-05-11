using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EDP_WinProject
{
    public partial class FormResetCodeValidation : Form
    {
        private string expectedCode;
        private string userEmail;

        public FormResetCodeValidation(string email, string resetCode)
        {
            InitializeComponent();
            userEmail = email;
            expectedCode = resetCode;
        }

        private void btnValidateCode_Click(object sender, EventArgs e)
        {
            string enteredCode = textBoxResetCode.Text.Trim();

            if (string.IsNullOrEmpty(enteredCode))
            {
                MessageBox.Show("Please enter the reset code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredCode == expectedCode)
            {
                MessageBox.Show("Code is valid! Proceeding to reset password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the reset password form
                FormResetPassword resetForm = new FormResetPassword(userEmail);
                resetForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid reset code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
