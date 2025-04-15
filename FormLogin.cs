using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_WinProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormDashboard myform = new FormDashboard();
            myform.Show();
            this.Hide();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp myform = new FormSignUp();
            myform.Show();
            this.Hide();
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            FormForgotPassword myform = new FormForgotPassword();
            myform.Show();
            this.Hide();
        }
    }
}
