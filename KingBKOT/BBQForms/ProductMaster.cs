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
            

        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow.Controls.Clear();
            lblHeaderDesc.Text = "Add Purchase Product(Raw Material)";

            PurchaseProducts db = new PurchaseProducts();
            MainWindow.Controls.Add(db);
            db.Dock = DockStyle.Fill;
            db.Show();
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
            
        }

        private void button4_Click(object sender, EventArgs e)
        { 
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductMaster_Load(object sender, EventArgs e)
        {
            MainWindow.Controls.Clear();
            lblHeaderDesc.Text = "Add Purchase Product(Raw Material)";

            PurchaseProducts db = new PurchaseProducts();
            MainWindow.Controls.Add(db);
            db.Dock = DockStyle.Fill;
            db.Show();
        }
    }
}
