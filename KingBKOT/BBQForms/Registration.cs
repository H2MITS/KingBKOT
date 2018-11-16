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
using System.Text.RegularExpressions;

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
                errorProvider1.SetError(txtPassword, "Enter 8 digit secure password");
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


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == string.Empty || txtConfirmpassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter atleast 8 digit secure password ");
                txtPassword.Focus();
            }
            else
            {
                if (txtPassword.Text.Length < 8)
                {

                    MessageBox.Show("Password must be at least 8 characters long");
                    txtConfirmpassword.Clear();
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
                else
                {
                     if (txtConfirmpassword.Text != txtPassword.Text)
                     {
                        MessageBox.Show("Password Mismatch");
                        txtConfirmpassword.Clear();
                        txtPassword.Clear();
                        txtPassword.Focus();
                        return;
                     }
                }

            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            //if (txtPhone.Text.Length <= 9)
            //{
            //    MessageBox.Show("Enter 10 Digit Mobile Phone", "Alert!");
            //    txtPhone.Clear();
            //    txtPhone.Focus();
            //}
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
                {
                    e.Handled = true;
                    MessageBox.Show("Enter only numeric values.", "Alert!");
                }
        }
              
            catch { }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Only Character are allowed");
                e.Handled = true;
            }
        }

        private void txtConfirmpassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmpassword.Text.Trim()))
            {
                errorProvider1.SetError(txtConfirmpassword, "Enter 8 digit secure password");
            }
            else
            {
                errorProvider1.SetError(txtConfirmpassword, string.Empty);
            }
        }
    }
}



