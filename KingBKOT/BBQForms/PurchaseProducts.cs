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
    public partial class PurchaseProducts : UserControl
    {
        private object keyboardProc;
        public PurchaseProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseProducts_Load(object sender, EventArgs e)
        {
            dateToday.Format = DateTimePickerFormat.Custom;
            dateToday.CustomFormat = "dd-MM-yyyy";
        }
    }
}
