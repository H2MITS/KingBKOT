using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace KingBKOT.Forms
{
    public partial class AddEmployee : UserControl
    {
        private object keyboardProc;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles,"TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtState.Text = string.Empty;
            comboEmployeeType.Text = string.Empty;
            dateOfJoining.Text = string.Empty;
            
        }
    }
}