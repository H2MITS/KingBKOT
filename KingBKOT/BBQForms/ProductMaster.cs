using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingBKOT.Forms
{
    public partial class ProductMaster : Form
    {
        public ProductMaster()
        {
            InitializeComponent();
            panel2.Height = button1.Height;
            panel2.Top = button1.Top;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Height = button1.Height;
            panel2.Top = button1.Top;
            menuProducts1.BringToFront();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            purchaseProducts1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuProducts1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Height = button5.Height;
            panel2.Top = button5.Top;
            addCategory1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Height = button4.Height;
            panel2.Top = button4.Top;
            listOfMenuProducts1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Height = button3.Height;
            panel2.Top = button3.Top;
            listofPurchaseProducts1.BringToFront();
        }
    }
}
