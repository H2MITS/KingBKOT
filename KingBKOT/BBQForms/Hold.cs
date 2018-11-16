using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingBarbeque
{
    public partial class Hold : Form
    {
        public Hold()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
        }
    }
}
