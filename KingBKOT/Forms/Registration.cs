using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingBarbeque
{
    public partial class Registration : Form
    {
        private object keyboardProc;
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConfirmpassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                errorProvider1.SetError(txtUsername, "Enter your Full Name");
            }
            else
            {
                errorProvider1.SetError(txtUsername, string.Empty);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Enter your E-Mail Address");
            }
            else
            {
                errorProvider1.SetError(txtEmail, string.Empty);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                errorProvider1.SetError(txtPhone, "Enter your Phone Number");
            }
            else
            {
                errorProvider1.SetError(txtPhone, string.Empty);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "Enter Your Secure Password");
            }
            else
            {
                errorProvider1.SetError(txtPassword, string.Empty);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmpassword.Text == txtPassword.Text)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "You have been Registered";

            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Password Doesn't Match";
            }
        }
    }
}
