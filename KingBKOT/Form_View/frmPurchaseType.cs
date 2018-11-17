using KingBKOT.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingBKOT.Form_View
{
    public partial class frmPurchaseType : Form
    {
        public frmPurchaseType()
        {
            InitializeComponent();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPurchaseProductView frmPro = new frmPurchaseProductView();
            frmPro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddPurchaseOrder frmPur = new frmAddPurchaseOrder(0);
            frmPur.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchaseReport frmPur = new PurchaseReport();
            frmPur.ShowDialog();
        }
    }
}
