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
    public partial class AddCategory : UserControl
    {
        private object keyboardProc;
        public AddCategory()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                errorProvider1.SetError(txtCategoryName, "Category Name is required.");
            }
            else
            {
                errorProvider1.SetError(txtCategoryName, string.Empty);
            }
        }

        //private void txtDescription_Validating(object sender, CancelEventArgs e)
        //{
            
        //}
    }
}
