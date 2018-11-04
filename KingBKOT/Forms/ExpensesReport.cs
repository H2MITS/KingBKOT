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

namespace KingBKOT.Forms
{
    
    public partial class ExpensesReport : Form
    {
        private object keyboardProc;
        public ExpensesReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            txtAmount.Text = string.Empty;
            txtName.Text = string.Empty;
            date.Text = string.Empty;
        }
    }
}
